﻿using Microsoft.Dynamics.Nav.CodeAnalysis.Diagnostics;

namespace BusinessCentral.LinterCop
{
    public static class DiagnosticDescriptors
    {
        public static readonly DiagnosticDescriptor Rule0000ErrorInRule = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0000", (LocalizableString)new LocalizableResourceString("Rule0000ErrorInRuleTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0000ErrorInRuleFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0000ErrorInRuleDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0000");

        public static readonly DiagnosticDescriptor Rule0001FlowFieldsShouldNotBeEditable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0001", (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditable", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0001");
        public static readonly DiagnosticDescriptor Rule0002CommitMustBeExplainedByComment = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0002", (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByComment", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0002");
        public static readonly DiagnosticDescriptor Rule0003DoNotUseObjectIDsInVariablesOrProperties = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0003", (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrProperties", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0003");
        public static readonly DiagnosticDescriptor Rule0004LookupPageIdAndDrillDownPageId = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0004", (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0004");
        public static readonly DiagnosticDescriptor Rule0005VariableCasingShouldNotDifferFromDeclaration = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0005", (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDifferFromDeclarationTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDifferFromDeclarationFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDifferFromDeclarationDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0005");
        public static readonly DiagnosticDescriptor Rule0006FieldNotAutoIncrementInTemporaryTable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0006", (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Error, true, (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0006");
        public static readonly DiagnosticDescriptor Rule0007DataPerCompanyShouldAlwaysBeSet = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0007", (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, false, (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0007");
        public static readonly DiagnosticDescriptor Rule0008NoFilterOperatorsInSetRange = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0008", (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0008");
        public static readonly DiagnosticDescriptor Rule0009CodeMetricsInfo = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0009", (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, false, (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0009");
        public static readonly DiagnosticDescriptor Rule0010CodeMetricsWarning = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0010", (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0010");
        public static readonly DiagnosticDescriptor Rule0011AccessPropertyShouldAlwaysBeSet = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0011", (LocalizableString)new LocalizableResourceString("Rule0011AccessPropertyShouldAlwaysBeSetTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0011AccessPropertyShouldAlwaysBeSetFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, false, (LocalizableString)new LocalizableResourceString("Rule0011AccessPropertyShouldAlwaysBeSetDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0011");
        public static readonly DiagnosticDescriptor Rule0012DoNotUseObjectIdInSystemFunctions = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0012", (LocalizableString)new LocalizableResourceString("Rule0012DoNotUseObjectIdInSystemFunctionsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0012DoNotUseObjectIdInSystemFunctionsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0012DoNotUseObjectIdInSystemFunctionsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0012");
        public static readonly DiagnosticDescriptor Rule0013CheckForNotBlankOnSingleFieldPrimaryKeys = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0013", (LocalizableString)new LocalizableResourceString("Rule0013CheckForNotBlankOnSingleFieldPrimaryKeysTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0013CheckForNotBlankOnSingleFieldPrimaryKeysFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0013CheckForNotBlankOnSingleFieldPrimaryKeysDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0013");
        public static readonly DiagnosticDescriptor Rule0014PermissionSetCaptionLength = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0014", (LocalizableString)new LocalizableResourceString("Rule0014PermissionSetCaptionLengthTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0014PermissionSetCaptionLengthFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0014PermissionSetCaptionLengthDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0014");
        public static readonly DiagnosticDescriptor Rule0015PermissionSetCoverage = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0015", (LocalizableString)new LocalizableResourceString("Rule0015PermissionSetCoverageTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0015PermissionSetCoverageFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0015PermissionSetCoverageDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0015");
        public static readonly DiagnosticDescriptor Rule0016CheckForMissingCaptions = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0016", (LocalizableString)new LocalizableResourceString("Rule0016CheckForMissingCaptionsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0016CheckForMissingCaptionsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0016CheckForMissingCaptionsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0016");
        public static readonly DiagnosticDescriptor Rule0017WriteToFlowField = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0017", (LocalizableString)new LocalizableResourceString("Rule0017WriteToFlowFieldTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0017WriteToFlowFieldFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0017WriteToFlowFieldDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0017");
        public static readonly DiagnosticDescriptor Rule0018NoEventsInInternalCodeunitsAnalyzerDescriptor = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0018", (LocalizableString)new LocalizableResourceString("Rule0018NoEventsInInternalCodeunitsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0018NoEventsInInternalCodeunitsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0018NoEventsInInternalCodeunitsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0018");
        public static readonly DiagnosticDescriptor Rule0019DataClassificationFieldEqualsTable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0019", (LocalizableString)new LocalizableResourceString("Rule0019DataClassificationFieldEqualsTableTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0019DataClassificationFieldEqualsTableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0019DataClassificationFieldEqualsTableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0019");
        public static readonly DiagnosticDescriptor Rule0020ApplicationAreaEqualsToPage = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0020", (LocalizableString)new LocalizableResourceString("Rule0020ApplicationAreaEqualsToPageTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0020ApplicationAreaEqualsToPageFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0020ApplicationAreaEqualsToPageDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0020");
        public static readonly DiagnosticDescriptor Rule0021ConfirmImplementConfirmManagement = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0021", (LocalizableString)new LocalizableResourceString("Rule0021ConfirmImplementConfirmManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0021ConfirmImplementConfirmManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0021ConfirmImplementConfirmManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0021");
        public static readonly DiagnosticDescriptor Rule0022GlobalLanguageImplementTranslationHelper = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0022", (LocalizableString)new LocalizableResourceString("Rule0022GlobalLanguageImplementTranslationHelperTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0022GlobalLanguageImplementTranslationHelperFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0022GlobalLanguageImplementTranslationHelperDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0022");
        public static readonly DiagnosticDescriptor Rule0023AlwaysSpecifyFieldgroups = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0023", (LocalizableString)new LocalizableResourceString("Rule0023AlwaysSpecifyFieldgroups", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0023AlwaysSpecifyFieldgroups", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0023AlwaysSpecifyFieldgroups", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0023");
        public static readonly DiagnosticDescriptor Rule0024SemicolonAfterProcedureDeclaration = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0024", (LocalizableString)new LocalizableResourceString("Rule0024SemicolonAfterProcedureDeclarationTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0024SemicolonAfterProcedureDeclarationFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0024SemicolonAfterProcedureDeclarationDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0024");
        public static readonly DiagnosticDescriptor Rule0025InternalProcedureModifier = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0025", (LocalizableString)new LocalizableResourceString("Rule0025InternalProcedureModifierTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0025InternalProcedureModifierFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, true, (LocalizableString)new LocalizableResourceString("Rule0025InternalProcedureModifierDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0025");
        public static readonly DiagnosticDescriptor Rule0026ToolTipMustEndWithDot = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0026", (LocalizableString)new LocalizableResourceString("Rule0026ToolTipMustEndWithDotTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0026ToolTipMustEndWithDotFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0026ToolTipMustEndWithDotDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0026");
        public static readonly DiagnosticDescriptor Rule0027RunPageImplementPageManagement = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0027", (LocalizableString)new LocalizableResourceString("Rule0027RunPageImplementPageManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0027RunPageImplementPageManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0027RunPageImplementPageManagement", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0027");
        public static readonly DiagnosticDescriptor Rule0028IdentifiersInEventSubscribers = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0028", (LocalizableString)new LocalizableResourceString("Rule0028IdentifiersInEventSubscribersTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0028IdentifiersInEventSubscribersFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0028IdentifiersInEventSubscribersDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0028");
        public static readonly DiagnosticDescriptor Rule0029CompareDateTimeThroughCodeunit = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0029", (LocalizableString)new LocalizableResourceString("Rule0029CompareDateTimeThroughCodeunitTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0029CompareDateTimeThroughCodeunitFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0029CompareDateTimeThroughCodeunitDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0029");
        public static readonly DiagnosticDescriptor Rule0030AccessInternalForInstallAndUpgradeCodeunits = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0030", (LocalizableString)new LocalizableResourceString("Rule0030AccessInternalForInstallAndUpgradeCodeunitsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0030AccessInternalForInstallAndUpgradeCodeunitsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0030AccessInternalForInstallAndUpgradeCodeunitsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0030");
        public static readonly DiagnosticDescriptor Rule0031RecordInstanceIsolationLevel = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0031", (LocalizableString)new LocalizableResourceString("Rule0031RecordInstanceIsolationLevelTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0031RecordInstanceIsolationLevelFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0031RecordInstanceIsolationLevelDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0031");
        public static readonly DiagnosticDescriptor Rule0032ClearCodeunitSingleInstance = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0032", (LocalizableString)new LocalizableResourceString("Rule0032ClearCodeunitSingleInstanceTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0032ClearCodeunitSingleInstanceFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0032ClearCodeunitSingleInstanceDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0032");
        public static readonly DiagnosticDescriptor Rule0033AppManifestRuntimeBehind = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0033", (LocalizableString)new LocalizableResourceString("Rule0033AppManifestRuntimeBehindTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0033AppManifestRuntimeBehindFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0033AppManifestRuntimeBehindTitleDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0033");
        public static readonly DiagnosticDescriptor Rule0034ExtensiblePropertyShouldAlwaysBeSet = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0034", (LocalizableString)new LocalizableResourceString("Rule0034ExtensiblePropertyShouldAlwaysBeSetTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0034ExtensiblePropertyShouldAlwaysBeSetFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, true, (LocalizableString)new LocalizableResourceString("Rule0034ExtensiblePropertyShouldAlwaysBeSetDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0034");
        public static readonly DiagnosticDescriptor Rule0040ZeroEnumValueReservedForEmpty = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0040", (LocalizableString)new LocalizableResourceString("Rule0040ZeroEnumValueReservedForEmptyTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0040ZeroEnumValueReservedForEmptyFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0040ZeroEnumValueReservedForEmptyDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0040");
        public static readonly DiagnosticDescriptor Rule0041TokLabelsLocked = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0041", (LocalizableString)new LocalizableResourceString("Rule0041TokLabelsLockedTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0041TokLabelsLockedFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0041TokLabelsLockedDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0041");
        public static readonly DiagnosticDescriptor Rule0041LockedLabelsTok = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0041", (LocalizableString)new LocalizableResourceString("Rule0041LockedLabelsTokTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0041LockedLabelsTokFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0041LockedLabelsTokDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0041");
        public static readonly DiagnosticDescriptor Rule0035ExplicitSetAllowInCustomizations = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0035", (LocalizableString)new LocalizableResourceString("Rule0035ExplicitSetAllowInCustomizationsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0035ExplicitSetAllowInCustomizationsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0035ExplicitSetAllowInCustomizationsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0035");
        public static readonly DiagnosticDescriptor Rule0036ToolTipShouldStartWithSpecifies = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0036", (LocalizableString)new LocalizableResourceString("Rule0036ToolTipShouldStartWithSpecifiesTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0036ToolTipShouldStartWithSpecifiesFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0036ToolTipShouldStartWithSpecifiesDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0036");
        public static readonly DiagnosticDescriptor Rule0037ToolTipDoNotUseLineBreaks = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0037", (LocalizableString)new LocalizableResourceString("Rule0037ToolTipDoNotUseLineBreaksTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0037ToolTipDoNotUseLineBreaksFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0037ToolTipDoNotUseLineBreaksDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0037");
        public static readonly DiagnosticDescriptor Rule0038ToolTipMaximumLength = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0038", (LocalizableString)new LocalizableResourceString("Rule0038ToolTipMaximumLengthTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0038ToolTipMaximumLengthFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0038ToolTipMaximumLengthDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0038");
        public static readonly DiagnosticDescriptor Rule0039ArgumentDifferentTypeThenExpected = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0039", (LocalizableString)new LocalizableResourceString("Rule0039ArgumentDifferentTypeThenExpectedTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0039ArgumentDifferentTypeThenExpectedFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0039ArgumentDifferentTypeThenExpectedDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0039");
        public static readonly DiagnosticDescriptor Rule0040ExplicitlySetRunTrigger = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0040", (LocalizableString)new LocalizableResourceString("Rule0040ExplicitlySetRunTriggerTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0040ExplicitlySetRunTriggerFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0040ExplicitlySetRunTriggerDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0040");
        public static readonly DiagnosticDescriptor Rule0041EmptyCaptionLocked = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0041", (LocalizableString)new LocalizableResourceString("Rule0041EmptyCaptionLockedTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0041EmptyCaptionLockedFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0041EmptyCaptionLockedDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0041");
        public static readonly DiagnosticDescriptor Rule0042AutoCalcFieldsOnNormalFields = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0042", (LocalizableString)new LocalizableResourceString("Rule0042AutoCalcFieldsOnNormalFieldsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0042AutoCalcFieldsOnNormalFieldsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0042AutoCalcFieldsOnNormalFieldsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0042");
        public static readonly DiagnosticDescriptor Rule0043SecretText = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0043", (LocalizableString)new LocalizableResourceString("Rule0043SecretTextTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0043SecretTextFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0043SecretTextDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0043");
        public static readonly DiagnosticDescriptor Rule0044AnalyzeTableExtension = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0044", (LocalizableString)new LocalizableResourceString("Rule0044AnalyzeTableExtensionTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0044AnalyzeTableExtensionFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0044AnalyzeTableExtensionDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0044");
        public static readonly DiagnosticDescriptor Rule0044AnalyzeTransferFields = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0044", (LocalizableString)new LocalizableResourceString("Rule0044AnalyzeTransferFieldsTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0044AnalyzeTransferFieldsFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, true, (LocalizableString)new LocalizableResourceString("Rule0044AnalyzeTransferFieldsDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "https://github.com/StefanMaron/BusinessCentral.LinterCop/wiki/LC0044");
    }
}