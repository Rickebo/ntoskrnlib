#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMSECTION_FLAGS2
    {
        [FieldOffset(0)]
        public ushort PartitionId;
        [FieldOffset(2)]
        public byte NoCrossPartitionAccess;
        [FieldOffset(2)]
        public byte SubsectionCrossPartitionReferenceOverflow;
        [FieldOffset(2)]
        public byte UsingFileExtents;
    }
}