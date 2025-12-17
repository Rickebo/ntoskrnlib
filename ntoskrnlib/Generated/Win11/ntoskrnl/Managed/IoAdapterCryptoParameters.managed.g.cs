using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_ADAPTER_CRYPTO_PARAMETERS")]
    public sealed class IoAdapterCryptoParameters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Tweak { get => ReadHere<ulong>(nameof(Tweak)); set => WriteHere(nameof(Tweak), value); }

        [Offset(8UL)]
        public IntPtr KeyDescriptor { get => ReadHere<IntPtr>(nameof(KeyDescriptor)); set => WriteHere(nameof(KeyDescriptor), value); }

        public IoAdapterCryptoParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoAdapterCryptoParameters>();
        }
    }
}