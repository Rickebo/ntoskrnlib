#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1744)]
    public partial struct _HEAP_FAILURE_INFORMATION
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint StructureSize;
        [FieldOffset(8)]
        public uint FailureType;
        [FieldOffset(16)]
        public IntPtr HeapAddress;
        [FieldOffset(24)]
        public IntPtr Address;
        [FieldOffset(32)]
        public IntPtr Param1;
        [FieldOffset(40)]
        public IntPtr Param2;
        [FieldOffset(48)]
        public IntPtr Param3;
        [FieldOffset(56)]
        public IntPtr PreviousBlock;
        [FieldOffset(64)]
        public IntPtr NextBlock;
        [FieldOffset(72)]
        public _FAKE_HEAP_ENTRY ExpectedDecodedEntry;
        [FieldOffset(88)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public IntPtr[] StackTrace;
        [FieldOffset(344)]
        public byte HeapMajorVersion;
        [FieldOffset(345)]
        public byte HeapMinorVersion;
        [FieldOffset(352)]
        public _EXCEPTION_RECORD ExceptionRecord;
        [FieldOffset(512)]
        public _CONTEXT ContextRecord;
    }
}