using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_PERF_FLAGS")]
    public sealed class PopFxPerfFlags : DynamicStructure
    {
        [Offset(0UL)]
        public int Value { get => ReadHere<int>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint Progress { get => ReadHere<uint>(nameof(Progress)); set => WriteHere(nameof(Progress), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint Synchronicity { get => ReadHere<uint>(nameof(Synchronicity)); set => WriteHere(nameof(Synchronicity), value); }

        [Offset(0UL)]
        public uint RequestPepCompleted { get => ReadHere<uint>(nameof(RequestPepCompleted)); set => WriteHere(nameof(RequestPepCompleted), value); }

        [Offset(0UL)]
        public uint RequestSucceeded { get => ReadHere<uint>(nameof(RequestSucceeded)); set => WriteHere(nameof(RequestSucceeded), value); }

        [Offset(0UL)]
        public uint NestedCallback { get => ReadHere<uint>(nameof(NestedCallback)); set => WriteHere(nameof(NestedCallback), value); }

        public PopFxPerfFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxPerfFlags>();
        }
    }
}