using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STORAGE_HW_CRYPTO_DESCRIPTOR")]
    public sealed class _STORAGE_HW_CRYPTO_DESCRIPTOR : DynamicStructure
    {
        public _STORAGE_DESCRIPTOR_HEADER Header { get; }
        public uint NumKeysSupported { get; }
        public uint NumCryptoCapabilities { get; }
        public uint OffsetToCryptoCapabilities { get; }
        public uint SizeOfCryptoCapability { get; }
        public uint IceType { get; }
        public _STORAGE_SECURITY_COMPLIANCE_BITMASK SecurityComplianceBitmask { get; }
        public _STORAGE_CRYPTO_KEY_TYPE KeyTypeBitmask { get; }

        public _STORAGE_HW_CRYPTO_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STORAGE_HW_CRYPTO_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.NumKeysSupported),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.NumCryptoCapabilities),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.OffsetToCryptoCapabilities),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.SizeOfCryptoCapability),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.IceType),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.SecurityComplianceBitmask),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_STORAGE_HW_CRYPTO_DESCRIPTOR.KeyTypeBitmask),
                    new ulong[]
                    {
                        29UL
                    }
                }
            };
            Register<_STORAGE_HW_CRYPTO_DESCRIPTOR>((mem, ptr) => new _STORAGE_HW_CRYPTO_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}