using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EXP_POOL_CONTEXT")]
    public sealed class ExpPoolContext : DynamicStructure
    {
        [Offset(0UL)]
        public ExpPoolContextHeader Header { get => ReadStructure<ExpPoolContextHeader>(nameof(Header)); set => WriteStructure(nameof(Header), value); }

        [Offset(8UL)]
        public RtlHpEnvHandle EnvHandle { get => ReadStructure<RtlHpEnvHandle>(nameof(EnvHandle)); set => WriteStructure(nameof(EnvHandle), value); }

        [Offset(24UL)]
        public ExRundownRef Rundown { get => ReadStructure<ExRundownRef>(nameof(Rundown)); set => WriteStructure(nameof(Rundown), value); }

        [Offset(32UL)]
        public ListEntry PoolLink { get => ReadStructure<ListEntry>(nameof(PoolLink)); set => WriteStructure(nameof(PoolLink), value); }

        [Offset(48UL)]
        public ulong Tag { get => ReadHere<ulong>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        [Offset(56UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(72UL)]
        public uint NodeCount { get => ReadHere<uint>(nameof(NodeCount)); set => WriteHere(nameof(NodeCount), value); }

        [Offset(80UL)]
        [Length(1)]
        public DynamicArray Node { get => ReadStructure<DynamicArray>(nameof(Node)); set => WriteStructure(nameof(Node), value); }

        public ExpPoolContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExpPoolContext>();
        }
    }
}