using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS_BITS_COMMON")]
    public sealed class _MCI_STATUS_BITS_COMMON : DynamicStructure
    {
        public ulong McaErrorCode { get; }
        public ulong ModelErrorCode { get; }
        public ulong Reserved { get; }
        public ulong ContextCorrupt { get; }
        public ulong AddressValid { get; }
        public ulong MiscValid { get; }
        public ulong ErrorEnabled { get; }
        public ulong UncorrectedError { get; }
        public ulong StatusOverFlow { get; }
        public ulong Valid { get; }

        public _MCI_STATUS_BITS_COMMON(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCI_STATUS_BITS_COMMON()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCI_STATUS_BITS_COMMON.McaErrorCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.ModelErrorCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.ContextCorrupt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.AddressValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.MiscValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.ErrorEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.UncorrectedError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.StatusOverFlow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATUS_BITS_COMMON.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCI_STATUS_BITS_COMMON>((mem, ptr) => new _MCI_STATUS_BITS_COMMON(mem, ptr), offsets);
        }
    }
}