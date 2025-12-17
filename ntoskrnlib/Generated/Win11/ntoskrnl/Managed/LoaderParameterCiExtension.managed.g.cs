using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_CI_EXTENSION")]
    public sealed class LoaderParameterCiExtension : DynamicStructure
    {
        [Offset(0UL)]
        public uint CodeIntegrityOptions { get => ReadHere<uint>(nameof(CodeIntegrityOptions)); set => WriteHere(nameof(CodeIntegrityOptions), value); }

        [Offset(4UL)]
        public uint UpgradeInProgress { get => ReadHere<uint>(nameof(UpgradeInProgress)); set => WriteHere(nameof(UpgradeInProgress), value); }

        [Offset(4UL)]
        public uint IsWinPE { get => ReadHere<uint>(nameof(IsWinPE)); set => WriteHere(nameof(IsWinPE), value); }

        [Offset(4UL)]
        public uint CustomKernelSignersAllowed { get => ReadHere<uint>(nameof(CustomKernelSignersAllowed)); set => WriteHere(nameof(CustomKernelSignersAllowed), value); }

        [Offset(4UL)]
        public uint StateSeparationEnabled { get => ReadHere<uint>(nameof(StateSeparationEnabled)); set => WriteHere(nameof(StateSeparationEnabled), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public LargeInteger WhqlEnforcementDate { get => ReadStructure<LargeInteger>(nameof(WhqlEnforcementDate)); set => WriteStructure(nameof(WhqlEnforcementDate), value); }

        [Offset(16UL)]
        public uint RevocationListOffset { get => ReadHere<uint>(nameof(RevocationListOffset)); set => WriteHere(nameof(RevocationListOffset), value); }

        [Offset(20UL)]
        public uint RevocationListSize { get => ReadHere<uint>(nameof(RevocationListSize)); set => WriteHere(nameof(RevocationListSize), value); }

        [Offset(24UL)]
        public uint CodeIntegrityPolicyOffset { get => ReadHere<uint>(nameof(CodeIntegrityPolicyOffset)); set => WriteHere(nameof(CodeIntegrityPolicyOffset), value); }

        [Offset(28UL)]
        public uint CodeIntegrityPolicySize { get => ReadHere<uint>(nameof(CodeIntegrityPolicySize)); set => WriteHere(nameof(CodeIntegrityPolicySize), value); }

        [Offset(32UL)]
        public uint CodeIntegrityPolicyHashOffset { get => ReadHere<uint>(nameof(CodeIntegrityPolicyHashOffset)); set => WriteHere(nameof(CodeIntegrityPolicyHashOffset), value); }

        [Offset(36UL)]
        public uint CodeIntegrityPolicyHashSize { get => ReadHere<uint>(nameof(CodeIntegrityPolicyHashSize)); set => WriteHere(nameof(CodeIntegrityPolicyHashSize), value); }

        [Offset(40UL)]
        public uint CodeIntegrityPolicyOriginalHashOffset { get => ReadHere<uint>(nameof(CodeIntegrityPolicyOriginalHashOffset)); set => WriteHere(nameof(CodeIntegrityPolicyOriginalHashOffset), value); }

        [Offset(44UL)]
        public uint CodeIntegrityPolicyOriginalHashSize { get => ReadHere<uint>(nameof(CodeIntegrityPolicyOriginalHashSize)); set => WriteHere(nameof(CodeIntegrityPolicyOriginalHashSize), value); }

        [Offset(48UL)]
        public int WeakCryptoPolicyLoadStatus { get => ReadHere<int>(nameof(WeakCryptoPolicyLoadStatus)); set => WriteHere(nameof(WeakCryptoPolicyLoadStatus), value); }

        [Offset(52UL)]
        public uint WeakCryptoPolicyOffset { get => ReadHere<uint>(nameof(WeakCryptoPolicyOffset)); set => WriteHere(nameof(WeakCryptoPolicyOffset), value); }

        [Offset(56UL)]
        public uint WeakCryptoPolicySize { get => ReadHere<uint>(nameof(WeakCryptoPolicySize)); set => WriteHere(nameof(WeakCryptoPolicySize), value); }

        [Offset(60UL)]
        public uint SecureBootPolicyOffset { get => ReadHere<uint>(nameof(SecureBootPolicyOffset)); set => WriteHere(nameof(SecureBootPolicyOffset), value); }

        [Offset(64UL)]
        public uint SecureBootPolicySize { get => ReadHere<uint>(nameof(SecureBootPolicySize)); set => WriteHere(nameof(SecureBootPolicySize), value); }

        [Offset(68UL)]
        public uint CurrentBootId { get => ReadHere<uint>(nameof(CurrentBootId)); set => WriteHere(nameof(CurrentBootId), value); }

        [Offset(72UL)]
        public LargeInteger RevocationListCreationTimeLCUType { get => ReadStructure<LargeInteger>(nameof(RevocationListCreationTimeLCUType)); set => WriteStructure(nameof(RevocationListCreationTimeLCUType), value); }

        [Offset(80UL)]
        public LargeInteger RevocationListCreationTimeLCUAntidoteType { get => ReadStructure<LargeInteger>(nameof(RevocationListCreationTimeLCUAntidoteType)); set => WriteStructure(nameof(RevocationListCreationTimeLCUAntidoteType), value); }

        [Offset(88UL)]
        public LargeInteger RevocationListCreationTimeUpdateType { get => ReadStructure<LargeInteger>(nameof(RevocationListCreationTimeUpdateType)); set => WriteStructure(nameof(RevocationListCreationTimeUpdateType), value); }

        [Offset(96UL)]
        public LargeInteger RevocationListCreationTimeUpdateAntidoteType { get => ReadStructure<LargeInteger>(nameof(RevocationListCreationTimeUpdateAntidoteType)); set => WriteStructure(nameof(RevocationListCreationTimeUpdateAntidoteType), value); }

        [Offset(104UL)]
        public uint CurrentRevocationListType { get => ReadHere<uint>(nameof(CurrentRevocationListType)); set => WriteHere(nameof(CurrentRevocationListType), value); }

        [Offset(108UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(112UL)]
        [Length(1)]
        public DynamicArray SerializedData { get => ReadStructure<DynamicArray>(nameof(SerializedData)); set => WriteStructure(nameof(SerializedData), value); }

        public LoaderParameterCiExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LoaderParameterCiExtension>();
        }
    }
}