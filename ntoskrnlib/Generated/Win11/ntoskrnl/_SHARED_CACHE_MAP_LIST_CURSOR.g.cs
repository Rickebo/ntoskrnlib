#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _SHARED_CACHE_MAP_LIST_CURSOR
    {
        [FieldOffset(0)]
        public _LIST_ENTRY SharedCacheMapLinks;
        [FieldOffset(16)]
        public uint Flags;
    }
}