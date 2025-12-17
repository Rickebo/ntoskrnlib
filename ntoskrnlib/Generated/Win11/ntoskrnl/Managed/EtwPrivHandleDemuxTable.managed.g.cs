using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PRIV_HANDLE_DEMUX_TABLE")]
    public sealed class EtwPrivHandleDemuxTable : DynamicStructure
    {
        [Offset(0UL)]
        public RtlRbTree Tree { get => ReadStructure<RtlRbTree>(nameof(Tree)); set => WriteStructure(nameof(Tree), value); }

        [Offset(16UL)]
        public ExPushLock Lock { get => ReadStructure<ExPushLock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(24UL)]
        public ushort SequenceNumber { get => ReadHere<ushort>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        public EtwPrivHandleDemuxTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwPrivHandleDemuxTable>();
        }
    }
}