#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _WNF_SCOPE_MAP_ENTRY
    {
        [FieldOffset(0)]
        public _WNF_LOCK MapEntryLock;
        [FieldOffset(8)]
        public _LIST_ENTRY MapEntryHead;
    }
}