#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ETW_PMC_SUPPORT
    {
        [FieldOffset(0)]
        public IntPtr Source;
        [FieldOffset(8)]
        public uint HookIdCount;
        [FieldOffset(12)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] HookId;
        [FieldOffset(20)]
        public uint CountersCount;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public IntPtr[] ProcessorCtrs;
    }
}