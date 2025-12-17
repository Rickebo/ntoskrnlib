#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ECP_LIST
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public uint Flags;
        [FieldOffset(8)]
        public _LIST_ENTRY EcpList;
    }
}