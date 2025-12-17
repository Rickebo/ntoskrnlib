#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _SEGMENT_FLAGS
    {
        [FieldOffset(0)]
        public ushort TotalNumberOfPtes4132;
        [FieldOffset(0)]
        public ushort LargePages;
        [FieldOffset(0)]
        public ushort DebugSymbolsLoaded;
        [FieldOffset(0)]
        public ushort WriteCombined;
        [FieldOffset(0)]
        public ushort NoCache;
        [FieldOffset(0)]
        public ushort ForceCollision;
        [FieldOffset(0)]
        public ushort Binary32;
        [FieldOffset(0)]
        public ushort Short0;
        [FieldOffset(2)]
        public byte DefaultProtectionMask;
        [FieldOffset(2)]
        public byte ContainsDebug;
        [FieldOffset(2)]
        public byte Spare;
        [FieldOffset(2)]
        public byte UChar1;
        [FieldOffset(3)]
        public _MI_SEGMENT_SIGNATURE_FLAGS Signature;
    }
}