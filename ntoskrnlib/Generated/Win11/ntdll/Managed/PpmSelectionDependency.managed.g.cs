using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PPM_SELECTION_DEPENDENCY")]
    public sealed class PpmSelectionDependency : DynamicStructure
    {
        [Offset(0UL)]
        public uint Processor { get => ReadHere<uint>(nameof(Processor)); set => WriteHere(nameof(Processor), value); }

        [Offset(8UL)]
        public PpmSelectionMenu Menu { get => ReadStructure<PpmSelectionMenu>(nameof(Menu)); set => WriteStructure(nameof(Menu), value); }

        public PpmSelectionDependency(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmSelectionDependency>();
        }
    }
}