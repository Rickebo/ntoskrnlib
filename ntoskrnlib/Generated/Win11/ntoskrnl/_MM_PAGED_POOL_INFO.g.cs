#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _MM_PAGED_POOL_INFO
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(8)]
        public ulong MaximumSize;
        [FieldOffset(16)]
        public ulong AllocatedPagedPool;
    }
}