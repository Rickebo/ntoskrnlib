using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCESS_ENERGY_VALUES")]
    public sealed class ProcessEnergyValues : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray Cycles { get => ReadStructure<DynamicArray>(nameof(Cycles)); set => WriteStructure(nameof(Cycles), value); }

        [Offset(64UL)]
        public ulong DiskEnergy { get => ReadHere<ulong>(nameof(DiskEnergy)); set => WriteHere(nameof(DiskEnergy), value); }

        [Offset(72UL)]
        public ulong NetworkTailEnergy { get => ReadHere<ulong>(nameof(NetworkTailEnergy)); set => WriteHere(nameof(NetworkTailEnergy), value); }

        [Offset(80UL)]
        public ulong MBBTailEnergy { get => ReadHere<ulong>(nameof(MBBTailEnergy)); set => WriteHere(nameof(MBBTailEnergy), value); }

        [Offset(88UL)]
        public ulong NetworkTxRxBytes { get => ReadHere<ulong>(nameof(NetworkTxRxBytes)); set => WriteHere(nameof(NetworkTxRxBytes), value); }

        [Offset(96UL)]
        public ulong MBBTxRxBytes { get => ReadHere<ulong>(nameof(MBBTxRxBytes)); set => WriteHere(nameof(MBBTxRxBytes), value); }

        [Offset(104UL)]
        [Length(3)]
        public DynamicArray Durations { get => ReadStructure<DynamicArray>(nameof(Durations)); set => WriteStructure(nameof(Durations), value); }

        [Offset(104UL)]
        public EnergyStateDuration ForegroundDuration { get => ReadStructure<EnergyStateDuration>(nameof(ForegroundDuration)); set => WriteStructure(nameof(ForegroundDuration), value); }

        [Offset(112UL)]
        public EnergyStateDuration DesktopVisibleDuration { get => ReadStructure<EnergyStateDuration>(nameof(DesktopVisibleDuration)); set => WriteStructure(nameof(DesktopVisibleDuration), value); }

        [Offset(120UL)]
        public EnergyStateDuration PSMForegroundDuration { get => ReadStructure<EnergyStateDuration>(nameof(PSMForegroundDuration)); set => WriteStructure(nameof(PSMForegroundDuration), value); }

        [Offset(128UL)]
        public uint CompositionRendered { get => ReadHere<uint>(nameof(CompositionRendered)); set => WriteHere(nameof(CompositionRendered), value); }

        [Offset(132UL)]
        public uint CompositionDirtyGenerated { get => ReadHere<uint>(nameof(CompositionDirtyGenerated)); set => WriteHere(nameof(CompositionDirtyGenerated), value); }

        [Offset(136UL)]
        public uint CompositionDirtyPropagated { get => ReadHere<uint>(nameof(CompositionDirtyPropagated)); set => WriteHere(nameof(CompositionDirtyPropagated), value); }

        [Offset(140UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(144UL)]
        [Length(4)]
        public DynamicArray AttributedCycles { get => ReadStructure<DynamicArray>(nameof(AttributedCycles)); set => WriteStructure(nameof(AttributedCycles), value); }

        [Offset(208UL)]
        [Length(4)]
        public DynamicArray WorkOnBehalfCycles { get => ReadStructure<DynamicArray>(nameof(WorkOnBehalfCycles)); set => WriteStructure(nameof(WorkOnBehalfCycles), value); }

        public ProcessEnergyValues(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessEnergyValues>();
        }
    }
}