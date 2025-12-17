#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MMPTE_SUBSECTION
    {
        [FieldOffset(0)]
        public ulong Valid;
        [FieldOffset(0)]
        public ulong Unused0;
        [FieldOffset(0)]
        public ulong OnStandbyLookaside;
        [FieldOffset(0)]
        public ulong SwizzleBit;
        [FieldOffset(0)]
        public ulong Protection;
        [FieldOffset(0)]
        public ulong Prototype;
        [FieldOffset(0)]
        public ulong ColdPage;
        [FieldOffset(0)]
        public ulong Unused2;
        [FieldOffset(0)]
        public ulong ExecutePrivilege;
        [FieldOffset(0)]
        public long SubsectionAddress;
    }
}