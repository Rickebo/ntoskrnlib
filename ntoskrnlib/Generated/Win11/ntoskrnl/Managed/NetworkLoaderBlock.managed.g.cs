using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NETWORK_LOADER_BLOCK")]
    public sealed class NetworkLoaderBlock : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr DHCPServerACK { get => ReadHere<IntPtr>(nameof(DHCPServerACK)); set => WriteHere(nameof(DHCPServerACK), value); }

        [Offset(8UL)]
        public uint DHCPServerACKLength { get => ReadHere<uint>(nameof(DHCPServerACKLength)); set => WriteHere(nameof(DHCPServerACKLength), value); }

        [Offset(16UL)]
        public IntPtr BootServerReplyPacket { get => ReadHere<IntPtr>(nameof(BootServerReplyPacket)); set => WriteHere(nameof(BootServerReplyPacket), value); }

        [Offset(24UL)]
        public uint BootServerReplyPacketLength { get => ReadHere<uint>(nameof(BootServerReplyPacketLength)); set => WriteHere(nameof(BootServerReplyPacketLength), value); }

        public NetworkLoaderBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NetworkLoaderBlock>();
        }
    }
}