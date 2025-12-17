using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR")]
    public sealed class _IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR : DynamicStructure
    {
        public uint Version { get; }
        public uint Size { get; }
        public uint CryptoIndex { get; }
        public uint AlgorithmId { get; }
        public uint DataUnitSize { get; }
        public uint KeySize { get; }
        public byte[] KeyHash { get; }
        public IntPtr KeyVirtualAddress { get; }
        public _LARGE_INTEGER KeyPhysicalAddress { get; }
        public _GUID KeyNamespaceId { get; }
        public int KeyType { get; }
        public IntPtr AdjustCryptoParametersCallback { get; }
        public IntPtr AdjustCryptoParametersCallbackContext { get; }

        public _IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.CryptoIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.AlgorithmId),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.DataUnitSize),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.KeySize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.KeyHash),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.KeyVirtualAddress),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.KeyPhysicalAddress),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.KeyNamespaceId),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.KeyType),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.AdjustCryptoParametersCallback),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR.AdjustCryptoParametersCallbackContext),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR>((mem, ptr) => new _IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}