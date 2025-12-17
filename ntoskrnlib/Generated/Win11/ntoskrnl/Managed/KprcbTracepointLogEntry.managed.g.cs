using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRCB_TRACEPOINT_LOG_ENTRY")]
    public sealed class KprcbTracepointLogEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong OldPc { get => ReadHere<ulong>(nameof(OldPc)); set => WriteHere(nameof(OldPc), value); }

        [Offset(8UL)]
        public ulong OldSp { get => ReadHere<ulong>(nameof(OldSp)); set => WriteHere(nameof(OldSp), value); }

        [Offset(16UL)]
        public ulong NewPc { get => ReadHere<ulong>(nameof(NewPc)); set => WriteHere(nameof(NewPc), value); }

        [Offset(24UL)]
        public ulong NewSp { get => ReadHere<ulong>(nameof(NewSp)); set => WriteHere(nameof(NewSp), value); }

        public KprcbTracepointLogEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KprcbTracepointLogEntry>();
        }
    }
}