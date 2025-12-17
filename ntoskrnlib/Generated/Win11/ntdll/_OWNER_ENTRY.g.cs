#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _OWNER_ENTRY
    {
        [FieldOffset(0)]
        public ulong OwnerThread;
        [FieldOffset(8)]
        public uint IoPriorityBoosted;
        [FieldOffset(8)]
        public uint OwnerReferenced;
        [FieldOffset(8)]
        public uint IoQoSPriorityBoosted;
        [FieldOffset(8)]
        public uint OwnerCount;
        [FieldOffset(8)]
        public uint TableSize;
    }
}