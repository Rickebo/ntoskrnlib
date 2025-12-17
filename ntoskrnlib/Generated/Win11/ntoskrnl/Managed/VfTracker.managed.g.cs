using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_TRACKER")]
    public sealed class VfTracker : DynamicStructure
    {
        [Offset(0UL)]
        public uint TrackerFlags { get => ReadHere<uint>(nameof(TrackerFlags)); set => WriteHere(nameof(TrackerFlags), value); }

        [Offset(4UL)]
        public uint TrackerSize { get => ReadHere<uint>(nameof(TrackerSize)); set => WriteHere(nameof(TrackerSize), value); }

        [Offset(8UL)]
        public uint TrackerIndex { get => ReadHere<uint>(nameof(TrackerIndex)); set => WriteHere(nameof(TrackerIndex), value); }

        [Offset(12UL)]
        public uint TraceDepth { get => ReadHere<uint>(nameof(TraceDepth)); set => WriteHere(nameof(TraceDepth), value); }

        public VfTracker(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfTracker>();
        }
    }
}