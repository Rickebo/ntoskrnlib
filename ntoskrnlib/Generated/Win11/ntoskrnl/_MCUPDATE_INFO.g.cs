#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _MCUPDATE_INFO
    {
        [FieldOffset(0)]
        public _LIST_ENTRY List;
        [FieldOffset(16)]
        public uint Status;
        [FieldOffset(24)]
        public ulong Id;
        [FieldOffset(32)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] VendorScratch;
    }
}