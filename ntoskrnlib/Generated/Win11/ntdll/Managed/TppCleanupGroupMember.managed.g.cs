using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_CLEANUP_GROUP_MEMBER")]
    public sealed class TppCleanupGroupMember : DynamicStructure
    {
        [Offset(0UL)]
        public TppRefcount Refcount { get => ReadStructure<TppRefcount>(nameof(Refcount)); set => WriteStructure(nameof(Refcount), value); }

        [Offset(8UL)]
        public IntPtr VFuncs { get => ReadHere<IntPtr>(nameof(VFuncs)); set => WriteHere(nameof(VFuncs), value); }

        [Offset(16UL)]
        public IntPtr CleanupGroup { get => ReadHere<IntPtr>(nameof(CleanupGroup)); set => WriteHere(nameof(CleanupGroup), value); }

        [Offset(24UL)]
        public IntPtr CleanupGroupCancelCallback { get => ReadHere<IntPtr>(nameof(CleanupGroupCancelCallback)); set => WriteHere(nameof(CleanupGroupCancelCallback), value); }

        [Offset(32UL)]
        public IntPtr FinalizationCallback { get => ReadHere<IntPtr>(nameof(FinalizationCallback)); set => WriteHere(nameof(FinalizationCallback), value); }

        [Offset(40UL)]
        public ListEntry CleanupGroupMemberLinks { get => ReadStructure<ListEntry>(nameof(CleanupGroupMemberLinks)); set => WriteStructure(nameof(CleanupGroupMemberLinks), value); }

        [Offset(56UL)]
        public TppBarrier CallbackBarrier { get => ReadStructure<TppBarrier>(nameof(CallbackBarrier)); set => WriteStructure(nameof(CallbackBarrier), value); }

        [Offset(80UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(80UL)]
        public IntPtr WorkCallback { get => ReadHere<IntPtr>(nameof(WorkCallback)); set => WriteHere(nameof(WorkCallback), value); }

        [Offset(80UL)]
        public IntPtr SimpleCallback { get => ReadHere<IntPtr>(nameof(SimpleCallback)); set => WriteHere(nameof(SimpleCallback), value); }

        [Offset(80UL)]
        public IntPtr TimerCallback { get => ReadHere<IntPtr>(nameof(TimerCallback)); set => WriteHere(nameof(TimerCallback), value); }

        [Offset(80UL)]
        public IntPtr WaitCallback { get => ReadHere<IntPtr>(nameof(WaitCallback)); set => WriteHere(nameof(WaitCallback), value); }

        [Offset(80UL)]
        public IntPtr IoCallback { get => ReadHere<IntPtr>(nameof(IoCallback)); set => WriteHere(nameof(IoCallback), value); }

        [Offset(80UL)]
        public IntPtr AlpcCallback { get => ReadHere<IntPtr>(nameof(AlpcCallback)); set => WriteHere(nameof(AlpcCallback), value); }

        [Offset(80UL)]
        public IntPtr AlpcCallbackEx { get => ReadHere<IntPtr>(nameof(AlpcCallbackEx)); set => WriteHere(nameof(AlpcCallbackEx), value); }

        [Offset(80UL)]
        public IntPtr JobCallback { get => ReadHere<IntPtr>(nameof(JobCallback)); set => WriteHere(nameof(JobCallback), value); }

        [Offset(88UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(96UL)]
        public IntPtr ActivationContext { get => ReadHere<IntPtr>(nameof(ActivationContext)); set => WriteHere(nameof(ActivationContext), value); }

        [Offset(104UL)]
        public IntPtr SubProcessTag { get => ReadHere<IntPtr>(nameof(SubProcessTag)); set => WriteHere(nameof(SubProcessTag), value); }

        [Offset(112UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        [Offset(128UL)]
        public AlpcWorkOnBehalfTicket WorkOnBehalfTicket { get => ReadStructure<AlpcWorkOnBehalfTicket>(nameof(WorkOnBehalfTicket)); set => WriteStructure(nameof(WorkOnBehalfTicket), value); }

        [Offset(136UL)]
        public IntPtr RaceDll { get => ReadHere<IntPtr>(nameof(RaceDll)); set => WriteHere(nameof(RaceDll), value); }

        [Offset(144UL)]
        public IntPtr Pool { get => ReadHere<IntPtr>(nameof(Pool)); set => WriteHere(nameof(Pool), value); }

        [Offset(152UL)]
        public ListEntry PoolObjectLinks { get => ReadStructure<ListEntry>(nameof(PoolObjectLinks)); set => WriteStructure(nameof(PoolObjectLinks), value); }

        [Offset(168UL)]
        public int Flags { get => ReadHere<int>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(168UL)]
        public uint LongFunction { get => ReadHere<uint>(nameof(LongFunction)); set => WriteHere(nameof(LongFunction), value); }

        [Offset(168UL)]
        public uint Persistent { get => ReadHere<uint>(nameof(Persistent)); set => WriteHere(nameof(Persistent), value); }

        [Offset(168UL)]
        public uint UnusedPublic { get => ReadHere<uint>(nameof(UnusedPublic)); set => WriteHere(nameof(UnusedPublic), value); }

        [Offset(168UL)]
        public uint Released { get => ReadHere<uint>(nameof(Released)); set => WriteHere(nameof(Released), value); }

        [Offset(168UL)]
        public uint CleanupGroupReleased { get => ReadHere<uint>(nameof(CleanupGroupReleased)); set => WriteHere(nameof(CleanupGroupReleased), value); }

        [Offset(168UL)]
        public uint InCleanupGroupCleanupList { get => ReadHere<uint>(nameof(InCleanupGroupCleanupList)); set => WriteHere(nameof(InCleanupGroupCleanupList), value); }

        [Offset(168UL)]
        public uint UnusedPrivate { get => ReadHere<uint>(nameof(UnusedPrivate)); set => WriteHere(nameof(UnusedPrivate), value); }

        [Offset(176UL)]
        public TppCaller AllocCaller { get => ReadStructure<TppCaller>(nameof(AllocCaller)); set => WriteStructure(nameof(AllocCaller), value); }

        [Offset(184UL)]
        public TppCaller ReleaseCaller { get => ReadStructure<TppCaller>(nameof(ReleaseCaller)); set => WriteStructure(nameof(ReleaseCaller), value); }

        [Offset(192UL)]
        public uint CallbackPriority { get => ReadHere<uint>(nameof(CallbackPriority)); set => WriteHere(nameof(CallbackPriority), value); }

        public TppCleanupGroupMember(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppCleanupGroupMember>();
        }
    }
}