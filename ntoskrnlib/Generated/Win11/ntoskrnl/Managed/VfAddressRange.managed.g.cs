using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VF_ADDRESS_RANGE")]
    public sealed class VfAddressRange : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Start { get => ReadHere<IntPtr>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(8UL)]
        public IntPtr End { get => ReadHere<IntPtr>(nameof(End)); set => WriteHere(nameof(End), value); }

        public VfAddressRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<VfAddressRange>();
        }
    }
}