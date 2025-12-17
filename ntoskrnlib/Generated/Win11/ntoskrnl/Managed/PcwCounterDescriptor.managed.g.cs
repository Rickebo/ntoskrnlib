using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PCW_COUNTER_DESCRIPTOR")]
    public sealed class PcwCounterDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Id { get => ReadHere<ushort>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(2UL)]
        public ushort StructIndex { get => ReadHere<ushort>(nameof(StructIndex)); set => WriteHere(nameof(StructIndex), value); }

        [Offset(4UL)]
        public ushort Offset { get => ReadHere<ushort>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        [Offset(6UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        public PcwCounterDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PcwCounterDescriptor>();
        }
    }
}