#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _EX_PUSH_LOCK_AUTO_EXPAND_STATE
    {
        [FieldOffset(0)]
        public uint Expanded;
        [FieldOffset(0)]
        public uint Transitioning;
        [FieldOffset(0)]
        public uint Pageable;
        [FieldOffset(0)]
        public uint Value;
    }
}