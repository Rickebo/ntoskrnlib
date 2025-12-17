#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1616)]
    public partial struct _WMI_LOGGER_CONTEXT
    {
        [FieldOffset(0)]
        public uint LoggerId;
        [FieldOffset(4)]
        public uint BufferSize;
        [FieldOffset(8)]
        public uint MaximumEventSize;
        [FieldOffset(12)]
        public uint LoggerMode;
        [FieldOffset(16)]
        public int AcceptNewEvents;
        [FieldOffset(24)]
        public ulong GetCpuClock;
        [FieldOffset(32)]
        public IntPtr LoggerThread;
        [FieldOffset(40)]
        public int LoggerStatus;
        [FieldOffset(44)]
        public uint FailureReason;
        [FieldOffset(48)]
        public _ETW_BUFFER_QUEUE BufferQueue;
        [FieldOffset(64)]
        public _ETW_BUFFER_QUEUE OverflowQueue;
        [FieldOffset(80)]
        public _LIST_ENTRY GlobalList;
        [FieldOffset(96)]
        public _LIST_ENTRY DebugIdTrackingList;
        [FieldOffset(112)]
        public IntPtr DecodeControlList;
        [FieldOffset(120)]
        public uint DecodeControlCount;
        [FieldOffset(128)]
        public IntPtr BatchedBufferList;
        [FieldOffset(128)]
        public _EX_FAST_REF CurrentBuffer;
        [FieldOffset(136)]
        public _UNICODE_STRING LoggerName;
        [FieldOffset(152)]
        public _UNICODE_STRING LogFileName;
        [FieldOffset(168)]
        public _UNICODE_STRING LogFilePattern;
        [FieldOffset(184)]
        public _UNICODE_STRING NewLogFileName;
        [FieldOffset(200)]
        public uint ClockType;
        [FieldOffset(204)]
        public uint LastFlushedBuffer;
        [FieldOffset(208)]
        public uint FlushTimer;
        [FieldOffset(212)]
        public uint FlushThreshold;
        [FieldOffset(216)]
        public _LARGE_INTEGER ByteOffset;
        [FieldOffset(224)]
        public uint MinimumBuffers;
        [FieldOffset(228)]
        public int BuffersAvailable;
        [FieldOffset(232)]
        public int NumberOfBuffers;
        [FieldOffset(236)]
        public uint MaximumBuffers;
        [FieldOffset(240)]
        public uint EventsLost;
        [FieldOffset(244)]
        public int PeakBuffersCount;
        [FieldOffset(248)]
        public uint BuffersWritten;
        [FieldOffset(252)]
        public uint LogBuffersLost;
        [FieldOffset(256)]
        public uint RealTimeBuffersDelivered;
        [FieldOffset(260)]
        public uint RealTimeBuffersLost;
        [FieldOffset(264)]
        public IntPtr SequencePtr;
        [FieldOffset(272)]
        public uint LocalSequence;
        [FieldOffset(276)]
        public _GUID InstanceGuid;
        [FieldOffset(292)]
        public uint MaximumFileSize;
        [FieldOffset(296)]
        public int FileCounter;
        [FieldOffset(300)]
        public uint PoolType;
        [FieldOffset(304)]
        public _ETW_REF_CLOCK ReferenceTime;
        [FieldOffset(320)]
        public int CollectionOn;
        [FieldOffset(324)]
        public uint ProviderInfoSize;
        [FieldOffset(328)]
        public _LIST_ENTRY Consumers;
        [FieldOffset(344)]
        public uint NumConsumers;
        [FieldOffset(352)]
        public IntPtr TransitionConsumer;
        [FieldOffset(360)]
        public IntPtr RealtimeLogfileHandle;
        [FieldOffset(368)]
        public _UNICODE_STRING RealtimeLogfileName;
        [FieldOffset(384)]
        public _LARGE_INTEGER RealtimeWriteOffset;
        [FieldOffset(392)]
        public _LARGE_INTEGER RealtimeReadOffset;
        [FieldOffset(400)]
        public _LARGE_INTEGER RealtimeLogfileSize;
        [FieldOffset(408)]
        public ulong RealtimeLogfileUsage;
        [FieldOffset(416)]
        public ulong RealtimeMaximumFileSize;
        [FieldOffset(424)]
        public uint RealtimeBuffersSaved;
        [FieldOffset(432)]
        public _ETW_REF_CLOCK RealtimeReferenceTime;
        [FieldOffset(448)]
        public uint NewRTEventsLost;
        [FieldOffset(456)]
        public _KEVENT LoggerEvent;
        [FieldOffset(480)]
        public _KEVENT FlushEvent;
        [FieldOffset(504)]
        public _KTIMER FlushTimeOutTimer;
        [FieldOffset(568)]
        public _KDPC LoggerDpc;
        [FieldOffset(632)]
        public _KMUTANT LoggerMutex;
        [FieldOffset(688)]
        public _EX_PUSH_LOCK LoggerLock;
        [FieldOffset(696)]
        public ulong BufferListSpinLock;
        [FieldOffset(696)]
        public _EX_PUSH_LOCK BufferListPushLock;
        [FieldOffset(704)]
        public _SECURITY_CLIENT_CONTEXT ClientSecurityContext;
        [FieldOffset(776)]
        public IntPtr TokenAccessInformation;
        [FieldOffset(784)]
        public _EX_FAST_REF SecurityDescriptor;
        [FieldOffset(792)]
        public _LARGE_INTEGER StartTime;
        [FieldOffset(800)]
        public IntPtr LogFileHandle;
        [FieldOffset(808)]
        public long BufferSequenceNumber;
        [FieldOffset(816)]
        public uint Flags;
        [FieldOffset(816)]
        public uint Persistent;
        [FieldOffset(816)]
        public uint AutoLogger;
        [FieldOffset(816)]
        public uint FsReady;
        [FieldOffset(816)]
        public uint RealTime;
        [FieldOffset(816)]
        public uint Wow;
        [FieldOffset(816)]
        public uint KernelTrace;
        [FieldOffset(816)]
        public uint NoMoreEnable;
        [FieldOffset(816)]
        public uint StackTracing;
        [FieldOffset(816)]
        public uint ErrorLogged;
        [FieldOffset(816)]
        public uint RealtimeLoggerContextFreed;
        [FieldOffset(816)]
        public uint PebsTracing;
        [FieldOffset(816)]
        public uint PmcCounters;
        [FieldOffset(816)]
        public uint PageAlignBuffers;
        [FieldOffset(816)]
        public uint StackLookasideListAllocated;
        [FieldOffset(816)]
        public uint SecurityTrace;
        [FieldOffset(816)]
        public uint LastBranchTracing;
        [FieldOffset(816)]
        public uint SystemLoggerIndex;
        [FieldOffset(816)]
        public uint StackCaching;
        [FieldOffset(816)]
        public uint ProviderTracking;
        [FieldOffset(816)]
        public uint ProcessorTrace;
        [FieldOffset(816)]
        public uint QpcDeltaTracking;
        [FieldOffset(816)]
        public uint MarkerBufferSaved;
        [FieldOffset(816)]
        public uint LargeMdlPages;
        [FieldOffset(816)]
        public uint ExcludeKernelStack;
        [FieldOffset(816)]
        public uint BootLogger;
        [FieldOffset(820)]
        public uint Flags2;
        [FieldOffset(820)]
        public uint UnifiedStackCaching;
        [FieldOffset(824)]
        public uint RequestFlag;
        [FieldOffset(824)]
        public uint DbgRequestNewFile;
        [FieldOffset(824)]
        public uint DbgRequestUpdateFile;
        [FieldOffset(824)]
        public uint DbgRequestFlush;
        [FieldOffset(824)]
        public uint DbgRequestDisableRealtime;
        [FieldOffset(824)]
        public uint DbgRequestDisconnectConsumer;
        [FieldOffset(824)]
        public uint DbgRequestConnectConsumer;
        [FieldOffset(824)]
        public uint DbgRequestNotifyConsumer;
        [FieldOffset(824)]
        public uint DbgRequestUpdateHeader;
        [FieldOffset(824)]
        public uint DbgRequestDeferredFlush;
        [FieldOffset(824)]
        public uint DbgRequestDeferredFlushTimer;
        [FieldOffset(824)]
        public uint DbgRequestFlushTimer;
        [FieldOffset(824)]
        public uint DbgRequestUpdateDebugger;
        [FieldOffset(824)]
        public uint DbgSpareRequestFlags;
        [FieldOffset(832)]
        public _ETW_STACK_TRACE_BLOCK StackTraceBlock;
        [FieldOffset(1040)]
        public _RTL_BITMAP StackHookIdMap;
        [FieldOffset(1056)]
        public IntPtr StackCache;
        [FieldOffset(1064)]
        public IntPtr PmcData;
        [FieldOffset(1072)]
        public IntPtr LbrData;
        [FieldOffset(1080)]
        public IntPtr IptData;
        [FieldOffset(1088)]
        public _ETW_APC_POOL ContextRegisterLoggingApcPool;
        [FieldOffset(1280)]
        public uint ContextRegisterTypes;
        [FieldOffset(1284)]
        public uint ContextRegisterHookCount;
        [FieldOffset(1288)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public ushort[] ContextRegisterHookIdMap;
        [FieldOffset(1304)]
        public _LIST_ENTRY BinaryTrackingList;
        [FieldOffset(1320)]
        public IntPtr ScratchArray;
        [FieldOffset(1328)]
        public _DISALLOWED_GUIDS DisallowedGuids;
        [FieldOffset(1344)]
        public IntPtr PeriodicCaptureStateContext;
        [FieldOffset(1352)]
        public IntPtr SoftRestartContext;
        [FieldOffset(1360)]
        public IntPtr SiloState;
        [FieldOffset(1368)]
        public _WORK_QUEUE_ITEM CompressionWorkItem;
        [FieldOffset(1400)]
        public int CompressionWorkItemState;
        [FieldOffset(1408)]
        public _EX_PUSH_LOCK CompressionLock;
        [FieldOffset(1416)]
        public IntPtr CompressionTarget;
        [FieldOffset(1424)]
        public IntPtr CompressionWorkspace;
        [FieldOffset(1432)]
        public int CompressionOn;
        [FieldOffset(1436)]
        public uint CompressionRatioGuess;
        [FieldOffset(1440)]
        public uint PartialBufferCompressionLevel;
        [FieldOffset(1444)]
        public uint CompressionResumptionMode;
        [FieldOffset(1448)]
        public _SINGLE_LIST_ENTRY PlaceholderList;
        [FieldOffset(1456)]
        public _KDPC CompressionDpc;
        [FieldOffset(1520)]
        public _LARGE_INTEGER LastBufferSwitchTime;
        [FieldOffset(1528)]
        public _LARGE_INTEGER BufferWriteDuration;
        [FieldOffset(1536)]
        public _LARGE_INTEGER BufferCompressDuration;
        [FieldOffset(1544)]
        public long ReferenceQpcDelta;
        [FieldOffset(1552)]
        public IntPtr CallbackContext;
        [FieldOffset(1560)]
        public IntPtr LastDroppedTime;
        [FieldOffset(1568)]
        public IntPtr FlushingLastDroppedTime;
        [FieldOffset(1576)]
        public long FlushingSequenceNumber;
        [FieldOffset(1584)]
        public _ETW_PARTITION_CONTEXT PartitionContext;
        [FieldOffset(1592)]
        public IntPtr BufferMdl;
        [FieldOffset(1600)]
        public IntPtr PfnArray;
    }
}