#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_DEFERRED_PFNS_TO_FREE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(16)]
        public ulong NumberOfPages;
        [FieldOffset(24)]
        public uint TbFlushStamp;
    }
}