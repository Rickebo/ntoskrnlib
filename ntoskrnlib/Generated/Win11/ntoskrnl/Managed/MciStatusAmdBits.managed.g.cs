using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS_AMD_BITS")]
    public sealed class MciStatusAmdBits : DynamicStructure
    {
        [Offset(0UL)]
        public ulong McaErrorCode { get => ReadHere<ulong>(nameof(McaErrorCode)); set => WriteHere(nameof(McaErrorCode), value); }

        [Offset(0UL)]
        public ulong ModelErrorCode { get => ReadHere<ulong>(nameof(ModelErrorCode)); set => WriteHere(nameof(ModelErrorCode), value); }

        [Offset(0UL)]
        public ulong ImplementationSpecific2 { get => ReadHere<ulong>(nameof(ImplementationSpecific2)); set => WriteHere(nameof(ImplementationSpecific2), value); }

        [Offset(0UL)]
        public ulong Poison { get => ReadHere<ulong>(nameof(Poison)); set => WriteHere(nameof(Poison), value); }

        [Offset(0UL)]
        public ulong Deferred { get => ReadHere<ulong>(nameof(Deferred)); set => WriteHere(nameof(Deferred), value); }

        [Offset(0UL)]
        public ulong ImplementationSpecific1 { get => ReadHere<ulong>(nameof(ImplementationSpecific1)); set => WriteHere(nameof(ImplementationSpecific1), value); }

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

        public MciStatusAmdBits(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MciStatusAmdBits>();
        }
    }
}