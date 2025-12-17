#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct POWER_ACTION_POLICY
    {
        [FieldOffset(0)]
        public uint Action;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public uint EventCode;
    }
}