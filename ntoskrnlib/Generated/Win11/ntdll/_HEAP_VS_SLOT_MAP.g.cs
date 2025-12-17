#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _HEAP_VS_SLOT_MAP
    {
        [FieldOffset(0)]
        public ushort SlotRef;
        [FieldOffset(2)]
        public ushort ContentionRemapCount;
    }
}