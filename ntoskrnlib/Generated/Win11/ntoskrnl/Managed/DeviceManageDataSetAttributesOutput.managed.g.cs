using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT")]
    public sealed class DeviceManageDataSetAttributesOutput : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public uint Action { get => ReadHere<uint>(nameof(Action)); set => WriteHere(nameof(Action), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint OperationStatus { get => ReadHere<uint>(nameof(OperationStatus)); set => WriteHere(nameof(OperationStatus), value); }

        [Offset(16UL)]
        public uint ExtendedError { get => ReadHere<uint>(nameof(ExtendedError)); set => WriteHere(nameof(ExtendedError), value); }

        [Offset(20UL)]
        public uint TargetDetailedError { get => ReadHere<uint>(nameof(TargetDetailedError)); set => WriteHere(nameof(TargetDetailedError), value); }

        [Offset(24UL)]
        public uint ReservedStatus { get => ReadHere<uint>(nameof(ReservedStatus)); set => WriteHere(nameof(ReservedStatus), value); }

        [Offset(28UL)]
        public uint OutputBlockOffset { get => ReadHere<uint>(nameof(OutputBlockOffset)); set => WriteHere(nameof(OutputBlockOffset), value); }

        [Offset(32UL)]
        public uint OutputBlockLength { get => ReadHere<uint>(nameof(OutputBlockLength)); set => WriteHere(nameof(OutputBlockLength), value); }

        public DeviceManageDataSetAttributesOutput(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DeviceManageDataSetAttributesOutput>();
        }
    }
}