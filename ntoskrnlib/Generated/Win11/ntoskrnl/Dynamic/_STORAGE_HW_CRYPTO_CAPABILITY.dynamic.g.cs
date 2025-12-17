using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STORAGE_HW_CRYPTO_CAPABILITY")]
    public sealed class _STORAGE_HW_CRYPTO_CAPABILITY : DynamicStructure
    {
        public uint Version { get; }
        public uint Size { get; }
        public uint CryptoCapabilityIndex { get; }
        public uint AlgorithmId { get; }
        public uint KeySize { get; }
        public uint DataUnitSizeBitmask { get; }
        public ushort MaxIVBitSize { get; }
        public ushort Reserved { get; }
        public _STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask { get; }

        public _STORAGE_HW_CRYPTO_CAPABILITY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STORAGE_HW_CRYPTO_CAPABILITY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.CryptoCapabilityIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.AlgorithmId),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.KeySize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.DataUnitSizeBitmask),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.MaxIVBitSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.Reserved),
                    new ulong[]
                    {
                        26UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_CAPABILITY.SecurityComplianceBitmask),
                    new ulong[]
                    {
                        28UL
                    }
                }
            };
            Register<_STORAGE_HW_CRYPTO_CAPABILITY>((mem, ptr) => new _STORAGE_HW_CRYPTO_CAPABILITY(mem, ptr), offsets);
        }
    }
}