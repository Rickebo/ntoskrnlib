using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STORAGE_CRYPTO_KEY_TYPE")]
    public sealed class StorageCryptoKeyType : DynamicStructure
    {
        [Offset(0UL)]
        public byte DirectKey { get => ReadHere<byte>(nameof(DirectKey)); set => WriteHere(nameof(DirectKey), value); }

        [Offset(0UL)]
        public byte PlatformWrappedKey { get => ReadHere<byte>(nameof(PlatformWrappedKey)); set => WriteHere(nameof(PlatformWrappedKey), value); }

        [Offset(0UL)]
        public byte PlutonWrappedKey { get => ReadHere<byte>(nameof(PlutonWrappedKey)); set => WriteHere(nameof(PlutonWrappedKey), value); }

        [Offset(0UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public byte AsUchar { get => ReadHere<byte>(nameof(AsUchar)); set => WriteHere(nameof(AsUchar), value); }

        public StorageCryptoKeyType(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StorageCryptoKeyType>();
        }
    }
}