using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HAL_UNMASKED_INTERRUPT_FLAGS")]
    public sealed class HalUnmaskedInterruptFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ushort SecondaryInterrupt { get => ReadHere<ushort>(nameof(SecondaryInterrupt)); set => WriteHere(nameof(SecondaryInterrupt), value); }

        [Offset(0UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ushort AsUSHORT { get => ReadHere<ushort>(nameof(AsUSHORT)); set => WriteHere(nameof(AsUSHORT), value); }

        public HalUnmaskedInterruptFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HalUnmaskedInterruptFlags>();
        }
    }
}