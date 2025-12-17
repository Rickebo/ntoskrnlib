using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_POWER_STATE")]
    public sealed class PowerState : DynamicStructure
    {
        [Offset(0UL)]
        public uint SystemState { get => ReadHere<uint>(nameof(SystemState)); set => WriteHere(nameof(SystemState), value); }

        [Offset(0UL)]
        public uint DeviceState { get => ReadHere<uint>(nameof(DeviceState)); set => WriteHere(nameof(DeviceState), value); }

        public PowerState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PowerState>();
        }
    }
}