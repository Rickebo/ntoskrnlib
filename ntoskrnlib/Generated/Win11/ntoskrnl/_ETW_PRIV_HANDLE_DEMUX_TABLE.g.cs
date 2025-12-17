#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ETW_PRIV_HANDLE_DEMUX_TABLE
    {
        [FieldOffset(0)]
        public _RTL_RB_TREE Tree;
        [FieldOffset(16)]
        public _EX_PUSH_LOCK Lock;
        [FieldOffset(24)]
        public ushort SequenceNumber;
    }
}