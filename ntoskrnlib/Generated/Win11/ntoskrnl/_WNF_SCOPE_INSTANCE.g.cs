#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _WNF_SCOPE_INSTANCE
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public _EX_RUNDOWN_REF RunRef;
        [FieldOffset(16)]
        public uint DataScope;
        [FieldOffset(20)]
        public uint InstanceIdSize;
        [FieldOffset(24)]
        public IntPtr InstanceIdData;
        [FieldOffset(32)]
        public _LIST_ENTRY ResolverListEntry;
        [FieldOffset(48)]
        public _WNF_LOCK NameSetLock;
        [FieldOffset(56)]
        public _RTL_AVL_TREE NameSet;
        [FieldOffset(64)]
        public IntPtr PermanentDataStore;
        [FieldOffset(72)]
        public IntPtr VolatilePermanentDataStore;
    }
}