#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 3)]
    public partial struct _MI_RESTRICTED_MODWRITES
    {
        [FieldOffset(0)]
        public byte MaximumClusterPages;
        [FieldOffset(1)]
        public byte ReducedClusterWrites;
        [FieldOffset(2)]
        public byte ImposeDelay;
    }
}