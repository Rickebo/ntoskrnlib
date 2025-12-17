using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_DEVICE_OBJECT_POWER_EXTENSION")]
    public sealed class DeviceObjectPowerExtension : DynamicStructure
    {
        public DeviceObjectPowerExtension(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceObjectPowerExtension>();
        }
    }
}