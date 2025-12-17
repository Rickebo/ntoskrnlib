#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MMPTE_TRANSITION
    {
        [FieldOffset(0)]
        public ulong Valid;
        [FieldOffset(0)]
        public ulong Write;
        [FieldOffset(0)]
        public ulong OnStandbyLookaside;
        [FieldOffset(0)]
        public ulong IoTracker;
        [FieldOffset(0)]
        public ulong SwizzleBit;
        [FieldOffset(0)]
        public ulong Protection;
        [FieldOffset(0)]
        public ulong Prototype;
        [FieldOffset(0)]
        public ulong Transition;
        [FieldOffset(0)]
        public ulong PageFrameNumber;
        [FieldOffset(0)]
        public ulong Unused;
    }
}