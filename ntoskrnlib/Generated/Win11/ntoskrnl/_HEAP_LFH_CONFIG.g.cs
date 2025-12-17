#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_LFH_CONFIG
    {
        [FieldOffset(0)]
        public _RTL_HP_LFH_CONFIG Global;
        [FieldOffset(4)]
        public uint EnablePrivateSlots;
    }
}