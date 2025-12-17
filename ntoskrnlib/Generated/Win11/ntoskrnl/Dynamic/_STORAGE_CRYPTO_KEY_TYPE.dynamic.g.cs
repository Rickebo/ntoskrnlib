using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_STORAGE_CRYPTO_KEY_TYPE")]
    public sealed class _STORAGE_CRYPTO_KEY_TYPE : DynamicStructure
    {
        public byte DirectKey { get; }
        public byte PlatformWrappedKey { get; }
        public byte PlutonWrappedKey { get; }
        public byte Reserved { get; }
        public byte AsUchar { get; }

        public _STORAGE_CRYPTO_KEY_TYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _STORAGE_CRYPTO_KEY_TYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_STORAGE_CRYPTO_KEY_TYPE.DirectKey),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_CRYPTO_KEY_TYPE.PlatformWrappedKey),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_CRYPTO_KEY_TYPE.PlutonWrappedKey),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_CRYPTO_KEY_TYPE.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_STORAGE_CRYPTO_KEY_TYPE.AsUchar),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_STORAGE_CRYPTO_KEY_TYPE>((mem, ptr) => new _STORAGE_CRYPTO_KEY_TYPE(mem, ptr), offsets);
        }
    }
}