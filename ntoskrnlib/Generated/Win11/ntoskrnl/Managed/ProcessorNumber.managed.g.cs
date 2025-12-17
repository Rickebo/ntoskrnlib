using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESSOR_NUMBER")]
    public sealed class ProcessorNumber : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Group { get => ReadHere<ushort>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(2UL)]
        public byte Number { get => ReadHere<byte>(nameof(Number)); set => WriteHere(nameof(Number), value); }

        [Offset(3UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public ProcessorNumber(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorNumber>();
        }
    }
}