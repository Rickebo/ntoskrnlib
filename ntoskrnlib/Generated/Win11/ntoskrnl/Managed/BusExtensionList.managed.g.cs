using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_BUS_EXTENSION_LIST")]
    public sealed class BusExtensionList : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public IntPtr BusExtension { get => ReadHere<IntPtr>(nameof(BusExtension)); set => WriteHere(nameof(BusExtension), value); }

        public BusExtensionList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<BusExtensionList>();
        }
    }
}