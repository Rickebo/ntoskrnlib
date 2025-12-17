#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_LFH_MEM_POLICIES
    {
        [FieldOffset(0)]
        public uint DisableAffinity;
        [FieldOffset(0)]
        public uint SlowSubsegmentGrowth;
        [FieldOffset(0)]
        public uint Spare;
        [FieldOffset(0)]
        public uint AllPolicies;
    }
}