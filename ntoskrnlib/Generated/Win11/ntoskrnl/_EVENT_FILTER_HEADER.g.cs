#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EVENT_FILTER_HEADER
    {
        [FieldOffset(0)]
        public ushort Id;
        [FieldOffset(2)]
        public byte Version;
        [FieldOffset(3)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
        public byte[] Reserved;
        [FieldOffset(8)]
        public ulong InstanceId;
        [FieldOffset(16)]
        public uint Size;
        [FieldOffset(20)]
        public uint NextOffset;
    }
}