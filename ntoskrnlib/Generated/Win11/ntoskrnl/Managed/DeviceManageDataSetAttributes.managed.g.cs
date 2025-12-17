using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_MANAGE_DATA_SET_ATTRIBUTES")]
    public sealed class DeviceManageDataSetAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public uint Action { get => ReadHere<uint>(nameof(Action)); set => WriteHere(nameof(Action), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint ParameterBlockOffset { get => ReadHere<uint>(nameof(ParameterBlockOffset)); set => WriteHere(nameof(ParameterBlockOffset), value); }

        [Offset(16UL)]
        public uint ParameterBlockLength { get => ReadHere<uint>(nameof(ParameterBlockLength)); set => WriteHere(nameof(ParameterBlockLength), value); }

        [Offset(20UL)]
        public uint DataSetRangesOffset { get => ReadHere<uint>(nameof(DataSetRangesOffset)); set => WriteHere(nameof(DataSetRangesOffset), value); }

        [Offset(24UL)]
        public uint DataSetRangesLength { get => ReadHere<uint>(nameof(DataSetRangesLength)); set => WriteHere(nameof(DataSetRangesLength), value); }

        public DeviceManageDataSetAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceManageDataSetAttributes>();
        }
    }
}