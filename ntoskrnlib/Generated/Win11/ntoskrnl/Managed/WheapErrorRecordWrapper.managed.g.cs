using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_RECORD_WRAPPER")]
    public sealed class WheapErrorRecordWrapper : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry WorkEntry { get => ReadStructure<ListEntry>(nameof(WorkEntry)); set => WriteStructure(nameof(WorkEntry), value); }

        [Offset(16UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(20UL)]
        public uint ProcessorNumber { get => ReadHere<uint>(nameof(ProcessorNumber)); set => WriteHere(nameof(ProcessorNumber), value); }

        [Offset(24UL)]
        public WheapErrorRecordWrapperFlags Flags { get => ReadStructure<WheapErrorRecordWrapperFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(28UL)]
        public int InUse { get => ReadHere<int>(nameof(InUse)); set => WriteHere(nameof(InUse), value); }

        [Offset(32UL)]
        public IntPtr ErrorSource { get => ReadHere<IntPtr>(nameof(ErrorSource)); set => WriteHere(nameof(ErrorSource), value); }

        [Offset(40UL)]
        public WheaErrorRecord ErrorRecord { get => ReadStructure<WheaErrorRecord>(nameof(ErrorRecord)); set => WriteStructure(nameof(ErrorRecord), value); }

        public WheapErrorRecordWrapper(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheapErrorRecordWrapper>();
        }
    }
}