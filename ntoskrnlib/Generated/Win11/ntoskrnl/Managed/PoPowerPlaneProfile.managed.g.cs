using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PO_POWER_PLANE_PROFILE")]
    public sealed class PoPowerPlaneProfile : DynamicStructure
    {
        [Offset(0UL)]
        public uint ExclusivePowerMw { get => ReadHere<uint>(nameof(ExclusivePowerMw)); set => WriteHere(nameof(ExclusivePowerMw), value); }

        [Offset(4UL)]
        public uint PeakPowerMw { get => ReadHere<uint>(nameof(PeakPowerMw)); set => WriteHere(nameof(PeakPowerMw), value); }

        public PoPowerPlaneProfile(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PoPowerPlaneProfile>();
        }
    }
}