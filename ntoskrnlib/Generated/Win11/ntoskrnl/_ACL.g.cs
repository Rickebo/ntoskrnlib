#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _ACL
    {
        [FieldOffset(0)]
        public byte AclRevision;
        [FieldOffset(1)]
        public byte Sbz1;
        [FieldOffset(2)]
        public ushort AclSize;
        [FieldOffset(4)]
        public ushort AceCount;
        [FieldOffset(6)]
        public ushort Sbz2;
    }
}