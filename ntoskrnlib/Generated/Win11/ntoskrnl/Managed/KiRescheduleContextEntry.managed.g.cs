using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_RESCHEDULE_CONTEXT_ENTRY")]
    public sealed class KiRescheduleContextEntry : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Prcb { get => ReadHere<IntPtr>(nameof(Prcb)); set => WriteHere(nameof(Prcb), value); }

        [Offset(8UL)]
        public IntPtr SharedReadyQueue { get => ReadHere<IntPtr>(nameof(SharedReadyQueue)); set => WriteHere(nameof(SharedReadyQueue), value); }

        [Offset(16UL)]
        public IntPtr CompareThread { get => ReadHere<IntPtr>(nameof(CompareThread)); set => WriteHere(nameof(CompareThread), value); }

        [Offset(24UL)]
        public IntPtr NewThread { get => ReadHere<IntPtr>(nameof(NewThread)); set => WriteHere(nameof(NewThread), value); }

        [Offset(32UL)]
        public byte Idle { get => ReadHere<byte>(nameof(Idle)); set => WriteHere(nameof(Idle), value); }

        [Offset(32UL)]
        public byte IsolationWidth { get => ReadHere<byte>(nameof(IsolationWidth)); set => WriteHere(nameof(IsolationWidth), value); }

        [Offset(32UL)]
        public byte CanCheckDeferredPreemption { get => ReadHere<byte>(nameof(CanCheckDeferredPreemption)); set => WriteHere(nameof(CanCheckDeferredPreemption), value); }

        [Offset(32UL)]
        public byte PartialYield { get => ReadHere<byte>(nameof(PartialYield)); set => WriteHere(nameof(PartialYield), value); }

        [Offset(32UL)]
        public byte FullYield { get => ReadHere<byte>(nameof(FullYield)); set => WriteHere(nameof(FullYield), value); }

        [Offset(32UL)]
        public byte IsolationPlaceholder { get => ReadHere<byte>(nameof(IsolationPlaceholder)); set => WriteHere(nameof(IsolationPlaceholder), value); }

        [Offset(32UL)]
        public byte SpareCompateThreadStateFlags { get => ReadHere<byte>(nameof(SpareCompateThreadStateFlags)); set => WriteHere(nameof(SpareCompateThreadStateFlags), value); }

        [Offset(32UL)]
        public byte AllCompareThreadStateFlags { get => ReadHere<byte>(nameof(AllCompareThreadStateFlags)); set => WriteHere(nameof(AllCompareThreadStateFlags), value); }

        [Offset(33UL)]
        public byte ReadyTransition { get => ReadHere<byte>(nameof(ReadyTransition)); set => WriteHere(nameof(ReadyTransition), value); }

        [Offset(33UL)]
        public byte SpareNewThreadStateFlags { get => ReadHere<byte>(nameof(SpareNewThreadStateFlags)); set => WriteHere(nameof(SpareNewThreadStateFlags), value); }

        [Offset(33UL)]
        public byte AllNewThreadStateFlags { get => ReadHere<byte>(nameof(AllNewThreadStateFlags)); set => WriteHere(nameof(AllNewThreadStateFlags), value); }

        [Offset(34UL)]
        public byte SkipStandbyReschedule { get => ReadHere<byte>(nameof(SkipStandbyReschedule)); set => WriteHere(nameof(SkipStandbyReschedule), value); }

        [Offset(34UL)]
        public byte DoNotSetPreemptionBit { get => ReadHere<byte>(nameof(DoNotSetPreemptionBit)); set => WriteHere(nameof(DoNotSetPreemptionBit), value); }

        [Offset(34UL)]
        public byte SpareCommitFlags { get => ReadHere<byte>(nameof(SpareCommitFlags)); set => WriteHere(nameof(SpareCommitFlags), value); }

        [Offset(34UL)]
        public byte AllCommitFlags { get => ReadHere<byte>(nameof(AllCommitFlags)); set => WriteHere(nameof(AllCommitFlags), value); }

        [Offset(35UL)]
        public byte NewThreadReferenced { get => ReadHere<byte>(nameof(NewThreadReferenced)); set => WriteHere(nameof(NewThreadReferenced), value); }

        [Offset(35UL)]
        public byte LogEtw { get => ReadHere<byte>(nameof(LogEtw)); set => WriteHere(nameof(LogEtw), value); }

        [Offset(35UL)]
        public byte IssuePriorityKick { get => ReadHere<byte>(nameof(IssuePriorityKick)); set => WriteHere(nameof(IssuePriorityKick), value); }

        [Offset(35UL)]
        public byte DispatchInterruptIfHalted { get => ReadHere<byte>(nameof(DispatchInterruptIfHalted)); set => WriteHere(nameof(DispatchInterruptIfHalted), value); }

        [Offset(35UL)]
        public byte DispatchInterruptAlways { get => ReadHere<byte>(nameof(DispatchInterruptAlways)); set => WriteHere(nameof(DispatchInterruptAlways), value); }

        [Offset(35UL)]
        public byte SpareCompletionFlags { get => ReadHere<byte>(nameof(SpareCompletionFlags)); set => WriteHere(nameof(SpareCompletionFlags), value); }

        [Offset(35UL)]
        public byte AllCompletionFlags { get => ReadHere<byte>(nameof(AllCompletionFlags)); set => WriteHere(nameof(AllCompletionFlags), value); }

        [Offset(36UL)]
        public sbyte KickPriority { get => ReadHere<sbyte>(nameof(KickPriority)); set => WriteHere(nameof(KickPriority), value); }

        [Offset(37UL)]
        [Length(3)]
        public DynamicArray Spare { get => ReadStructure<DynamicArray>(nameof(Spare)); set => WriteStructure(nameof(Spare), value); }

        public KiRescheduleContextEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiRescheduleContextEntry>();
        }
    }
}