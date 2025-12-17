using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PHYSICAL_MEMORY_DESCRIPTOR")]
    public sealed class PhysicalMemoryDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint NumberOfRuns { get => ReadHere<uint>(nameof(NumberOfRuns)); set => WriteHere(nameof(NumberOfRuns), value); }

        [Offset(8UL)]
        public ulong NumberOfPages { get => ReadHere<ulong>(nameof(NumberOfPages)); set => WriteHere(nameof(NumberOfPages), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray Run { get => ReadStructure<DynamicArray>(nameof(Run)); set => WriteStructure(nameof(Run), value); }

        public PhysicalMemoryDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PhysicalMemoryDescriptor>();
        }
    }
}