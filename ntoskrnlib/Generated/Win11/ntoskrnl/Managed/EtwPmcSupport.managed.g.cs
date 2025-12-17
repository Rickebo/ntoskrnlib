using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_PMC_SUPPORT")]
    public sealed class EtwPmcSupport : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Source { get => ReadHere<IntPtr>(nameof(Source)); set => WriteHere(nameof(Source), value); }

        [Offset(8UL)]
        public uint HookIdCount { get => ReadHere<uint>(nameof(HookIdCount)); set => WriteHere(nameof(HookIdCount), value); }

        [Offset(12UL)]
        [Length(4)]
        public DynamicArray HookId { get => ReadStructure<DynamicArray>(nameof(HookId)); set => WriteStructure(nameof(HookId), value); }

        [Offset(20UL)]
        public uint CountersCount { get => ReadHere<uint>(nameof(CountersCount)); set => WriteHere(nameof(CountersCount), value); }

        [Offset(24UL)]
        [Length(1)]
        public DynamicArray ProcessorCtrs { get => ReadStructure<DynamicArray>(nameof(ProcessorCtrs)); set => WriteStructure(nameof(ProcessorCtrs), value); }

        public EtwPmcSupport(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwPmcSupport>();
        }
    }
}