#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _WNF_PERMANENT_DATA_STORE
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(8)]
        public _WNF_LOCK Lock;
        [FieldOffset(16)]
        public IntPtr Handle;
        [FieldOffset(24)]
        public _LIST_ENTRY Links;
        [FieldOffset(40)]
        public uint DataScopeType;
        [FieldOffset(44)]
        public uint ScopeInstanceIdSize;
    }
}