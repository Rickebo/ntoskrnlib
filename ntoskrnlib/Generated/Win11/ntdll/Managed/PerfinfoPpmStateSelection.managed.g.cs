using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PERFINFO_PPM_STATE_SELECTION")]
    public sealed class PerfinfoPpmStateSelection : DynamicStructure
    {
        [Offset(0UL)]
        public uint SelectedState { get => ReadHere<uint>(nameof(SelectedState)); set => WriteHere(nameof(SelectedState), value); }

        [Offset(4UL)]
        public uint VetoedStates { get => ReadHere<uint>(nameof(VetoedStates)); set => WriteHere(nameof(VetoedStates), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray VetoReason { get => ReadStructure<DynamicArray>(nameof(VetoReason)); set => WriteStructure(nameof(VetoReason), value); }

        public PerfinfoPpmStateSelection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PerfinfoPpmStateSelection>();
        }
    }
}