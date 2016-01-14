using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.CodeAnalysis;

namespace SJC.Compiler
{
    public static class TypeInfoExtension
    {
        public static bool IsEnumerable(this TypeInfo info)
        {
            if (info.Type.TypeKind == TypeKind.Array
                    || info.Type.SpecialType == SpecialType.System_Array
                    || info.Type.SpecialType == SpecialType.System_Collections_IEnumerable
                    || info.Type.SpecialType == SpecialType.System_Collections_Generic_IEnumerable_T)
                return true;
            foreach (var inf in info.Type.AllInterfaces)
            {
                if (inf.IsSameType(nameof(System.Collections), nameof(IEnumerable)))
                    return true;
            }
            return false;
        }

        public static bool DelegateReturnValue(this TypeInfo info)
        {
            if (info.ConvertedType.TypeKind == TypeKind.Delegate)
            {
                if (info.ConvertedType.Name == "Func")
                    return true;
                //Note:Action is false;
            }
            return false;
        }
    }
}
