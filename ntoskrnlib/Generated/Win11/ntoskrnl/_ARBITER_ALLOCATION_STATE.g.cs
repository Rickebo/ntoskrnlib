#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _ARBITER_ALLOCATION_STATE
    {
        [FieldOffset(0)]
        public ulong Start;
        [FieldOffset(8)]
        public ulong End;
        [FieldOffset(16)]
        public ulong CurrentMinimum;
        [FieldOffset(24)]
        public ulong CurrentMaximum;
        [FieldOffset(32)]
        public IntPtr Entry;
        [FieldOffset(40)]
        public IntPtr CurrentAlternative;
        [FieldOffset(48)]
        public uint AlternativeCount;
        [FieldOffset(56)]
        public IntPtr Alternatives;
        [FieldOffset(64)]
        public ushort Flags;
        [FieldOffset(66)]
        public byte RangeAttributes;
        [FieldOffset(67)]
        public byte RangeAvailableAttributes;
        [FieldOffset(72)]
        public ulong WorkSpace;
    }
}