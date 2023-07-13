using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Reflection;

namespace OpenSteamworks.Native.JIT
{
    public class InteropHelp
    {
        private static readonly GCHandle NullHandle = GCHandle.Alloc(new byte[0], GCHandleType.Pinned);

        /// <summary>
        /// Decodes IntPtr as if it were a UTF-8 string
        /// </summary>
        public static string DecodeUTF8String(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return null;

            int len = 0;
            while (Marshal.ReadByte(ptr, len) != 0) len++;

            if (len == 0)
                return string.Empty;

            byte[] buffer = new byte[len];
            Marshal.Copy(ptr, buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer);
        }

        /// <summary>
        /// Encodes string as an IntPtr
        /// </summary>
        public static IntPtr EncodeUTF8String(string str, out GCHandle handle)
        {
            if (str == null)
            {
                handle = NullHandle;
                return IntPtr.Zero;
            }

            var length = Encoding.UTF8.GetByteCount(str);
            byte[] buffer = new byte[length + 1];

            Encoding.UTF8.GetBytes(str, 0, str.Length, buffer, 0);

            handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            return handle.AddrOfPinnedObject();
        }

        public static void FreeString(ref GCHandle handle)
        {
            if (handle == NullHandle)
                return;

            handle.Free();
        }

        public class BitVector64
        {
            private UInt64 data;

            public BitVector64()
            {
            }
            public BitVector64(UInt64 value)
            {
                data = value;
            }

            public UInt64 Data
            {
                get { return data; }
                set { data = value; }
            }

            public UInt64 this[uint bitoffset, UInt64 valuemask]
            {
                get
                {
                    return (data >> (ushort)bitoffset) & valuemask;
                }
                set
                {
                    data = (data & ~(valuemask << (ushort)bitoffset)) | ((value & valuemask) << (ushort)bitoffset);
                }
            }
        }
    }
}
