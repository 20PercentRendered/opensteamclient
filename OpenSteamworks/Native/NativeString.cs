using System;
using System.Runtime.InteropServices;

namespace OpenSteamworks.Native;

public class NativeString : IDisposable
{
    private StrPtr allocatedHandle = StrPtr.Zero;
    private uint _size = 0;
    private bool disposedValue;
    public uint size {
        get {
            return _size;
        }
        private set {
            _size = value;
        }
    }

    /// <summary>
    /// Equivelant of std::string.c_str(), but you can write to this one.
    /// </summary>
    public StrPtr c_str {
        get {
            return allocatedHandle;
        }
    }

    public string str {
        get {
            return Marshal.PtrToStringAuto(this.allocatedHandle)!;
        }
        set {
            unsafe {
                // Recalculate size and include null termination
                uint newSize = (uint)(value.Length + IntPtr.Size);

                CopyStrPtrAndFree(Marshal.StringToHGlobalAuto(value), newSize);
            }
        }
    }

    public static NativeString Allocate(uint size) {
        NativeString str = new NativeString();

        str.size = size;
        unsafe {
            str.allocatedHandle = (StrPtr)NativeMemory.AllocZeroed((uint)size);
        }

        return str;
    }

    public void Reallocate(uint newSize) {
        if (newSize == size) {
            return;
        }

        unsafe {
            // This is fine to do with data in the buffer, since realloc copies it.
            this.allocatedHandle = (StrPtr)NativeMemory.Realloc((void*)this.allocatedHandle, newSize);
            this.size = newSize;
        }
    }

    public void CopyStrPtr(StrPtr newTextPtr, uint newsize) {
        // Check if the new text fits, if not reallocate
        if (newsize > this.size) {
            Reallocate(newsize);
        }

        unsafe {
            NativeMemory.Copy((void*)newTextPtr, (void*)this.allocatedHandle, newsize);
        }
    }

    public void CopyStrPtrAndFree(StrPtr newTextPtr, uint newsize) {
        CopyStrPtr(newTextPtr, newsize);
        unsafe {
            NativeMemory.Free((void*)newTextPtr);
        }
    }

    private string StrPtrToString(StrPtr ptr) {
        unsafe {
            string? str = Marshal.PtrToStringAuto(ptr);
            if (str == null) {
                Console.WriteLine("WARNING: Marshalling StrPtr failed");
                return "";
            }   
            NativeMemory.Free((void*)ptr);
            return str;
        }
    }
    private NativeString() {
        
    }

    public static NativeString FromManaged(string managedString) {
        NativeString str = new NativeString();
        str.str = managedString;
        return str;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                this._size = 0;
                allocatedHandle = IntPtr.Zero;
            }

            unsafe {
                NativeMemory.Free((void*)this.allocatedHandle);
            }
            
            disposedValue = true;
        }
    }

    ~NativeString()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}