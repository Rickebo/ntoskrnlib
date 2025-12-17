#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _WHEA_REVISION
    {
        [FieldOffset(0)]
        public byte MinorRevision;
        [FieldOffset(1)]
        public byte MajorRevision;
        [FieldOffset(0)]
        public ushort AsUSHORT;
    }
}