using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_MCE_DESCRIPTOR")]
    public sealed class _WHEA_XPF_MCE_DESCRIPTOR : DynamicStructure
    {
        public ushort Type { get; }
        public byte Enabled { get; }
        public byte NumberOfBanks { get; }
        public _XPF_MCE_FLAGS Flags { get; }
        public ulong MCG_Capability { get; }
        public ulong MCG_GlobalControl { get; }
        public byte[] Banks { get; }

        public _WHEA_XPF_MCE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_MCE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.Enabled),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.NumberOfBanks),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.MCG_Capability),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.MCG_GlobalControl),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCE_DESCRIPTOR.Banks),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_WHEA_XPF_MCE_DESCRIPTOR>((mem, ptr) => new _WHEA_XPF_MCE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}