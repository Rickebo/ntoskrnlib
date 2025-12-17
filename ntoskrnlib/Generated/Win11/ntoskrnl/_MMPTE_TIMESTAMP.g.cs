#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MMPTE_TIMESTAMP
    {
        [FieldOffset(0)]
        public ulong MustBeZero;
        [FieldOffset(0)]
        public ulong Unused;
        [FieldOffset(0)]
        public ulong SwizzleBit;
        [FieldOffset(0)]
        public ulong Protection;
        [FieldOffset(0)]
        public ulong Prototype;
        [FieldOffset(0)]
        public ulong Transition;
        [FieldOffset(0)]
        public ulong PageFileLow;
        [FieldOffset(0)]
        public ulong Reserved;
        [FieldOffset(0)]
        public ulong GlobalTimeStamp;
    }
}