using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SJC.Compiler
{
    public enum IssueId
    {
        [Description("Compiler internal error, detail info: [{0}]")]
        InternalError = 0,

        [Description("Build config error, config not found: [{0}]")]
        BuildConfigError = 3,

        [Description("Reference assembly is not script assembly: [{0}]")]
        InvalidAssembly = 5,

        [Description("There is cross reference in the source files, it may cause script runtime error.")]
        CrossRef = 10,

        [Description("Does not support constructor overload.")]
        CtorOverload = 11,

        [Description("Enum field have both assign value and EnumValue attribute.")]
        EnumFieldTwoValue = 12,

        [Description("Enum field doesn't have assign value nor EnumValue attribute.")]
        EnumFieldNoValue = 14,

        [Description("Event is not supported.")]
        EventNotSupport = 15,

        [Description("Inner class is not supported.")]
        InnerClassNotSupport = 19,

        [Description("Constructor with parameter can not have object create initializer.")]
        CtorParamWithInitializer = 20,

        [Description("Throw must follow by expression.")]
        ThrowNothing = 22,

        [Description("Can not use non script target: [{0}].")]
        UseNonScript = 23,

        [Description("The identified specified in multiple catch clause must have same name.")]
        CatchSameName = 25,

        [Description("Native method body should be within /**/.")]
        NativeFormat = 26,

        [Description("Property declare is not supported.")]
        PropertyDeclareNotSupport = 27,

        [Description("Property access with complex operator may have issue.")]
        PropertyAccessIssue = 28,

        [Description("Unrecognized expression type [{0}].")]
        UnknownExpressionType = 29,

        [Description("Unrecognized composite operator [{0}].")]
        UnknownCompositeOperator = 30,

        [Description("Unrecognized unary operator [{0}].")]
        UnknownUnaryOperator = 31,

        [Description("Unrecognized symbol kind [{0}].")]
        UnknownSymbol = 32,

        [Description("Unrecognized property accessor [{0}].")]
        UnknownAccessor = 33,

        [Description("Only 1 field allowed in declare field.")]
        OneFieldOneLine = 34,

        [Description("Static property is not allowed.")]
        StaticProperty = 35,

        [Description("Static constructor is not allowed.")]
        StaticConstructor = 36,

        [Description("Unrecognized initialize syntax.")]
        UnknownInitializeSynatx = 37,

        [Description("Generic name unexpected.")]
        UnknownGenericName = 38,

        [Description("Conditional access not fully supported.")]
        ConditionalAccess = 39,

        [Description("String interpolation not supported.")]
        StringInterpolation = 49,

        [Description("Multiple assignment in one line not well supported.")]
        MultiAssignment = 50,

        [Description("Exception filter not supported.")]
        ExceptionFilter = 51,

        [Description("Linq operator not supported.")]
        LinqNotSupport = 52,

        [Description("Symbol [{0}] mark as compile time constant, but not declare as const.")]
        NotConstant = 60,

        [Description("Compiler can not bind semantic info. Try avoid use var keyword or anonymous type declare.")]
        SemanticBind = 70,

        [Description("Goto is not supported.")]
        GotoNotSupport = 100,

        [Description("Yield is not supported.")]
        YieldNotSupport = 101,

        [Description("Indexer is not supported.")]
        IndexerNotSupport = 102,

        [Description("Named parameter is not supported.")]
        NamedArgumentNotSupport = 103,

        [Description("Partial class is not supported.")]
        PartialNotSupport = 104,

        [Description("Base call is not supported, use call of framework method.")]
        BaseCallNotSupport = 105,

        [Description("Extension method is not supported.")]
        ExtensionMethodNotSupport = 106,

        [Description("Default parameter is not supported.")]
        DefaultParamNotSupport = 107,

        [Description("Lock is not supported.")]
        LockNotSupport = 108,

        [Description("Interface not supported in framework [{0}].")]
        InterfaceNotSupport = 110,

        [Description("Interface inherit is not supported.")]
        InterfaceInheritNotSupport = 111,

        [Description("Enum is not supported in framework [{0}].")]
        EnumNotSupport = 112,

        [Description("Enum inherit is not supported.")]
        EnumInheritNotSupport = 113,

        [Description("Converter operator is not supported.")]
        ConverterOperatorNotSupport = 114,

        [Description("Checked/Unchecked is not supported.")]
        CheckedNotSupport = 115,

        [Description("Using is not supported.")]
        UsingNotSupport = 116,

        [Description("Using alias is not supported.")]
        UsingAliasNotSupport = 117,

        [Description("Destructor is not supported.")]
        DestructorNotSupport = 118,

        [Description("Unsafe is not supported.")]
        UnsafeNotSupport = 119,

        [Description("Struct is not supported, use class instead.")]
        StructNotSupport = 120,

        [Description("Operator typeof is not supported.")]
        TypeOfNotSupport = 121,

        [Description("Operator sizeof is not supported.")]
        SizeOfNotSupport = 122,

        [Description("Extern is not supported.")]
        ExternNotSupport = 123,

        [Description("Multi dimension array not supported.")]
        MultiDimensionArrayAccessNotSupport = 124,

        [Description("Member type is not valid.")]
        InvalidMember = 256,

        [Description("Default expression detected, translate to 'null', but it might not correct.")]
        DefaultKeyword = 1024,

        [Description("Bind semantic info with overload resolution fail. only one candidate found.")]
        OverloadResolveOnlyOne = 1025,

        [Description("Dynamic type found, compile time check is skipped, it is your responsibility to verify correctness.")]
        DynamicType = 1026,

        [Description("String prefix @ is ignore.")]
        StringPrefixIgnore = 1027,

        [Description("Use this keyword with field has GlobalVariable attribute. Consider remove [this.]")]
        GlobalVarWithThis = 1028,

        [Description("When set property value in object initialize syntax, need follow correct naming conversion, you can ignore this warning in some framework(e.g. enyo).")]
        ObjectInitializeSyntaxSetProperty = 1030
    }
}
