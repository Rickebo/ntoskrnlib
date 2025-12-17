#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _TP_CALLBACK_INSTANCE
    {
        [FieldOffset(0)]
        public _RTL_CALLER_ALLOCATED_ACTIVATION_CONTEXT_STACK_FRAME_EXTENDED ActivationFrame;
        [FieldOffset(72)]
        public uint CallbackRunType;
        [FieldOffset(76)]
        public byte ActivationFrameUsed;
        [FieldOffset(76)]
        public byte Disassociated;
        [FieldOffset(76)]
        public byte UnrecoverableErrorDetected;
        [FieldOffset(80)]
        public IntPtr SubProcessTag;
        [FieldOffset(88)]
        public IntPtr Callback;
        [FieldOffset(88)]
        public IntPtr WorkCallback;
        [FieldOffset(88)]
        public IntPtr SimpleCallback;
        [FieldOffset(88)]
        public IntPtr TimerCallback;
        [FieldOffset(88)]
        public IntPtr WaitCallback;
        [FieldOffset(88)]
        public IntPtr IoCallback;
        [FieldOffset(88)]
        public IntPtr AlpcCallback;
        [FieldOffset(88)]
        public IntPtr AlpcCallbackEx;
        [FieldOffset(88)]
        public IntPtr JobCallback;
        [FieldOffset(88)]
        public IntPtr FinalizationCallback;
        [FieldOffset(88)]
        public IntPtr DirectCallback;
        [FieldOffset(88)]
        public IntPtr TaskCallback;
        [FieldOffset(96)]
        public IntPtr Context;
        [FieldOffset(104)]
        public uint SkipPostThreadFlags;
        [FieldOffset(104)]
        public uint SPActFrame;
        [FieldOffset(104)]
        public uint SPSubProcTag;
        [FieldOffset(104)]
        public uint SPImpersonation;
        [FieldOffset(104)]
        public uint SPThreadInfo;
        [FieldOffset(104)]
        public uint SPTransaction;
        [FieldOffset(104)]
        public uint SPLdrLock;
        [FieldOffset(104)]
        public uint SPLanguages;
        [FieldOffset(104)]
        public uint SPThreadPriBack;
        [FieldOffset(108)]
        public uint VerifyThreadFlags;
        [FieldOffset(108)]
        public uint VThreadInfo;
        [FieldOffset(112)]
        public int PreCallThrdPriority;
        [FieldOffset(120)]
        public ulong PreCallThrdAffinity;
        [FieldOffset(128)]
        public IntPtr Pool;
        [FieldOffset(136)]
        public IntPtr AlpcWorkItem;
        [FieldOffset(144)]
        public uint CallbackEpilogFlags;
        [FieldOffset(148)]
        public uint Event;
        [FieldOffset(152)]
        public uint Mutex;
        [FieldOffset(156)]
        public uint Semaphore;
        [FieldOffset(160)]
        public uint SemaphoreReleaseCount;
        [FieldOffset(168)]
        public IntPtr RaceDll;
        [FieldOffset(176)]
        public IntPtr CleanupGroup;
        [FieldOffset(184)]
        public IntPtr CleanupGroupMember;
        [FieldOffset(192)]
        public IntPtr CriticalSection;
        [FieldOffset(200)]
        public IntPtr DllHandle;
        [FieldOffset(208)]
        public _WORKER_FACTORY_DEFERRED_WORK DeferredWork;
        [FieldOffset(232)]
        public _GUID PreviousActivityId;
        [FieldOffset(248)]
        public ulong WorkOnBehalf;
    }
}