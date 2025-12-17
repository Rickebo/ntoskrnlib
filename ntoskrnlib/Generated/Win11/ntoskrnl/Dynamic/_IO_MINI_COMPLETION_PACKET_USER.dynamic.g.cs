using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_MINI_COMPLETION_PACKET_USER")]
    public sealed class _IO_MINI_COMPLETION_PACKET_USER : DynamicStructure
    {
        public _LIST_ENTRY ListEntry { get; }
        public uint PacketType { get; }
        public IntPtr KeyContext { get; }
        public IntPtr ApcContext { get; }
        public int IoStatus { get; }
        public ulong IoStatusInformation { get; }
        public IntPtr MiniPacketCallback { get; }
        public IntPtr Context { get; }
        public byte Allocated { get; }

        public _IO_MINI_COMPLETION_PACKET_USER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_MINI_COMPLETION_PACKET_USER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.ListEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.PacketType),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.KeyContext),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.ApcContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.IoStatus),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.IoStatusInformation),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.MiniPacketCallback),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.Context),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IO_MINI_COMPLETION_PACKET_USER.Allocated),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_IO_MINI_COMPLETION_PACKET_USER>((mem, ptr) => new _IO_MINI_COMPLETION_PACKET_USER(mem, ptr), offsets);
        }
    }
}