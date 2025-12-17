using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_FX_COMPONENT_PERF_SET")]
    public sealed class PoFxComponentPerfSet : DynamicStructure
    {
        [Offset(0UL)]
        public UnicodeString Name { get => ReadStructure<UnicodeString>(nameof(Name)); set => WriteStructure(nameof(Name), value); }

        [Offset(16UL)]
        public ulong Flags { get => ReadHere<ulong>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(24UL)]
        public uint Unit { get => ReadHere<uint>(nameof(Unit)); set => WriteHere(nameof(Unit), value); }

        [Offset(28UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(32UL)]
        public UnnamedTag Discrete { get => ReadStructure<UnnamedTag>(nameof(Discrete)); set => WriteStructure(nameof(Discrete), value); }

        [Offset(32UL)]
        public UnnamedTag Range { get => ReadStructure<UnnamedTag>(nameof(Range)); set => WriteStructure(nameof(Range), value); }

        public PoFxComponentPerfSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoFxComponentPerfSet>();
        }
    }
}