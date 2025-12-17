using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PNP_ASSIGN_RESOURCES_CONTEXT")]
    public sealed class PnpAssignResourcesContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint IncludeFailedDevices { get => ReadHere<uint>(nameof(IncludeFailedDevices)); set => WriteHere(nameof(IncludeFailedDevices), value); }

        [Offset(4UL)]
        public uint DeviceCount { get => ReadHere<uint>(nameof(DeviceCount)); set => WriteHere(nameof(DeviceCount), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray DeviceList { get => ReadStructure<DynamicArray>(nameof(DeviceList)); set => WriteStructure(nameof(DeviceList), value); }

        public PnpAssignResourcesContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PnpAssignResourcesContext>();
        }
    }
}