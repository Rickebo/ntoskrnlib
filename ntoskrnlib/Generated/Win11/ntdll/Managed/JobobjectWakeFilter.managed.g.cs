using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_JOBOBJECT_WAKE_FILTER")]
    public sealed class JobobjectWakeFilter : DynamicStructure
    {
        [Offset(0UL)]
        public uint HighEdgeFilter { get => ReadHere<uint>(nameof(HighEdgeFilter)); set => WriteHere(nameof(HighEdgeFilter), value); }

        [Offset(4UL)]
        public uint LowEdgeFilter { get => ReadHere<uint>(nameof(LowEdgeFilter)); set => WriteHere(nameof(LowEdgeFilter), value); }

        public JobobjectWakeFilter(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<JobobjectWakeFilter>();
        }
    }
}