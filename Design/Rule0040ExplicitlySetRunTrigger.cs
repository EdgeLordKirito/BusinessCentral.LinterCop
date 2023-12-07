using System.Collections.Immutable;
using Microsoft.Dynamics.Nav.CodeAnalysis;
using Microsoft.Dynamics.Nav.CodeAnalysis.Diagnostics;
using Microsoft.Dynamics.Nav.CodeAnalysis.Symbols;

namespace BusinessCentral.LinterCop.Design
{
    [DiagnosticAnalyzer]
    public class Rule0040ExplicitlySetRunTrigger : DiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } = ImmutableArray.Create<DiagnosticDescriptor>(DiagnosticDescriptors.Rule0040ExplicitlySetRunTrigger);

        private static readonly List<string> buildInMethodNames = new List<string>
        {
            "insert",
            "modify",
            "modifyall",
            "delete",
            "deleteall"
        };

        public override void Initialize(AnalysisContext context) => context.RegisterOperationAction(new Action<OperationAnalysisContext>(this.AnalyzeRunTriggerParameters), OperationKind.InvocationExpression);

        private void AnalyzeRunTriggerParameters(OperationAnalysisContext ctx)
        {
            if (ctx.ContainingSymbol.GetContainingObjectTypeSymbol().IsObsoletePending || ctx.ContainingSymbol.GetContainingObjectTypeSymbol().IsObsoleteRemoved) return;
            if (ctx.ContainingSymbol.IsObsoletePending || ctx.ContainingSymbol.IsObsoleteRemoved) return;

            IInvocationExpression operation = (IInvocationExpression)ctx.Operation;
            if (operation.TargetMethod.MethodKind != MethodKind.BuiltInMethod) return;
            if (!buildInMethodNames.Contains(operation.TargetMethod.Name.ToLowerInvariant())) return;

            // We need to verify that the method is called from Record variable to exclude cases like IsolatedStorage.Delete()
            if (!ctx.Operation.DescendantsAndSelf().Where(x => x.GetSymbol() != null)
                                                        .Where(x => x.Type.GetNavTypeKindSafe() == NavTypeKind.Record)
                                                        .Any()) return;

            if (operation.Arguments.Where(args => SemanticFacts.IsSameName(args.Parameter.Name, "RunTrigger")).SingleOrDefault() == null)
                ctx.ReportDiagnostic(Diagnostic.Create(DiagnosticDescriptors.Rule0040ExplicitlySetRunTrigger, ctx.Operation.Syntax.GetLocation()));
        }
    }
}