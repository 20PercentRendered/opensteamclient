using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSteamworks.Native.JIT
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    class NativeTypeAttribute : Attribute
    {
        public Type NativeType { get; set; }

        public NativeTypeAttribute(Type t)
        {
            NativeType = t;
        }
    }
}
