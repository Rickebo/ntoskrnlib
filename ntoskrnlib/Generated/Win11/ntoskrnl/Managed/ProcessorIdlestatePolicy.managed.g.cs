using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!PROCESSOR_IDLESTATE_POLICY")]
    public sealed class ProcessorIdlestatePolicy : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Revision { get => ReadHere<ushort>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(2UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(4UL)]
        public uint PolicyCount { get => ReadHere<uint>(nameof(PolicyCount)); set => WriteHere(nameof(PolicyCount), value); }

        [Offset(8UL)]
        [Length(3)]
        public DynamicArray Policy { get => ReadStructure<DynamicArray>(nameof(Policy)); set => WriteStructure(nameof(Policy), value); }

        public ProcessorIdlestatePolicy(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessorIdlestatePolicy>();
        }
    }
}