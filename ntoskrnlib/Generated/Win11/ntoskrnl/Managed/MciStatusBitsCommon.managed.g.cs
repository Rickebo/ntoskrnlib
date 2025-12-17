using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS_BITS_COMMON")]
    public sealed class MciStatusBitsCommon : DynamicStructure
    {
        [Offset(0UL)]
        public ulong McaErrorCode { get => ReadHere<ulong>(nameof(McaErrorCode)); set => WriteHere(nameof(McaErrorCode), value); }

        [Offset(0UL)]
        public ulong ModelErrorCode { get => ReadHere<ulong>(nameof(ModelErrorCode)); set => WriteHere(nameof(ModelErrorCode), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

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

        public MciStatusBitsCommon(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MciStatusBitsCommon>();
        }
    }
}