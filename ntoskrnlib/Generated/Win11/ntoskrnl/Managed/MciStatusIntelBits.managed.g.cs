using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS_INTEL_BITS")]
    public sealed class MciStatusIntelBits : DynamicStructure
    {
        [Offset(0UL)]
        public ulong McaErrorCode { get => ReadHere<ulong>(nameof(McaErrorCode)); set => WriteHere(nameof(McaErrorCode), value); }

        [Offset(0UL)]
        public ulong ModelErrorCode { get => ReadHere<ulong>(nameof(ModelErrorCode)); set => WriteHere(nameof(ModelErrorCode), value); }

        [Offset(0UL)]
        public ulong OtherInfo { get => ReadHere<ulong>(nameof(OtherInfo)); set => WriteHere(nameof(OtherInfo), value); }

        [Offset(0UL)]
        public ulong FirmwareUpdateError { get => ReadHere<ulong>(nameof(FirmwareUpdateError)); set => WriteHere(nameof(FirmwareUpdateError), value); }

        [Offset(0UL)]
        public ulong CorrectedErrorCount { get => ReadHere<ulong>(nameof(CorrectedErrorCount)); set => WriteHere(nameof(CorrectedErrorCount), value); }

        [Offset(0UL)]
        public ulong ThresholdErrorStatus { get => ReadHere<ulong>(nameof(ThresholdErrorStatus)); set => WriteHere(nameof(ThresholdErrorStatus), value); }

        [Offset(0UL)]
        public ulong ActionRequired { get => ReadHere<ulong>(nameof(ActionRequired)); set => WriteHere(nameof(ActionRequired), value); }

        [Offset(0UL)]
        public ulong Signalling { get => ReadHere<ulong>(nameof(Signalling)); set => WriteHere(nameof(Signalling), value); }

        [Offset(0UL)]
        public ulong ContextCorrupt { get => ReadHere<ulong>(nameof(ContextCorrupt)); set => WriteHere(nameof(ContextCorrupt), value); }

        [Offset(0UL)]
        public ulong AddressValid { get => ReadHere<ulong>(nameof(AddressValid)); set => WriteHere(nameof(AddressValid), value); }

        [Offset(0UL)]
        public ulong MiscValid { get => ReadHere<ulong>(nameof(MiscValid)); set => WriteHere(nameof(MiscValid), value); }

        [Offset(0UL)]
        public ulong ErrorEnabled { get => ReadHere<ulong>(nameof(ErrorEnabled)); set => WriteHere(nameof(ErrorEnabled), value); }

        [Offset(0UL)]
        public ulong UncorrectedError { get => ReadHere<ulong>(nameof(UncorrectedError)); set => WriteHere(nameof(UncorrectedError), value); }

        [Offset(0UL)]
        public ulong StatusOverFlow { get => ReadHere<ulong>(nameof(StatusOverFlow)); set => WriteHere(nameof(StatusOverFlow), value); }

        [Offset(0UL)]
        public ulong Valid { get => ReadHere<ulong>(nameof(Valid)); set => WriteHere(nameof(Valid), value); }

        public MciStatusIntelBits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MciStatusIntelBits>();
        }
    }
}