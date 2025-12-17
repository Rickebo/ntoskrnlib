using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_LBR_ENTRY")]
    public sealed class HalLbrEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr FromAddress { get => ReadHere<IntPtr>(nameof(FromAddress)); set => WriteHere(nameof(FromAddress), value); }

        [Offset(8UL)]
        public IntPtr ToAddress { get => ReadHere<IntPtr>(nameof(ToAddress)); set => WriteHere(nameof(ToAddress), value); }

        [Offset(16UL)]
        public IntPtr Information { get => ReadHere<IntPtr>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        public HalLbrEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalLbrEntry>();
        }
    }
}