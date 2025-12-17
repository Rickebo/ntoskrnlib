#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _ETW_LBR_SUPPORT
    {
        [FieldOffset(0)]
        public uint LbrHandle;
        [FieldOffset(4)]
        public uint LbrOptions;
        [FieldOffset(8)]
        public uint HookIdCount;
        [FieldOffset(12)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] HookId;
    }
}