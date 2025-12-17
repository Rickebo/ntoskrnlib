using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS_INTEL_BITS")]
    public sealed class _MCI_STATUS_INTEL_BITS : DynamicStructure
    {
        public ulong McaErrorCode { get; }
        public ulong ModelErrorCode { get; }
        public ulong OtherInfo { get; }
        public ulong FirmwareUpdateError { get; }
        public ulong CorrectedErrorCount { get; }
        public ulong ThresholdErrorStatus { get; }
        public ulong ActionRequired { get; }
        public ulong Signalling { get; }
        public ulong ContextCorrupt { get; }
        public ulong AddressValid { get; }
        public ulong MiscValid { get; }
        public ulong ErrorEnabled { get; }
        public ulong UncorrectedError { get; }
        public ulong StatusOverFlow { get; }
        public ulong Valid { get; }

        public _MCI_STATUS_INTEL_BITS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCI_STATUS_INTEL_BITS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCI_STATUS_INTEL_BITS.McaErrorCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.ModelErrorCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.OtherInfo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.FirmwareUpdateError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.CorrectedErrorCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.ThresholdErrorStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.ActionRequired),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.Signalling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.ContextCorrupt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.AddressValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.MiscValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.ErrorEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.UncorrectedError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.StatusOverFlow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_INTEL_BITS.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCI_STATUS_INTEL_BITS>((mem, ptr) => new _MCI_STATUS_INTEL_BITS(mem, ptr), offsets);
        }
    }
}