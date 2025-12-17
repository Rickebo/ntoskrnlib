using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_WRITE_CALIBRATION")]
    public sealed class MiWriteCalibration : DynamicStructure
    {
        [Offset(0UL)]
        public uint MaximumNumberProcessors { get => ReadHere<uint>(nameof(MaximumNumberProcessors)); set => WriteHere(nameof(MaximumNumberProcessors), value); }

        [Offset(4UL)]
        public byte OptimalWriteType { get => ReadHere<byte>(nameof(OptimalWriteType)); set => WriteHere(nameof(OptimalWriteType), value); }

        [Offset(5UL)]
        public byte CalibrationCompleted { get => ReadHere<byte>(nameof(CalibrationCompleted)); set => WriteHere(nameof(CalibrationCompleted), value); }

        [Offset(6UL)]
        [Length(2)]
        public DynamicArray CalibrationFinal { get => ReadStructure<DynamicArray>(nameof(CalibrationFinal)); set => WriteStructure(nameof(CalibrationFinal), value); }

        [Offset(8UL)]
        public ulong PerProcessorNumberOfBytes { get => ReadHere<ulong>(nameof(PerProcessorNumberOfBytes)); set => WriteHere(nameof(PerProcessorNumberOfBytes), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray PerProcessorBandwidth { get => ReadStructure<DynamicArray>(nameof(PerProcessorBandwidth)); set => WriteStructure(nameof(PerProcessorBandwidth), value); }

        [Offset(32UL)]
        [Length(2)]
        public DynamicArray OptimalWriteProcessors { get => ReadStructure<DynamicArray>(nameof(OptimalWriteProcessors)); set => WriteStructure(nameof(OptimalWriteProcessors), value); }

        [Offset(48UL)]
        public IntPtr PureZeroing { get => ReadHere<IntPtr>(nameof(PureZeroing)); set => WriteHere(nameof(PureZeroing), value); }

        public MiWriteCalibration(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiWriteCalibration>();
        }
    }
}