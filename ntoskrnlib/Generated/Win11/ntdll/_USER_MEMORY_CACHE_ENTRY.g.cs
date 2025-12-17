#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _USER_MEMORY_CACHE_ENTRY
    {
        [FieldOffset(0)]
        public _SLIST_HEADER UserBlocks;
        [FieldOffset(16)]
        public uint AvailableBlocks;
        [FieldOffset(20)]
        public uint MinimumDepth;
        [FieldOffset(24)]
        public uint CacheShiftThreshold;
        [FieldOffset(28)]
        public ushort Allocations;
        [FieldOffset(30)]
        public ushort Frees;
        [FieldOffset(32)]
        public ushort CacheHits;
    }
}