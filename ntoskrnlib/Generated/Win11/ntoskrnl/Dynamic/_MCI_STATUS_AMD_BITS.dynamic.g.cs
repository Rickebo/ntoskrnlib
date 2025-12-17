using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS_AMD_BITS")]
    public sealed class _MCI_STATUS_AMD_BITS : DynamicStructure
    {
        public ulong McaErrorCode { get; }
        public ulong ModelErrorCode { get; }
        public ulong ImplementationSpecific2 { get; }
        public ulong Poison { get; }
        public ulong Deferred { get; }
        public ulong ImplementationSpecific1 { get; }
        public ulong ContextCorrupt { get; }
        public ulong AddressValid { get; }
        public ulong MiscValid { get; }
        public ulong ErrorEnabled { get; }
        public ulong UncorrectedError { get; }
        public ulong StatusOverFlow { get; }
        public ulong Valid { get; }

        public _MCI_STATUS_AMD_BITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCI_STATUS_AMD_BITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCI_STATUS_AMD_BITS.McaErrorCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.ModelErrorCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.ImplementationSpecific2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.Poison),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.Deferred),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.ImplementationSpecific1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.ContextCorrupt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.AddressValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.MiscValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.ErrorEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.UncorrectedError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.StatusOverFlow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_AMD_BITS.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCI_STATUS_AMD_BITS>((mem, ptr) => new _MCI_STATUS_AMD_BITS(mem, ptr), offsets);
        }
    }
}