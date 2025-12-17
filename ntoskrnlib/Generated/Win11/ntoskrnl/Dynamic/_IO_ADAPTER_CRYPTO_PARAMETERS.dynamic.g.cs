using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_ADAPTER_CRYPTO_PARAMETERS")]
    public sealed class _IO_ADAPTER_CRYPTO_PARAMETERS : DynamicStructure
    {
        public ulong Tweak { get; }
        public IntPtr KeyDescriptor { get; }

        public _IO_ADAPTER_CRYPTO_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_ADAPTER_CRYPTO_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_ADAPTER_CRYPTO_PARAMETERS.Tweak),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_ADAPTER_CRYPTO_PARAMETERS.KeyDescriptor),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_IO_ADAPTER_CRYPTO_PARAMETERS>((mem, ptr) => new _IO_ADAPTER_CRYPTO_PARAMETERS(mem, ptr), offsets);
        }
    }
}