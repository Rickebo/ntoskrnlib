#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 104)]
    public partial struct FEATURE_ERROR
    {
        [FieldOffset(0)]
        public int hr;
        [FieldOffset(4)]
        public ushort lineNumber;
        [FieldOffset(8)]
        public IntPtr file;
        [FieldOffset(16)]
        public IntPtr process;
        [FieldOffset(24)]
        public IntPtr modulePath;
        [FieldOffset(32)]
        public uint callerReturnAddressOffset;
        [FieldOffset(40)]
        public IntPtr callerModule;
        [FieldOffset(48)]
        public IntPtr message;
        [FieldOffset(56)]
        public ushort originLineNumber;
        [FieldOffset(64)]
        public IntPtr originFile;
        [FieldOffset(72)]
        public IntPtr originModule;
        [FieldOffset(80)]
        public uint originCallerReturnAddressOffset;
        [FieldOffset(88)]
        public IntPtr originCallerModule;
        [FieldOffset(96)]
        public IntPtr originName;
    }
}