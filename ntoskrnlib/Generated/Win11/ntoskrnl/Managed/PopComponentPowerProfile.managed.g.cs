using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_COMPONENT_POWER_PROFILE")]
    public sealed class PopComponentPowerProfile : DynamicStructure
    {
        [Offset(0UL)]
        public Guid ComponentGuid { get => ReadStructure<Guid>(nameof(ComponentGuid)); set => WriteStructure(nameof(ComponentGuid), value); }

        [Offset(16UL)]
        public IntPtr Device { get => ReadHere<IntPtr>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(24UL)]
        public ulong FxCount { get => ReadHere<ulong>(nameof(FxCount)); set => WriteHere(nameof(FxCount), value); }

        [Offset(32UL)]
        [Length(1)]
        public DynamicArray FxPower { get => ReadStructure<DynamicArray>(nameof(FxPower)); set => WriteStructure(nameof(FxPower), value); }

        public PopComponentPowerProfile(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopComponentPowerProfile>();
        }
    }
}