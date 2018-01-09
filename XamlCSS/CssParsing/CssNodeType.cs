﻿namespace XamlCSS.CssParsing
{
    public enum CssNodeType
    {
        Unknown = 0,
        Selectors = 1,
        Selector = 2,
        Body = 3,
        Line = 4,
        Key = 5,
        Value = 6,
        Document = 7,
        NamespaceDeclaration = 8,
        NamespaceKeyword = 9,
        NamespaceAlias = 10,
        NamespaceValue = 11,
        StyleRule = 12,
        StyleDeclarationBlock = 13,
        StyleDeclaration = 14,
        SimpleSelectorSequence = 15,
        DoubleQuoteText = 16,
        SingleQuoteText = 17,
        VariableDeclaration = 18,
        VariableName = 19,
        VariableValue = 20,
        VariableReference = 21,
        PropertyTrigger = 22,
        DataTrigger = 23,
        EventTrigger = 24,
        KeyframesDeclaration = 25,
        PropertyTriggerProperty = 26,
        PropertyTriggerValue = 27,
        DataTriggerBinding = 28,
        DataTriggerValue = 29,
        EventTriggerEvent = 30,
        ActionDeclarationBlock = 31,
        MixinDeclaration = 32,
        MixinParameters = 33,
        MixinParameter = 34,
        MixinParameterDefaultValue = 35,
        MixinInclude = 36,
        MixinIncludeParameters = 37,
        MixinIncludeParameter = 38,
        ImportDeclaration = 39,
        EnterAction = 40,
        ExitAction = 41,
        ActionDeclaration = 42,
        ActionParameterBlock = 43,
        ActionParameter = 44,
        Extend = 45,
        GeneralDescendantCombinator = 46,
        DirectSiblingCombinator = 47,
        DirectDescendantCombinator = 48,
        GeneralSiblingCombinator = 49,
        IdSelector = 50,
        TypeSelector = 51,
        ClassSelector = 52,
        UniversalSelector = 53,
        AttributeSelector = 54,
        PseudoSelector = 55,
        ParentSelector = 56
    }
}
