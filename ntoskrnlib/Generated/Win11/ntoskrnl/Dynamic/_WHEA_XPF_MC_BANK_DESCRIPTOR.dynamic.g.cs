using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_MC_BANK_DESCRIPTOR")]
    public sealed class _WHEA_XPF_MC_BANK_DESCRIPTOR : DynamicStructure
    {
        public byte BankNumber { get; }
        public byte ClearOnInitialization { get; }
        public byte StatusDataFormat { get; }
        public _XPF_MC_BANK_FLAGS Flags { get; }
        public uint ControlMsr { get; }
        public uint StatusMsr { get; }
        public uint AddressMsr { get; }
        public uint MiscMsr { get; }
        public ulong ControlData { get; }

        public _WHEA_XPF_MC_BANK_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_MC_BANK_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.BankNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.ClearOnInitialization),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.StatusDataFormat),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.Flags),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.ControlMsr),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.StatusMsr),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.AddressMsr),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.MiscMsr),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MC_BANK_DESCRIPTOR.ControlData),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_WHEA_XPF_MC_BANK_DESCRIPTOR>((mem, ptr) => new _WHEA_XPF_MC_BANK_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}