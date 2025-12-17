#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _WNF_STATE_DATA
    {
        [FieldOffset(0)]
        public _WNF_NODE_HEADER Header;
        [FieldOffset(4)]
        public uint AllocatedSize;
        [FieldOffset(8)]
        public uint DataSize;
        [FieldOffset(12)]
        public uint ChangeStamp;
    }
}