using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PPM_COORDINATED_SELECTION")]
    public sealed class PpmCoordinatedSelection : DynamicStructure
    {
        [Offset(0UL)]
        public uint MaximumStates { get => ReadHere<uint>(nameof(MaximumStates)); set => WriteHere(nameof(MaximumStates), value); }

        [Offset(4UL)]
        public uint SelectedStates { get => ReadHere<uint>(nameof(SelectedStates)); set => WriteHere(nameof(SelectedStates), value); }

        [Offset(8UL)]
        public uint DefaultSelection { get => ReadHere<uint>(nameof(DefaultSelection)); set => WriteHere(nameof(DefaultSelection), value); }

        [Offset(16UL)]
        public IntPtr Selection { get => ReadHere<IntPtr>(nameof(Selection)); set => WriteHere(nameof(Selection), value); }

        public PpmCoordinatedSelection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmCoordinatedSelection>();
        }
    }
}