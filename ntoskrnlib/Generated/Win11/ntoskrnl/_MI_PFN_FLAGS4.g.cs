#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_PFN_FLAGS4
    {
        [FieldOffset(0)]
        public ulong PteFrame;
        [FieldOffset(0)]
        public ulong ResidentPage;
        [FieldOffset(0)]
        public ulong ResidentPageContainsBadPages;
        [FieldOffset(0)]
        public ulong Unused1;
        [FieldOffset(0)]
        public ulong Partition;
        [FieldOffset(0)]
        public ulong FileOnly;
        [FieldOffset(0)]
        public ulong PfnExists;
        [FieldOffset(0)]
        public ulong NodeFlinkHigh;
        [FieldOffset(0)]
        public ulong PageIdentity;
        [FieldOffset(0)]
        public ulong PrototypePte;
        [FieldOffset(0)]
        public ulong EntireField;
    }
}