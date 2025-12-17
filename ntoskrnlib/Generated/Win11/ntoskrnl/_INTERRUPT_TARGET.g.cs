#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _INTERRUPT_TARGET
    {
        [FieldOffset(0)]
        public uint Target;
        [FieldOffset(8)]
        public uint PhysicalTarget;
        [FieldOffset(8)]
        public uint LogicalFlatTarget;
        [FieldOffset(8)]
        public uint RemapIndex;
        [FieldOffset(8)]
        public uint ClusterId;
        [FieldOffset(12)]
        public uint ClusterMask;
        [FieldOffset(8)]
        public _unnamed_tag_ HypervisorTarget;
    }
}