#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _MMINPAGE_SUPPORT_FLOW_THROUGH
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] Page;
        [FieldOffset(8)]
        public IntPtr InitialInPageSupport;
        [FieldOffset(16)]
        public IntPtr PagingFile;
        [FieldOffset(24)]
        public uint PageFileOffset;
        [FieldOffset(32)]
        public _RTL_BALANCED_NODE Node;
    }
}