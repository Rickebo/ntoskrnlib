using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBP_SYSTEM_DOS_DEVICE_STATE")]
    public sealed class ObpSystemDosDeviceState : DynamicStructure
    {
        [Offset(0UL)]
        public uint GlobalDeviceMap { get => ReadHere<uint>(nameof(GlobalDeviceMap)); set => WriteHere(nameof(GlobalDeviceMap), value); }

        [Offset(4UL)]
        [Length(26)]
        public DynamicArray LocalDeviceCount { get => ReadStructure<DynamicArray>(nameof(LocalDeviceCount)); set => WriteStructure(nameof(LocalDeviceCount), value); }

        public ObpSystemDosDeviceState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObpSystemDosDeviceState>();
        }
    }
}