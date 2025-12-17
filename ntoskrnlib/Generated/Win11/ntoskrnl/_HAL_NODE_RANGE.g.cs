#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HAL_NODE_RANGE
    {
        [FieldOffset(0)]
        public ulong PageFrameIndex;
        [FieldOffset(8)]
        public uint Node;
    }
}