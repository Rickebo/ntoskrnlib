#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 528)]
    public partial struct _KSOFTWARE_INTERRUPT_BATCH
    {
        [FieldOffset(0)]
        public byte Level;
        [FieldOffset(1)]
        public byte TargetType;
        [FieldOffset(2)]
        public byte ReservedBatchInProgress;
        [FieldOffset(3)]
        public byte Spare;
        [FieldOffset(4)]
        public uint SingleTargetIndex;
        [FieldOffset(8)]
        public _KAFFINITY_EX MultipleTargetAffinity;
        [FieldOffset(272)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public ulong[] Padding;
    }
}