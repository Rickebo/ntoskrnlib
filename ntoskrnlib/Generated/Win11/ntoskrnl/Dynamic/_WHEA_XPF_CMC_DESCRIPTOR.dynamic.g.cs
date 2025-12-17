using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_CMC_DESCRIPTOR")]
    public sealed class _WHEA_XPF_CMC_DESCRIPTOR : DynamicStructure
    {
        public ushort Type { get; }
        public byte Enabled { get; }
        public byte NumberOfBanks { get; }
        public uint Reserved { get; }
        public _WHEA_NOTIFICATION_DESCRIPTOR Notify { get; }
        public byte[] Banks { get; }

        public _WHEA_XPF_CMC_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_CMC_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_CMC_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_CMC_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_XPF_CMC_DESCRIPTOR.NumberOfBanks),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_XPF_CMC_DESCRIPTOR.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_XPF_CMC_DESCRIPTOR.Notify),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_XPF_CMC_DESCRIPTOR.Banks),
                    new ulong[]
                    {
                        36UL
                    }
                }
            };
            Register<_WHEA_XPF_CMC_DESCRIPTOR>((mem, ptr) => new _WHEA_XPF_CMC_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}