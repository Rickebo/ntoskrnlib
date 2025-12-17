using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_OBP_SILODRIVERSTATE")]
    public sealed class ObpSilodriverstate : DynamicStructure
    {
        [Offset(0UL)]
        public ExFastRef SystemDeviceMap { get => ReadStructure<ExFastRef>(nameof(SystemDeviceMap)); set => WriteStructure(nameof(SystemDeviceMap), value); }

        [Offset(8UL)]
        public ObpSystemDosDeviceState SystemDosDeviceState { get => ReadStructure<ObpSystemDosDeviceState>(nameof(SystemDosDeviceState)); set => WriteStructure(nameof(SystemDosDeviceState), value); }

        [Offset(120UL)]
        public ExPushLock DeviceMapLock { get => ReadStructure<ExPushLock>(nameof(DeviceMapLock)); set => WriteStructure(nameof(DeviceMapLock), value); }

        [Offset(128UL)]
        public ObjectNamespaceLookuptable PrivateNamespaceLookupTable { get => ReadStructure<ObjectNamespaceLookuptable>(nameof(PrivateNamespaceLookupTable)); set => WriteStructure(nameof(PrivateNamespaceLookupTable), value); }

        public ObpSilodriverstate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObpSilodriverstate>();
        }
    }
}