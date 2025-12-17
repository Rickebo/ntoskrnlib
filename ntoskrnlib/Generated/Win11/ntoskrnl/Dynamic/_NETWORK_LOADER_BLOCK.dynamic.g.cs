using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NETWORK_LOADER_BLOCK")]
    public sealed class _NETWORK_LOADER_BLOCK : DynamicStructure
    {
        public IntPtr DHCPServerACK { get; }
        public uint DHCPServerACKLength { get; }
        public IntPtr BootServerReplyPacket { get; }
        public uint BootServerReplyPacketLength { get; }

        public _NETWORK_LOADER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NETWORK_LOADER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NETWORK_LOADER_BLOCK.DHCPServerACK),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NETWORK_LOADER_BLOCK.DHCPServerACKLength),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NETWORK_LOADER_BLOCK.BootServerReplyPacket),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NETWORK_LOADER_BLOCK.BootServerReplyPacketLength),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_NETWORK_LOADER_BLOCK>((mem, ptr) => new _NETWORK_LOADER_BLOCK(mem, ptr), offsets);
        }
    }
}