#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MMSECURE_FLAGS
    {
        [FieldOffset(0)]
        public uint ReadOnly;
        [FieldOffset(0)]
        public uint ReadWrite;
        [FieldOffset(0)]
        public uint SecNoChange;
        [FieldOffset(0)]
        public uint NoDelete;
        [FieldOffset(0)]
        public uint RequiresPteReversal;
        [FieldOffset(0)]
        public uint ExclusiveSecure;
        [FieldOffset(0)]
        public uint UserModeOnly;
        [FieldOffset(0)]
        public uint NoInherit;
        [FieldOffset(0)]
        public uint CheckVad;
        [FieldOffset(0)]
        public uint Spare;
    }
}