#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WNF_NODE_HEADER
    {
        [FieldOffset(0)]
        public ushort NodeTypeCode;
        [FieldOffset(2)]
        public ushort NodeByteSize;
    }
}