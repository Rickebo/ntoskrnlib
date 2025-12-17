using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_ADAPTER_CRYPTO_KEY_DESCRIPTOR")]
    public sealed class IoAdapterCryptoKeyDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public uint CryptoIndex { get => ReadHere<uint>(nameof(CryptoIndex)); set => WriteHere(nameof(CryptoIndex), value); }

        [Offset(12UL)]
        public uint AlgorithmId { get => ReadHere<uint>(nameof(AlgorithmId)); set => WriteHere(nameof(AlgorithmId), value); }

        [Offset(16UL)]
        public uint DataUnitSize { get => ReadHere<uint>(nameof(DataUnitSize)); set => WriteHere(nameof(DataUnitSize), value); }

        [Offset(20UL)]
        public uint KeySize { get => ReadHere<uint>(nameof(KeySize)); set => WriteHere(nameof(KeySize), value); }

        [Offset(24UL)]
        [Length(32)]
        public DynamicArray KeyHash { get => ReadStructure<DynamicArray>(nameof(KeyHash)); set => WriteStructure(nameof(KeyHash), value); }

        [Offset(56UL)]
        public IntPtr KeyVirtualAddress { get => ReadHere<IntPtr>(nameof(KeyVirtualAddress)); set => WriteHere(nameof(KeyVirtualAddress), value); }

        [Offset(64UL)]
        public LargeInteger KeyPhysicalAddress { get => ReadStructure<LargeInteger>(nameof(KeyPhysicalAddress)); set => WriteStructure(nameof(KeyPhysicalAddress), value); }

        [Offset(72UL)]
        public Guid KeyNamespaceId { get => ReadStructure<Guid>(nameof(KeyNamespaceId)); set => WriteStructure(nameof(KeyNamespaceId), value); }

        [Offset(88UL)]
        public int KeyType { get => ReadHere<int>(nameof(KeyType)); set => WriteHere(nameof(KeyType), value); }

        [Offset(96UL)]
        public IntPtr AdjustCryptoParametersCallback { get => ReadHere<IntPtr>(nameof(AdjustCryptoParametersCallback)); set => WriteHere(nameof(AdjustCryptoParametersCallback), value); }

        [Offset(104UL)]
        public IntPtr AdjustCryptoParametersCallbackContext { get => ReadHere<IntPtr>(nameof(AdjustCryptoParametersCallbackContext)); set => WriteHere(nameof(AdjustCryptoParametersCallbackContext), value); }

        public IoAdapterCryptoKeyDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoAdapterCryptoKeyDescriptor>();
        }
    }
}