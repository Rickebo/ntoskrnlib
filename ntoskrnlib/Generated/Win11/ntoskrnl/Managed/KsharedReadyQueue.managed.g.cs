using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KSHARED_READY_QUEUE")]
    public sealed class KsharedReadyQueue : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public uint ReadySummary { get => ReadHere<uint>(nameof(ReadySummary)); set => WriteHere(nameof(ReadySummary), value); }

        [Offset(12UL)]
        public uint ReadyThreadCount { get => ReadHere<uint>(nameof(ReadyThreadCount)); set => WriteHere(nameof(ReadyThreadCount), value); }

        [Offset(16UL)]
        public ulong ReadyQueueExpectedRunTime { get => ReadHere<ulong>(nameof(ReadyQueueExpectedRunTime)); set => WriteHere(nameof(ReadyQueueExpectedRunTime), value); }

        [Offset(24UL)]
        [Length(5)]
        public DynamicArray Spare1 { get => ReadStructure<DynamicArray>(nameof(Spare1)); set => WriteStructure(nameof(Spare1), value); }

        [Offset(64UL)]
        [Length(32)]
        public DynamicArray ReadyListHead { get => ReadStructure<DynamicArray>(nameof(ReadyListHead)); set => WriteStructure(nameof(ReadyListHead), value); }

        [Offset(576UL)]
        [Length(64)]
        public DynamicArray RunningSummary { get => ReadStructure<DynamicArray>(nameof(RunningSummary)); set => WriteStructure(nameof(RunningSummary), value); }

        [Offset(640UL)]
        [Length(64)]
        public DynamicArray HeteroRunningSummary { get => ReadStructure<DynamicArray>(nameof(HeteroRunningSummary)); set => WriteStructure(nameof(HeteroRunningSummary), value); }

        [Offset(704UL)]
        public byte Span { get => ReadHere<byte>(nameof(Span)); set => WriteHere(nameof(Span), value); }

        [Offset(705UL)]
        public byte LowProcIndex { get => ReadHere<byte>(nameof(LowProcIndex)); set => WriteHere(nameof(LowProcIndex), value); }

        [Offset(706UL)]
        public byte QueueIndex { get => ReadHere<byte>(nameof(QueueIndex)); set => WriteHere(nameof(QueueIndex), value); }

        [Offset(707UL)]
        public byte NormalPriorityQueueIndex { get => ReadHere<byte>(nameof(NormalPriorityQueueIndex)); set => WriteHere(nameof(NormalPriorityQueueIndex), value); }

        [Offset(708UL)]
        public byte ProcCount { get => ReadHere<byte>(nameof(ProcCount)); set => WriteHere(nameof(ProcCount), value); }

        [Offset(709UL)]
        public byte ScanOwner { get => ReadHere<byte>(nameof(ScanOwner)); set => WriteHere(nameof(ScanOwner), value); }

        [Offset(710UL)]
        public ushort Group { get => ReadHere<ushort>(nameof(Group)); set => WriteHere(nameof(Group), value); }

        [Offset(712UL)]
        public ulong Affinity { get => ReadHere<ulong>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(720UL)]
        public IntPtr SubNode { get => ReadHere<IntPtr>(nameof(SubNode)); set => WriteHere(nameof(SubNode), value); }

        [Offset(728UL)]
        [Length(3)]
        public DynamicArray Spare2 { get => ReadStructure<DynamicArray>(nameof(Spare2)); set => WriteStructure(nameof(Spare2), value); }

        [Offset(768UL)]
        public ulong SoftParkElectionLock { get => ReadHere<ulong>(nameof(SoftParkElectionLock)); set => WriteHere(nameof(SoftParkElectionLock), value); }

        [Offset(776UL)]
        public ulong SoftParkElectionGeneration { get => ReadHere<ulong>(nameof(SoftParkElectionGeneration)); set => WriteHere(nameof(SoftParkElectionGeneration), value); }

        [Offset(784UL)]
        public uint SoftParkElectionThreadCount { get => ReadHere<uint>(nameof(SoftParkElectionThreadCount)); set => WriteHere(nameof(SoftParkElectionThreadCount), value); }

        [Offset(788UL)]
        public byte SoftParkElectionScheduled { get => ReadHere<byte>(nameof(SoftParkElectionScheduled)); set => WriteHere(nameof(SoftParkElectionScheduled), value); }

        [Offset(789UL)]
        [Length(3)]
        public DynamicArray Spare4 { get => ReadStructure<DynamicArray>(nameof(Spare4)); set => WriteStructure(nameof(Spare4), value); }

        [Offset(792UL)]
        public ulong SoftParkElectionRunTime { get => ReadHere<ulong>(nameof(SoftParkElectionRunTime)); set => WriteHere(nameof(SoftParkElectionRunTime), value); }

        [Offset(800UL)]
        public Kdpc SoftParkElectionDpc { get => ReadStructure<Kdpc>(nameof(SoftParkElectionDpc)); set => WriteStructure(nameof(SoftParkElectionDpc), value); }

        [Offset(864UL)]
        public KsharedReadyQueueHeteroStatistics SoftParkElectionHeteroStats { get => ReadStructure<KsharedReadyQueueHeteroStatistics>(nameof(SoftParkElectionHeteroStats)); set => WriteStructure(nameof(SoftParkElectionHeteroStats), value); }

        [Offset(1760UL)]
        public KsharedReadyQueueAffinityStatistics SoftParkElectionAffinityStats { get => ReadStructure<KsharedReadyQueueAffinityStatistics>(nameof(SoftParkElectionAffinityStats)); set => WriteStructure(nameof(SoftParkElectionAffinityStats), value); }

        [Offset(1768UL)]
        public ulong ForceParkDutyCyclingArmedMask { get => ReadHere<ulong>(nameof(ForceParkDutyCyclingArmedMask)); set => WriteHere(nameof(ForceParkDutyCyclingArmedMask), value); }

        public KsharedReadyQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KsharedReadyQueue>();
        }
    }
}