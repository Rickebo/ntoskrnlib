using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_EVENT_LOG_ENTRY_FLAGS")]
    public sealed class WheaEventLogEntryFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(0UL)]
        public uint LogInternalEtw { get => ReadHere<uint>(nameof(LogInternalEtw)); set => WriteHere(nameof(LogInternalEtw), value); }

        [Offset(0UL)]
        public uint LogBlackbox { get => ReadHere<uint>(nameof(LogBlackbox)); set => WriteHere(nameof(LogBlackbox), value); }

        [Offset(0UL)]
        public uint LogSel { get => ReadHere<uint>(nameof(LogSel)); set => WriteHere(nameof(LogSel), value); }

        [Offset(0UL)]
        public uint RawSel { get => ReadHere<uint>(nameof(RawSel)); set => WriteHere(nameof(RawSel), value); }

        [Offset(0UL)]
        public uint NoFormat { get => ReadHere<uint>(nameof(NoFormat)); set => WriteHere(nameof(NoFormat), value); }

        [Offset(0UL)]
        public uint Driver { get => ReadHere<uint>(nameof(Driver)); set => WriteHere(nameof(Driver), value); }

        [Offset(0UL)]
        public uint Reserved2 { get => ReadHere<uint>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public WheaEventLogEntryFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaEventLogEntryFlags>();
        }
    }
}