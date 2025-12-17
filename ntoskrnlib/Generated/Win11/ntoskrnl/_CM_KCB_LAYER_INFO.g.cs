#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _CM_KCB_LAYER_INFO
    {
        [FieldOffset(0)]
        public _LIST_ENTRY LayerListEntry;
        [FieldOffset(16)]
        public IntPtr Kcb;
        [FieldOffset(24)]
        public IntPtr LowerLayer;
        [FieldOffset(32)]
        public _LIST_ENTRY UpperLayerListHead;
        [FieldOffset(48)]
        public _LIST_ENTRY DiscardedUpperLayerListHead;
    }
}