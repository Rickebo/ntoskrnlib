using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_REF_STACK_INFO")]
    public sealed class ObjectRefStackInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Sequence { get => ReadHere<uint>(nameof(Sequence)); set => WriteHere(nameof(Sequence), value); }

        [Offset(4UL)]
        public ushort Index { get => ReadHere<ushort>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(6UL)]
        public ushort NumTraces { get => ReadHere<ushort>(nameof(NumTraces)); set => WriteHere(nameof(NumTraces), value); }

        [Offset(8UL)]
        public uint Tag { get => ReadHere<uint>(nameof(Tag)); set => WriteHere(nameof(Tag), value); }

        public ObjectRefStackInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectRefStackInfo>();
        }
    }
}