#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ALPC_PROCESS_CONTEXT
    {
        [FieldOffset(0)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(8)]
        public _LIST_ENTRY ViewListHead;
        [FieldOffset(24)]
        public ulong PagedPoolQuotaCache;
    }
}