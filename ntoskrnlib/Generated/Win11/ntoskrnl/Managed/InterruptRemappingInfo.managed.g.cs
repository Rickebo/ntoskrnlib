using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_REMAPPING_INFO")]
    public sealed class InterruptRemappingInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint IrtIndex { get => ReadHere<uint>(nameof(IrtIndex)); set => WriteHere(nameof(IrtIndex), value); }

        [Offset(0UL)]
        public uint FlagHalInternal { get => ReadHere<uint>(nameof(FlagHalInternal)); set => WriteHere(nameof(FlagHalInternal), value); }

        [Offset(0UL)]
        public uint FlagTranslated { get => ReadHere<uint>(nameof(FlagTranslated)); set => WriteHere(nameof(FlagTranslated), value); }

        [Offset(4UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        public InterruptRemappingInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterruptRemappingInfo>();
        }
    }
}