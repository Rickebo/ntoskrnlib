#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _BLOB
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ResourceList;
        [FieldOffset(0)]
        public _SLIST_ENTRY FreeListEntry;
        [FieldOffset(16)]
        public _unnamed_tag_ u1;
        [FieldOffset(17)]
        public byte ResourceId;
        [FieldOffset(18)]
        public short CachedReferences;
        [FieldOffset(24)]
        public long ReferenceCount;
        [FieldOffset(32)]
        public _EX_PUSH_LOCK Lock;
    }
}