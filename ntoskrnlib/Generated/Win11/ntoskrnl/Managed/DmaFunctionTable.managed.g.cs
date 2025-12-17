using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_FUNCTION_TABLE")]
    public sealed class DmaFunctionTable : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr InitializeController { get => ReadHere<IntPtr>(nameof(InitializeController)); set => WriteHere(nameof(InitializeController), value); }

        [Offset(8UL)]
        public IntPtr ValidateRequestLineBinding { get => ReadHere<IntPtr>(nameof(ValidateRequestLineBinding)); set => WriteHere(nameof(ValidateRequestLineBinding), value); }

        [Offset(16UL)]
        public IntPtr QueryMaxFragments { get => ReadHere<IntPtr>(nameof(QueryMaxFragments)); set => WriteHere(nameof(QueryMaxFragments), value); }

        [Offset(24UL)]
        public IntPtr ProgramChannel { get => ReadHere<IntPtr>(nameof(ProgramChannel)); set => WriteHere(nameof(ProgramChannel), value); }

        [Offset(32UL)]
        public IntPtr ConfigureChannel { get => ReadHere<IntPtr>(nameof(ConfigureChannel)); set => WriteHere(nameof(ConfigureChannel), value); }

        [Offset(40UL)]
        public IntPtr FlushChannel { get => ReadHere<IntPtr>(nameof(FlushChannel)); set => WriteHere(nameof(FlushChannel), value); }

        [Offset(48UL)]
        public IntPtr HandleInterrupt { get => ReadHere<IntPtr>(nameof(HandleInterrupt)); set => WriteHere(nameof(HandleInterrupt), value); }

        [Offset(56UL)]
        public IntPtr ReadDmaCounter { get => ReadHere<IntPtr>(nameof(ReadDmaCounter)); set => WriteHere(nameof(ReadDmaCounter), value); }

        [Offset(64UL)]
        public IntPtr ReportCommonBuffer { get => ReadHere<IntPtr>(nameof(ReportCommonBuffer)); set => WriteHere(nameof(ReportCommonBuffer), value); }

        [Offset(72UL)]
        public IntPtr CancelTransfer { get => ReadHere<IntPtr>(nameof(CancelTransfer)); set => WriteHere(nameof(CancelTransfer), value); }

        public DmaFunctionTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaFunctionTable>();
        }
    }
}