using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KTRANSACTION_HISTORY")]
    public sealed class KtransactionHistory : DynamicStructure
    {
        [Offset(0UL)]
        public uint RecordType { get => ReadHere<uint>(nameof(RecordType)); set => WriteHere(nameof(RecordType), value); }

        [Offset(4UL)]
        public uint Payload { get => ReadHere<uint>(nameof(Payload)); set => WriteHere(nameof(Payload), value); }

        public KtransactionHistory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KtransactionHistory>();
        }
    }
}