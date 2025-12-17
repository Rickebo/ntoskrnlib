using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_COMPONENT")]
    public sealed class PopFxComponent : DynamicStructure
    {
        [Offset(0UL)]
        public Guid Id { get => ReadStructure<Guid>(nameof(Id)); set => WriteStructure(nameof(Id), value); }

        [Offset(16UL)]
        public uint Index { get => ReadHere<uint>(nameof(Index)); set => WriteHere(nameof(Index), value); }

        [Offset(24UL)]
        public PopFxWorkOrder WorkOrder { get => ReadStructure<PopFxWorkOrder>(nameof(WorkOrder)); set => WriteStructure(nameof(WorkOrder), value); }

        [Offset(80UL)]
        public IntPtr Device { get => ReadHere<IntPtr>(nameof(Device)); set => WriteHere(nameof(Device), value); }

        [Offset(88UL)]
        public PopFxComponentFlags Flags { get => ReadStructure<PopFxComponentFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(96UL)]
        public int Resident { get => ReadHere<int>(nameof(Resident)); set => WriteHere(nameof(Resident), value); }

        [Offset(104UL)]
        public Kevent ActiveEvent { get => ReadStructure<Kevent>(nameof(ActiveEvent)); set => WriteStructure(nameof(ActiveEvent), value); }

        [Offset(128UL)]
        public ulong IdleLock { get => ReadHere<ulong>(nameof(IdleLock)); set => WriteHere(nameof(IdleLock), value); }

        [Offset(136UL)]
        public int IdleConditionComplete { get => ReadHere<int>(nameof(IdleConditionComplete)); set => WriteHere(nameof(IdleConditionComplete), value); }

        [Offset(140UL)]
        public int IdleStateComplete { get => ReadHere<int>(nameof(IdleStateComplete)); set => WriteHere(nameof(IdleStateComplete), value); }

        [Offset(144UL)]
        public ulong IdleStamp { get => ReadHere<ulong>(nameof(IdleStamp)); set => WriteHere(nameof(IdleStamp), value); }

        [Offset(152UL)]
        public uint CurrentIdleState { get => ReadHere<uint>(nameof(CurrentIdleState)); set => WriteHere(nameof(CurrentIdleState), value); }

        [Offset(156UL)]
        public uint IdleStateCount { get => ReadHere<uint>(nameof(IdleStateCount)); set => WriteHere(nameof(IdleStateCount), value); }

        [Offset(160UL)]
        public IntPtr IdleStates { get => ReadHere<IntPtr>(nameof(IdleStates)); set => WriteHere(nameof(IdleStates), value); }

        [Offset(168UL)]
        public uint DeepestWakeableIdleState { get => ReadHere<uint>(nameof(DeepestWakeableIdleState)); set => WriteHere(nameof(DeepestWakeableIdleState), value); }

        [Offset(172UL)]
        public uint ProviderCount { get => ReadHere<uint>(nameof(ProviderCount)); set => WriteHere(nameof(ProviderCount), value); }

        [Offset(176UL)]
        public IntPtr Providers { get => ReadHere<IntPtr>(nameof(Providers)); set => WriteHere(nameof(Providers), value); }

        [Offset(184UL)]
        public uint IdleProviderCount { get => ReadHere<uint>(nameof(IdleProviderCount)); set => WriteHere(nameof(IdleProviderCount), value); }

        [Offset(188UL)]
        public uint DependentCount { get => ReadHere<uint>(nameof(DependentCount)); set => WriteHere(nameof(DependentCount), value); }

        [Offset(192UL)]
        public IntPtr Dependents { get => ReadHere<IntPtr>(nameof(Dependents)); set => WriteHere(nameof(Dependents), value); }

        [Offset(200UL)]
        public PopFxAccounting Accounting { get => ReadStructure<PopFxAccounting>(nameof(Accounting)); set => WriteStructure(nameof(Accounting), value); }

        [Offset(424UL)]
        public IntPtr Performance { get => ReadHere<IntPtr>(nameof(Performance)); set => WriteHere(nameof(Performance), value); }

        [Offset(432UL)]
        public IntPtr PowerProfile { get => ReadHere<IntPtr>(nameof(PowerProfile)); set => WriteHere(nameof(PowerProfile), value); }

        [Offset(440UL)]
        public ListEntry ExternalDependents { get => ReadStructure<ListEntry>(nameof(ExternalDependents)); set => WriteStructure(nameof(ExternalDependents), value); }

        [Offset(456UL)]
        public ListEntry ExternalDependencies { get => ReadStructure<ListEntry>(nameof(ExternalDependencies)); set => WriteStructure(nameof(ExternalDependencies), value); }

        public PopFxComponent(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxComponent>();
        }
    }
}