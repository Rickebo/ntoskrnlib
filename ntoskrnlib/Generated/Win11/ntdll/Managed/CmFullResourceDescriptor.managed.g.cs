using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_CM_FULL_RESOURCE_DESCRIPTOR")]
    public sealed class CmFullResourceDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public uint InterfaceType { get => ReadHere<uint>(nameof(InterfaceType)); set => WriteHere(nameof(InterfaceType), value); }

        [Offset(4UL)]
        public uint BusNumber { get => ReadHere<uint>(nameof(BusNumber)); set => WriteHere(nameof(BusNumber), value); }

        [Offset(8UL)]
        public CmPartialResourceList PartialResourceList { get => ReadStructure<CmPartialResourceList>(nameof(PartialResourceList)); set => WriteStructure(nameof(PartialResourceList), value); }

        public CmFullResourceDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CmFullResourceDescriptor>();
        }
    }
}