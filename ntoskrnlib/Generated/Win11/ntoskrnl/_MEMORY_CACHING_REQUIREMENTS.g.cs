#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MEMORY_CACHING_REQUIREMENTS
    {
        [FieldOffset(0)]
        public ulong BasePage;
        [FieldOffset(8)]
        public ulong PageCount;
        [FieldOffset(16)]
        public uint MemoryCachingType;
    }
}