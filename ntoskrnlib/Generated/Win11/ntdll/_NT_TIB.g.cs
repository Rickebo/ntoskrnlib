#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _NT_TIB
    {
        [FieldOffset(0)]
        public IntPtr ExceptionList;
        [FieldOffset(8)]
        public IntPtr StackBase;
        [FieldOffset(16)]
        public IntPtr StackLimit;
        [FieldOffset(24)]
        public IntPtr SubSystemTib;
        [FieldOffset(32)]
        public IntPtr FiberData;
        [FieldOffset(32)]
        public uint Version;
        [FieldOffset(40)]
        public IntPtr ArbitraryUserPointer;
        [FieldOffset(48)]
        public IntPtr Self;
    }
}