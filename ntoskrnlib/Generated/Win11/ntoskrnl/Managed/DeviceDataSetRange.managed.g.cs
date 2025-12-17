using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_DATA_SET_RANGE")]
    public sealed class DeviceDataSetRange : DynamicStructure
    {
        [Offset(0UL)]
        public long StartingOffset { get => ReadHere<long>(nameof(StartingOffset)); set => WriteHere(nameof(StartingOffset), value); }

        [Offset(8UL)]
        public ulong LengthInBytes { get => ReadHere<ulong>(nameof(LengthInBytes)); set => WriteHere(nameof(LengthInBytes), value); }

        public DeviceDataSetRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceDataSetRange>();
        }
    }
}