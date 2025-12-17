using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_INFORMATION")]
    public sealed class PepWorkInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint WorkType { get => ReadHere<uint>(nameof(WorkType)); set => WriteHere(nameof(WorkType), value); }

        [Offset(8UL)]
        public PepWorkActiveComplete ActiveComplete { get => ReadStructure<PepWorkActiveComplete>(nameof(ActiveComplete)); set => WriteStructure(nameof(ActiveComplete), value); }

        [Offset(8UL)]
        public PepWorkIdleState IdleState { get => ReadStructure<PepWorkIdleState>(nameof(IdleState)); set => WriteStructure(nameof(IdleState), value); }

        [Offset(8UL)]
        public PepWorkDevicePower DevicePower { get => ReadStructure<PepWorkDevicePower>(nameof(DevicePower)); set => WriteStructure(nameof(DevicePower), value); }

        [Offset(8UL)]
        public PepWorkPowerControl PowerControl { get => ReadStructure<PepWorkPowerControl>(nameof(PowerControl)); set => WriteStructure(nameof(PowerControl), value); }

        [Offset(8UL)]
        public PepWorkDeviceIdle DeviceIdle { get => ReadStructure<PepWorkDeviceIdle>(nameof(DeviceIdle)); set => WriteStructure(nameof(DeviceIdle), value); }

        [Offset(8UL)]
        public PepWorkCompleteIdleState CompleteIdleState { get => ReadStructure<PepWorkCompleteIdleState>(nameof(CompleteIdleState)); set => WriteStructure(nameof(CompleteIdleState), value); }

        [Offset(8UL)]
        public PepWorkCompletePerfState CompletePerfState { get => ReadStructure<PepWorkCompletePerfState>(nameof(CompletePerfState)); set => WriteStructure(nameof(CompletePerfState), value); }

        [Offset(8UL)]
        public PepWorkAcpiNotify AcpiNotify { get => ReadStructure<PepWorkAcpiNotify>(nameof(AcpiNotify)); set => WriteStructure(nameof(AcpiNotify), value); }

        [Offset(8UL)]
        public PepWorkAcpiEvaluateControlMethodComplete ControlMethodComplete { get => ReadStructure<PepWorkAcpiEvaluateControlMethodComplete>(nameof(ControlMethodComplete)); set => WriteStructure(nameof(ControlMethodComplete), value); }

        public PepWorkInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PepWorkInformation>();
        }
    }
}