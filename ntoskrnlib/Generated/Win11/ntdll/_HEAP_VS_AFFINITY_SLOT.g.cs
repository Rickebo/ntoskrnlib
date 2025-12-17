#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _HEAP_VS_AFFINITY_SLOT
    {
        [FieldOffset(0)]
        public IntPtr VsContext;
        [FieldOffset(8)]
        public ulong Lock;
        [FieldOffset(16)]
        public _RTL_RB_TREE FreeChunkTree;
        [FieldOffset(32)]
        public _LIST_ENTRY SubsegmentList;
        [FieldOffset(64)]
        public _HEAP_VS_DELAY_FREE_CONTEXT DelayFreeContext;
    }
}