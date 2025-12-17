using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_CALLBACK_INSTANCE")]
    public sealed class TpCallbackInstance : DynamicStructure
    {
        [Offset(0UL)]
        public RtlCallerAllocatedActivationContextStackFrameExtended ActivationFrame { get => ReadStructure<RtlCallerAllocatedActivationContextStackFrameExtended>(nameof(ActivationFrame)); set => WriteStructure(nameof(ActivationFrame), value); }

        [Offset(72UL)]
        public uint CallbackRunType { get => ReadHere<uint>(nameof(CallbackRunType)); set => WriteHere(nameof(CallbackRunType), value); }

        [Offset(76UL)]
        public byte ActivationFrameUsed { get => ReadHere<byte>(nameof(ActivationFrameUsed)); set => WriteHere(nameof(ActivationFrameUsed), value); }

        [Offset(76UL)]
        public byte Disassociated { get => ReadHere<byte>(nameof(Disassociated)); set => WriteHere(nameof(Disassociated), value); }

        [Offset(76UL)]
        public byte UnrecoverableErrorDetected { get => ReadHere<byte>(nameof(UnrecoverableErrorDetected)); set => WriteHere(nameof(UnrecoverableErrorDetected), value); }

        [Offset(80UL)]
        public IntPtr SubProcessTag { get => ReadHere<IntPtr>(nameof(SubProcessTag)); set => WriteHere(nameof(SubProcessTag), value); }

        [Offset(88UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(88UL)]
        public IntPtr WorkCallback { get => ReadHere<IntPtr>(nameof(WorkCallback)); set => WriteHere(nameof(WorkCallback), value); }

        [Offset(88UL)]
        public IntPtr SimpleCallback { get => ReadHere<IntPtr>(nameof(SimpleCallback)); set => WriteHere(nameof(SimpleCallback), value); }

        [Offset(88UL)]
        public IntPtr TimerCallback { get => ReadHere<IntPtr>(nameof(TimerCallback)); set => WriteHere(nameof(TimerCallback), value); }

        [Offset(88UL)]
        public IntPtr WaitCallback { get => ReadHere<IntPtr>(nameof(WaitCallback)); set => WriteHere(nameof(WaitCallback), value); }

        [Offset(88UL)]
        public IntPtr IoCallback { get => ReadHere<IntPtr>(nameof(IoCallback)); set => WriteHere(nameof(IoCallback), value); }

        [Offset(88UL)]
        public IntPtr AlpcCallback { get => ReadHere<IntPtr>(nameof(AlpcCallback)); set => WriteHere(nameof(AlpcCallback), value); }

        [Offset(88UL)]
        public IntPtr AlpcCallbackEx { get => ReadHere<IntPtr>(nameof(AlpcCallbackEx)); set => WriteHere(nameof(AlpcCallbackEx), value); }

        [Offset(88UL)]
        public IntPtr JobCallback { get => ReadHere<IntPtr>(nameof(JobCallback)); set => WriteHere(nameof(JobCallback), value); }

        [Offset(88UL)]
        public IntPtr FinalizationCallback { get => ReadHere<IntPtr>(nameof(FinalizationCallback)); set => WriteHere(nameof(FinalizationCallback), value); }

        [Offset(88UL)]
        public IntPtr DirectCallback { get => ReadHere<IntPtr>(nameof(DirectCallback)); set => WriteHere(nameof(DirectCallback), value); }

        [Offset(88UL)]
        public IntPtr TaskCallback { get => ReadHere<IntPtr>(nameof(TaskCallback)); set => WriteHere(nameof(TaskCallback), value); }

        [Offset(96UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(104UL)]
        public uint SkipPostThreadFlags { get => ReadHere<uint>(nameof(SkipPostThreadFlags)); set => WriteHere(nameof(SkipPostThreadFlags), value); }

        [Offset(104UL)]
        public uint SPActFrame { get => ReadHere<uint>(nameof(SPActFrame)); set => WriteHere(nameof(SPActFrame), value); }

        [Offset(104UL)]
        public uint SPSubProcTag { get => ReadHere<uint>(nameof(SPSubProcTag)); set => WriteHere(nameof(SPSubProcTag), value); }

        [Offset(104UL)]
        public uint SPImpersonation { get => ReadHere<uint>(nameof(SPImpersonation)); set => WriteHere(nameof(SPImpersonation), value); }

        [Offset(104UL)]
        public uint SPThreadInfo { get => ReadHere<uint>(nameof(SPThreadInfo)); set => WriteHere(nameof(SPThreadInfo), value); }

        [Offset(104UL)]
        public uint SPTransaction { get => ReadHere<uint>(nameof(SPTransaction)); set => WriteHere(nameof(SPTransaction), value); }

        [Offset(104UL)]
        public uint SPLdrLock { get => ReadHere<uint>(nameof(SPLdrLock)); set => WriteHere(nameof(SPLdrLock), value); }

        [Offset(104UL)]
        public uint SPLanguages { get => ReadHere<uint>(nameof(SPLanguages)); set => WriteHere(nameof(SPLanguages), value); }

        [Offset(104UL)]
        public uint SPThreadPriBack { get => ReadHere<uint>(nameof(SPThreadPriBack)); set => WriteHere(nameof(SPThreadPriBack), value); }

        [Offset(108UL)]
        public uint VerifyThreadFlags { get => ReadHere<uint>(nameof(VerifyThreadFlags)); set => WriteHere(nameof(VerifyThreadFlags), value); }

        [Offset(108UL)]
        public uint VThreadInfo { get => ReadHere<uint>(nameof(VThreadInfo)); set => WriteHere(nameof(VThreadInfo), value); }

        [Offset(112UL)]
        public int PreCallThrdPriority { get => ReadHere<int>(nameof(PreCallThrdPriority)); set => WriteHere(nameof(PreCallThrdPriority), value); }

        [Offset(120UL)]
        public ulong PreCallThrdAffinity { get => ReadHere<ulong>(nameof(PreCallThrdAffinity)); set => WriteHere(nameof(PreCallThrdAffinity), value); }

        [Offset(128UL)]
        public IntPtr Pool { get => ReadHere<IntPtr>(nameof(Pool)); set => WriteHere(nameof(Pool), value); }

        [Offset(136UL)]
        public IntPtr AlpcWorkItem { get => ReadHere<IntPtr>(nameof(AlpcWorkItem)); set => WriteHere(nameof(AlpcWorkItem), value); }

        [Offset(144UL)]
        public uint CallbackEpilogFlags { get => ReadHere<uint>(nameof(CallbackEpilogFlags)); set => WriteHere(nameof(CallbackEpilogFlags), value); }

        [Offset(148UL)]
        public uint Event { get => ReadHere<uint>(nameof(Event)); set => WriteHere(nameof(Event), value); }

        [Offset(152UL)]
        public uint Mutex { get => ReadHere<uint>(nameof(Mutex)); set => WriteHere(nameof(Mutex), value); }

        [Offset(156UL)]
        public uint Semaphore { get => ReadHere<uint>(nameof(Semaphore)); set => WriteHere(nameof(Semaphore), value); }

        [Offset(160UL)]
        public uint SemaphoreReleaseCount { get => ReadHere<uint>(nameof(SemaphoreReleaseCount)); set => WriteHere(nameof(SemaphoreReleaseCount), value); }

        [Offset(168UL)]
        public IntPtr RaceDll { get => ReadHere<IntPtr>(nameof(RaceDll)); set => WriteHere(nameof(RaceDll), value); }

        [Offset(176UL)]
        public IntPtr CleanupGroup { get => ReadHere<IntPtr>(nameof(CleanupGroup)); set => WriteHere(nameof(CleanupGroup), value); }

        [Offset(184UL)]
        public IntPtr CleanupGroupMember { get => ReadHere<IntPtr>(nameof(CleanupGroupMember)); set => WriteHere(nameof(CleanupGroupMember), value); }

        [Offset(192UL)]
        public IntPtr CriticalSection { get => ReadHere<IntPtr>(nameof(CriticalSection)); set => WriteHere(nameof(CriticalSection), value); }

        [Offset(200UL)]
        public IntPtr DllHandle { get => ReadHere<IntPtr>(nameof(DllHandle)); set => WriteHere(nameof(DllHandle), value); }

        [Offset(208UL)]
        public WorkerFactoryDeferredWork DeferredWork { get => ReadStructure<WorkerFactoryDeferredWork>(nameof(DeferredWork)); set => WriteStructure(nameof(DeferredWork), value); }

        [Offset(232UL)]
        public Guid PreviousActivityId { get => ReadStructure<Guid>(nameof(PreviousActivityId)); set => WriteStructure(nameof(PreviousActivityId), value); }

        [Offset(248UL)]
        public ulong WorkOnBehalf { get => ReadHere<ulong>(nameof(WorkOnBehalf)); set => WriteHere(nameof(WorkOnBehalf), value); }

        public TpCallbackInstance(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpCallbackInstance>();
        }
    }
}