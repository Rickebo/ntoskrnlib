#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _PCI_BUSMASTER_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public uint Segment;
        [FieldOffset(8)]
        public _unnamed_tag_ DeviceRid;
        [FieldOffset(8)]
        public _unnamed_tag_ BridgeRid;
        [FieldOffset(8)]
        public _unnamed_tag_ MultipleBridges;
    }
}