using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenSteamworks.Native.JIT
{
    class JITInfoException : Exception
    {
        public JITInfoException(string message) : base(message) { }
    }

    class TypeJITInfo
    {
        public Type Type { get; private set; }
        public Type PierceType { get; private set; }
        public Type NativeType { get; private set; }

        public bool IsParams { get; set; }

        public TypeJITInfo(Type type)
        {
            Type = type;
            PierceType = Type.IsByRef ? Type.GetElementType() : Type;
            IsParams = false;
        }

        public bool IsArray { get { return Type.IsArray; } }
        public bool IsStringClass { get { return Type.GetTypeCode(Type) == TypeCode.String; } }
        public bool IsAutoClass { get { return Type == typeof(StringBuilder); } }
        public bool IsUnknownClass { get { return PierceType.IsClass && (!((new TypeJITInfo(PierceType)).IsStringClass)); } }
        public bool IsCreatableClass { get { return IsGeneric || Type.IsInterface || IsDelegate; } }
        public bool IsGeneric { get { return Type.IsGenericParameter; } }
        public bool IsDelegate { get { return Type.IsSubclassOf(typeof(MulticastDelegate)); } }
        public bool IsByRef { get { return Type.IsByRef; } }

        // determine whether this type will fit in a register and what the native type should be
        // returns: if param should be passed on stack (return values)
        public bool DetermineProps()
        {
            // strings and arrays.
            if (IsStringClass || IsArray || IsAutoClass)
            {
                NativeType = Type;
                return false;
            }

            // for a generic return or interface (to construct) return an IntPtr
            if (IsCreatableClass)
            {
                NativeType = typeof(IntPtr);
                return false;
            }

            // for a class (not a value type) we need to figure out what to do, CSteamID might implement InteropHelp.NativeType for example to tell us the value type
            if (IsUnknownClass)
            {
                var nativeAttribs = PierceType.GetCustomAttributes(typeof(NativeTypeAttribute), false);

                if (nativeAttribs.Length > 0)
                {
                    NativeType = ((NativeTypeAttribute)nativeAttribs[0]).NativeType;
                }
                else
                {
                    Console.WriteLine("IsArray: " + IsArray);
                    Console.WriteLine("IsStringClass: " + IsStringClass);
                    Console.WriteLine("IsAutoClass: " + IsAutoClass);
                    Console.WriteLine("IsUnknownClass: " + IsUnknownClass);
                    Console.WriteLine("IsCreatableClass: " + IsCreatableClass);
                    Console.WriteLine("IsGeneric: " + IsGeneric);
                    Console.WriteLine("IsDelegate: " + IsDelegate);
                    Console.WriteLine("IsByRef: " + IsByRef);

                    var pt = new TypeJITInfo(PierceType);
                    Console.WriteLine("PierceType.IsArray: " + pt.IsArray);
                    Console.WriteLine("PierceType.IsStringClass: " + pt.IsStringClass);
                    Console.WriteLine("PierceType.IsAutoClass: " + pt.IsAutoClass);
                    Console.WriteLine("PierceType.IsUnknownClass: " + pt.IsUnknownClass);
                    Console.WriteLine("PierceType.IsCreatableClass: " + pt.IsCreatableClass);
                    Console.WriteLine("PierceType.IsGeneric: " + pt.IsGeneric);
                    Console.WriteLine("PierceType.IsDelegate: " + pt.IsDelegate);
                    Console.WriteLine("PierceType.IsByRef: " + pt.IsByRef);
                    Console.WriteLine("PierceType=" + PierceType);

                    throw new JITInfoException("Not sure what to do with this type: " + Type);
                }

                return Marshal.SizeOf(NativeType) > 4; // IntPtr.Size;
            }
            else if (Type.IsEnum)
            {
                NativeType = Enum.GetUnderlyingType(Type);
                return Marshal.SizeOf(NativeType) > 4;
            }

            // otherwise, native type is the type
            NativeType = Type;

            // byref won't have a size
            if (IsByRef)
            {
                return false;
            }

            int size = Marshal.SizeOf(Type);
            return Type != typeof(UInt64) && size > 4; 
        }
    }

    class MethodJITInfo
    {
        public int VTableSlot { get; private set; }
        public TypeJITInfo ReturnType { get; private set; }
        public List<TypeJITInfo> Args { get; private set; }
        public string Name { get; private set; }
        public MethodInfo MethodInfo { get; private set; }

        public bool HasParams { get; private set; }

        public MethodJITInfo(int slot, MethodInfo method)
        {
            VTableSlot = slot;
            ReturnType = new TypeJITInfo(method.ReturnType);
            Name = method.Name;
            MethodInfo = method;

            Args = new List<TypeJITInfo>();

            foreach (ParameterInfo paramInfo in method.GetParameters())
            {
                TypeJITInfo typeInfo = new TypeJITInfo(paramInfo.ParameterType);

                if (paramInfo.GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0)
                {
                    HasParams = true;
                    typeInfo.IsParams = true;
                }

                Args.Add(typeInfo);
            }
        }
    }

    class ClassJITInfo
    {
        public List<MethodJITInfo> Methods { get; private set; }

        public ClassJITInfo(Type classType)
        {
            MethodInfo[] methods = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Methods = new List<MethodJITInfo>(methods.Length);

            for (int i = 0; i < methods.Length; i++)
            {
                Methods.Add(new MethodJITInfo(i, methods[i]));
            }
        }
    }
}
