using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STORAGE_HW_CRYPTO_CAPABILITY")]
    public sealed class StorageHwCryptoCapability : DynamicStructure
    {
        [Offset(0UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public uint CryptoCapabilityIndex { get => ReadHere<uint>(nameof(CryptoCapabilityIndex)); set => WriteHere(nameof(CryptoCapabilityIndex), value); }

        [Offset(12UL)]
        public uint AlgorithmId { get => ReadHere<uint>(nameof(AlgorithmId)); set => WriteHere(nameof(AlgorithmId), value); }

        [Offset(16UL)]
        public uint KeySize { get => ReadHere<uint>(nameof(KeySize)); set => WriteHere(nameof(KeySize), value); }

        [Offset(20UL)]
        public uint DataUnitSizeBitmask { get => ReadHere<uint>(nameof(DataUnitSizeBitmask)); set => WriteHere(nameof(DataUnitSizeBitmask), value); }

        [Offset(24UL)]
        public ushort MaxIVBitSize { get => ReadHere<ushort>(nameof(MaxIVBitSize)); set => WriteHere(nameof(MaxIVBitSize), value); }

        [Offset(26UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(28UL)]
        public StorageSecurityComplianceBitmask SecurityComplianceBitmask { get => ReadStructure<StorageSecurityComplianceBitmask>(nameof(SecurityComplianceBitmask)); set => WriteStructure(nameof(SecurityComplianceBitmask), value); }

        public StorageHwCryptoCapability(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StorageHwCryptoCapability>();
        }
    }
}