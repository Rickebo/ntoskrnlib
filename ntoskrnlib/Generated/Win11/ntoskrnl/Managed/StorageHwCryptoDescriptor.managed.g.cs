using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_STORAGE_HW_CRYPTO_DESCRIPTOR")]
    public sealed class StorageHwCryptoDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public StorageDescriptorHeader Header { get => ReadStructure<StorageDescriptorHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public uint NumKeysSupported { get => ReadHere<uint>(nameof(NumKeysSupported)); set => WriteHere(nameof(NumKeysSupported), value); }

        [Offset(12UL)]
        public uint NumCryptoCapabilities { get => ReadHere<uint>(nameof(NumCryptoCapabilities)); set => WriteHere(nameof(NumCryptoCapabilities), value); }

        [Offset(16UL)]
        public uint OffsetToCryptoCapabilities { get => ReadHere<uint>(nameof(OffsetToCryptoCapabilities)); set => WriteHere(nameof(OffsetToCryptoCapabilities), value); }

        [Offset(20UL)]
        public uint SizeOfCryptoCapability { get => ReadHere<uint>(nameof(SizeOfCryptoCapability)); set => WriteHere(nameof(SizeOfCryptoCapability), value); }

        [Offset(24UL)]
        public uint IceType { get => ReadHere<uint>(nameof(IceType)); set => WriteHere(nameof(IceType), value); }

        [Offset(28UL)]
        public StorageSecurityComplianceBitmask SecurityComplianceBitmask { get => ReadStructure<StorageSecurityComplianceBitmask>(nameof(SecurityComplianceBitmask)); set => WriteStructure(nameof(SecurityComplianceBitmask), value); }

        [Offset(29UL)]
        public StorageCryptoKeyType KeyTypeBitmask { get => ReadStructure<StorageCryptoKeyType>(nameof(KeyTypeBitmask)); set => WriteStructure(nameof(KeyTypeBitmask), value); }

        public StorageHwCryptoDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<StorageHwCryptoDescriptor>();
        }
    }
}