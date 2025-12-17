using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RSDP")]
    public sealed class _RSDP : DynamicStructure
    {
        public ulong Signature { get; }
        public byte Checksum { get; }
        public byte[] OEMID { get; }
        public byte Revision { get; }
        public uint RsdtAddress { get; }
        public uint Length { get; }
        public _LARGE_INTEGER XsdtAddress { get; }
        public byte XChecksum { get; }
        public byte[] Reserved { get; }

        public _RSDP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RSDP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RSDP.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RSDP.Checksum),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RSDP.OEMID),
                    new ulong[]
                    {
                        9UL
                    }
                },
                {
                    nameof(_RSDP.Revision),
                    new ulong[]
                    {
                        15UL
                    }
                },
                {
                    nameof(_RSDP.RsdtAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RSDP.Length),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_RSDP.XsdtAddress),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RSDP.XChecksum),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RSDP.Reserved),
                    new ulong[]
                    {
                        33UL
                    }
                }
            };
            Register<_RSDP>((mem, ptr) => new _RSDP(mem, ptr), offsets);
        }
    }
}