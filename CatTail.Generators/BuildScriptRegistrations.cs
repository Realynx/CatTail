using System.Text;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Realynx.CatTail.Generators;

[Generator]
public class BuildScriptRegistrations : IIncrementalGenerator {
    public void Initialize(IncrementalGeneratorInitializationContext context) {
        // Grab all class symbols with a base list
        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (node, _) => node is ClassDeclarationSyntax { BaseList: not null },
                transform: static (context, token) => (INamedTypeSymbol?)context.SemanticModel.GetDeclaredSymbol(context.Node, token)
            )
            .Where(symbol => symbol is not null);

        // Get the IBuildScript symbol from the compilation
        var buildScriptInterface = context.CompilationProvider
            .Select((compilation, _) => compilation.GetTypeByMetadataName("Realynx.CatTail.Interfaces.IBuildScript"));

        // Pair up class declarations with the IBuildScript symbol
        var buildScripts = classDeclarations.Combine(buildScriptInterface)
            .Where(pair =>
                pair.Left is not null &&
                pair.Right is not null &&
                pair.Left!.AllInterfaces.Contains(pair.Right, SymbolEqualityComparer.Default))
            .Select((pair, _) => pair.Left!);

        // Generate source
        context.RegisterSourceOutput(buildScripts.Collect(), (spc, scripts) => {
            var sb = new StringBuilder(
                """
                using Microsoft.Extensions.DependencyInjection;

                namespace Realynx.CatTail.Generators.Generated {
                  public static class BuildScriptServiceCollectionExtensions {
                    public static IServiceCollection AddBuildScripts(this IServiceCollection services) {
                    
                """);

            foreach (var type in scripts.Distinct(SymbolEqualityComparer.Default)) {
                sb.AppendLine($"      services.AddSingleton<IBuildScript, {type.ContainingNamespace.ToDisplayString()}.{type.ToDisplayString()}>();");
            }

            sb.Append(
                """
                      return services;
                    }
                  }
                }
                """);

            spc.AddSource("BuildScriptRegistration.g.cs", sb.ToString());
        });
    }
}