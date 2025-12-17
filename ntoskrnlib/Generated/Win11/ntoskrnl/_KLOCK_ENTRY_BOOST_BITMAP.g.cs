#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KLOCK_ENTRY_BOOST_BITMAP
    {
        [FieldOffset(0)]
        public ulong AllFields;
        [FieldOffset(0)]
        public uint AllBoosts;
        [FieldOffset(4)]
        public uint WaiterCounts;
        [FieldOffset(0)]
        public uint CpuBoostsBitmap;
        [FieldOffset(0)]
        public uint IoBoost;
        [FieldOffset(0)]
        public uint IoQoSBoost;
        [FieldOffset(4)]
        public uint IoNormalPriorityWaiterCount;
        [FieldOffset(4)]
        public uint IoQoSWaiterCount;
    }
}