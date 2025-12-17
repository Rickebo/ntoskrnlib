#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _MMWSL_INSTANCE
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public IntPtr[] PteResumePoint;
        [FieldOffset(24)]
        public uint LastAccessClearingRemainder;
        [FieldOffset(28)]
        public uint LastAgingRemainder;
        [FieldOffset(32)]
        public ulong LockedEntries;
        [FieldOffset(64)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public _MI_WORKING_SET_PAGE_TABLE_AGE_LINKS[] ActivePageTableLinks;
    }
}