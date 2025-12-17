#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _HEAP_LFH_BLOCK_SLIST
    {
        [FieldOffset(0)]
        public ushort Next;
    }
}