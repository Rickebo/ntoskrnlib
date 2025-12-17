using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_MCA_SECTION")]
    public sealed class _WHEA_XPF_MCA_SECTION : DynamicStructure
    {
        public uint VersionNumber { get; }
        public uint CpuVendor { get; }
        public _LARGE_INTEGER Timestamp { get; }
        public uint ProcessorNumber { get; }
        public _MCG_STATUS GlobalStatus { get; }
        public ulong InstructionPointer { get; }
        public uint BankNumber { get; }
        public _MCI_STATUS Status { get; }
        public ulong Address { get; }
        public ulong Misc { get; }
        public uint ExtendedRegisterCount { get; }
        public uint ApicId { get; }
        public ulong[] ExtendedRegisters { get; }
        public _WHEA_AMD_EXTENDED_REGISTERS AMDExtendedRegisters { get; }
        public _MCG_CAP GlobalCapability { get; }
        public _XPF_RECOVERY_INFO RecoveryInfo { get; }
        public uint ExBankCount { get; }
        public uint[] BankNumberEx { get; }
        public byte[] StatusEx { get; }
        public ulong[] AddressEx { get; }
        public ulong[] MiscEx { get; }

        public _WHEA_XPF_MCA_SECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_XPF_MCA_SECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_XPF_MCA_SECTION.VersionNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.CpuVendor),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.Timestamp),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.ProcessorNumber),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.GlobalStatus),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.InstructionPointer),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.BankNumber),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.Status),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.Address),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.Misc),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.ExtendedRegisterCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.ApicId),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.ExtendedRegisters),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.AMDExtendedRegisters),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.GlobalCapability),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.RecoveryInfo),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.ExBankCount),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.BankNumberEx),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.StatusEx),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.AddressEx),
                    new ulong[]
                    {
                        680UL
                    }
                },
                {
                    nameof(_WHEA_XPF_MCA_SECTION.MiscEx),
                    new ulong[]
                    {
                        936UL
                    }
                }
            };
            Register<_WHEA_XPF_MCA_SECTION>((mem, ptr) => new _WHEA_XPF_MCA_SECTION(mem, ptr), offsets);
        }
    }
}