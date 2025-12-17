#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _NETWORK_LOADER_BLOCK
    {
        [FieldOffset(0)]
        public IntPtr DHCPServerACK;
        [FieldOffset(8)]
        public uint DHCPServerACKLength;
        [FieldOffset(16)]
        public IntPtr BootServerReplyPacket;
        [FieldOffset(24)]
        public uint BootServerReplyPacketLength;
    }
}