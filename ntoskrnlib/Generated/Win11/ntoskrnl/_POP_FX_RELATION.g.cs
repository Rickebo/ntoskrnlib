#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _POP_FX_RELATION
    {
        [FieldOffset(0)]
        public uint RelationType;
        [FieldOffset(8)]
        public ulong RelationLock;
        [FieldOffset(16)]
        public _unnamed_tag_ Flags;
        [FieldOffset(24)]
        public IntPtr ParentComponent;
        [FieldOffset(32)]
        public _LIST_ENTRY ParentLink;
        [FieldOffset(48)]
        public IntPtr ChildRelationLock;
        [FieldOffset(56)]
        public _LIST_ENTRY ChildLink;
    }
}