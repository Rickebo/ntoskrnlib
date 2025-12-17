using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PPM_SELECTION_MENU")]
    public sealed class PpmSelectionMenu : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(8UL)]
        public IntPtr Entries { get => ReadHere<IntPtr>(nameof(Entries)); set => WriteHere(nameof(Entries), value); }

        public PpmSelectionMenu(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmSelectionMenu>();
        }
    }
}