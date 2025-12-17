using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_OBJECT_LIST")]
    public sealed class DeviceObjectList : DynamicStructure
    {
        [Offset(0UL)]
        public uint Count { get => ReadHere<uint>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(4UL)]
        public uint MaxCount { get => ReadHere<uint>(nameof(MaxCount)); set => WriteHere(nameof(MaxCount), value); }

        [Offset(8UL)]
        public uint TagCount { get => ReadHere<uint>(nameof(TagCount)); set => WriteHere(nameof(TagCount), value); }

        [Offset(12UL)]
        public uint OperationCode { get => ReadHere<uint>(nameof(OperationCode)); set => WriteHere(nameof(OperationCode), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray Devices { get => ReadStructure<DynamicArray>(nameof(Devices)); set => WriteStructure(nameof(Devices), value); }

        public DeviceObjectList(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceObjectList>();
        }
    }
}