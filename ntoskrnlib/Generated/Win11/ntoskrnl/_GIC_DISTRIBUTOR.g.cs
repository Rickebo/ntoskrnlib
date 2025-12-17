#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _GIC_DISTRIBUTOR
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public ushort Reserved1;
        [FieldOffset(4)]
        public uint Identifier;
        [FieldOffset(8)]
        public ulong ControllerPhysicalAddress;
        [FieldOffset(16)]
        public uint GsivBase;
        [FieldOffset(20)]
        public byte Version;
        [FieldOffset(21)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] Reserved;
    }
}