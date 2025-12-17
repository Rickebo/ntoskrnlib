#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _ETW_IPT_SUPPORT
    {
        [FieldOffset(0)]
        public IntPtr IptHandle;
        [FieldOffset(8)]
        public ulong IptOption;
        [FieldOffset(16)]
        public IntPtr EtwHwTraceExtInterface;
        [FieldOffset(24)]
        public uint HookIdCount;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public ushort[] HookId;
    }
}