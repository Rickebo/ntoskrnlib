#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _RTLP_PROCESS_HEAP_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _LIST_ENTRY DescriptorLink;
        [FieldOffset(16)]
        public IntPtr Heap;
        [FieldOffset(24)]
        public _unnamed_tag_ Flags;
        [FieldOffset(32)]
        public _unnamed_tag_ PseudoGlobalLock;
    }
}