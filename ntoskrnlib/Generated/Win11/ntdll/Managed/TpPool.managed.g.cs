using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_POOL")]
    public sealed class TpPool : DynamicStructure
    {
        [Offset(0UL)]
        public TppRefcount Refcount { get => ReadStructure<TppRefcount>(nameof(Refcount)); set => WriteStructure(nameof(Refcount), value); }

        [Offset(8UL)]
        public TppPoolQueueState QueueState { get => ReadStructure<TppPoolQueueState>(nameof(QueueState)); set => WriteStructure(nameof(QueueState), value); }

        [Offset(16UL)]
        [Length(3)]
        public DynamicArray TaskQueue { get => ReadStructure<DynamicArray>(nameof(TaskQueue)); set => WriteStructure(nameof(TaskQueue), value); }

        [Offset(40UL)]
        public IntPtr NumaNode { get => ReadHere<IntPtr>(nameof(NumaNode)); set => WriteHere(nameof(NumaNode), value); }

        [Offset(48UL)]
        public IntPtr ProximityInfo { get => ReadHere<IntPtr>(nameof(ProximityInfo)); set => WriteHere(nameof(ProximityInfo), value); }

        [Offset(56UL)]
        public IntPtr WorkerFactory { get => ReadHere<IntPtr>(nameof(WorkerFactory)); set => WriteHere(nameof(WorkerFactory), value); }

        [Offset(64UL)]
        public IntPtr CompletionPort { get => ReadHere<IntPtr>(nameof(CompletionPort)); set => WriteHere(nameof(CompletionPort), value); }

        [Offset(72UL)]
        public RtlSrwlock Lock { get => ReadStructure<RtlSrwlock>(nameof(Lock)); set => WriteStructure(nameof(Lock), value); }

        [Offset(80UL)]
        public ListEntry PoolObjectList { get => ReadStructure<ListEntry>(nameof(PoolObjectList)); set => WriteStructure(nameof(PoolObjectList), value); }

        [Offset(96UL)]
        public ListEntry WorkerList { get => ReadStructure<ListEntry>(nameof(WorkerList)); set => WriteStructure(nameof(WorkerList), value); }

        [Offset(112UL)]
        public TppTimerQueue TimerQueue { get => ReadStructure<TppTimerQueue>(nameof(TimerQueue)); set => WriteStructure(nameof(TimerQueue), value); }

        [Offset(368UL)]
        public RtlSrwlock ShutdownLock { get => ReadStructure<RtlSrwlock>(nameof(ShutdownLock)); set => WriteStructure(nameof(ShutdownLock), value); }

        [Offset(376UL)]
        public byte ShutdownInitiated { get => ReadHere<byte>(nameof(ShutdownInitiated)); set => WriteHere(nameof(ShutdownInitiated), value); }

        [Offset(377UL)]
        public byte Released { get => ReadHere<byte>(nameof(Released)); set => WriteHere(nameof(Released), value); }

        [Offset(378UL)]
        public ushort PoolFlags { get => ReadHere<ushort>(nameof(PoolFlags)); set => WriteHere(nameof(PoolFlags), value); }

        [Offset(384UL)]
        public ListEntry PoolLinks { get => ReadStructure<ListEntry>(nameof(PoolLinks)); set => WriteStructure(nameof(PoolLinks), value); }

        [Offset(400UL)]
        public TppCaller AllocCaller { get => ReadStructure<TppCaller>(nameof(AllocCaller)); set => WriteStructure(nameof(AllocCaller), value); }

        [Offset(408UL)]
        public TppCaller ReleaseCaller { get => ReadStructure<TppCaller>(nameof(ReleaseCaller)); set => WriteStructure(nameof(ReleaseCaller), value); }

        [Offset(416UL)]
        public int AvailableWorkerCount { get => ReadHere<int>(nameof(AvailableWorkerCount)); set => WriteHere(nameof(AvailableWorkerCount), value); }

        [Offset(420UL)]
        public int LongRunningWorkerCount { get => ReadHere<int>(nameof(LongRunningWorkerCount)); set => WriteHere(nameof(LongRunningWorkerCount), value); }

        [Offset(424UL)]
        public uint LastProcCount { get => ReadHere<uint>(nameof(LastProcCount)); set => WriteHere(nameof(LastProcCount), value); }

        [Offset(428UL)]
        public int NodeStatus { get => ReadHere<int>(nameof(NodeStatus)); set => WriteHere(nameof(NodeStatus), value); }

        [Offset(432UL)]
        public int BindingCount { get => ReadHere<int>(nameof(BindingCount)); set => WriteHere(nameof(BindingCount), value); }

        [Offset(436UL)]
        public uint CallbackChecksDisabled { get => ReadHere<uint>(nameof(CallbackChecksDisabled)); set => WriteHere(nameof(CallbackChecksDisabled), value); }

        [Offset(436UL)]
        public uint TrimTarget { get => ReadHere<uint>(nameof(TrimTarget)); set => WriteHere(nameof(TrimTarget), value); }

        [Offset(436UL)]
        public uint TrimmedThrdCount { get => ReadHere<uint>(nameof(TrimmedThrdCount)); set => WriteHere(nameof(TrimmedThrdCount), value); }

        [Offset(440UL)]
        public uint SelectedCpuSetCount { get => ReadHere<uint>(nameof(SelectedCpuSetCount)); set => WriteHere(nameof(SelectedCpuSetCount), value); }

        [Offset(448UL)]
        public RtlConditionVariable TrimComplete { get => ReadStructure<RtlConditionVariable>(nameof(TrimComplete)); set => WriteStructure(nameof(TrimComplete), value); }

        [Offset(456UL)]
        public ListEntry TrimmedWorkerList { get => ReadStructure<ListEntry>(nameof(TrimmedWorkerList)); set => WriteStructure(nameof(TrimmedWorkerList), value); }

        public TpPool(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpPool>();
        }
    }
}