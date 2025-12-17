#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_FORCED_COMMITS
    {
        [FieldOffset(0)]
        public uint Regular;
        [FieldOffset(4)]
        public uint Wrap;
    }
}