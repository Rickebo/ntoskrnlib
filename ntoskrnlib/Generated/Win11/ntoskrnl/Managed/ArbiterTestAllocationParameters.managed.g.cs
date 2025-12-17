using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_TEST_ALLOCATION_PARAMETERS")]
    public sealed class ArbiterTestAllocationParameters : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ArbitrationList { get => ReadHere<IntPtr>(nameof(ArbitrationList)); set => WriteHere(nameof(ArbitrationList), value); }

        [Offset(8UL)]
        public uint AllocateFromCount { get => ReadHere<uint>(nameof(AllocateFromCount)); set => WriteHere(nameof(AllocateFromCount), value); }

        [Offset(16UL)]
        public IntPtr AllocateFrom { get => ReadHere<IntPtr>(nameof(AllocateFrom)); set => WriteHere(nameof(AllocateFrom), value); }

        public ArbiterTestAllocationParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterTestAllocationParameters>();
        }
    }
}