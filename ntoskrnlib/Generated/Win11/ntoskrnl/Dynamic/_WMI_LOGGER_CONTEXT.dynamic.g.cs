using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WMI_LOGGER_CONTEXT")]
    public sealed class _WMI_LOGGER_CONTEXT : DynamicStructure
    {
        public uint LoggerId { get; }
        public uint BufferSize { get; }
        public uint MaximumEventSize { get; }
        public uint LoggerMode { get; }
        public int AcceptNewEvents { get; }
        public ulong GetCpuClock { get; }
        public IntPtr LoggerThread { get; }
        public int LoggerStatus { get; }
        public uint FailureReason { get; }
        public _ETW_BUFFER_QUEUE BufferQueue { get; }
        public _ETW_BUFFER_QUEUE OverflowQueue { get; }
        public _LIST_ENTRY GlobalList { get; }
        public _LIST_ENTRY DebugIdTrackingList { get; }
        public IntPtr DecodeControlList { get; }
        public uint DecodeControlCount { get; }
        public IntPtr BatchedBufferList { get; }
        public _EX_FAST_REF CurrentBuffer { get; }
        public _UNICODE_STRING LoggerName { get; }
        public _UNICODE_STRING LogFileName { get; }
        public _UNICODE_STRING LogFilePattern { get; }
        public _UNICODE_STRING NewLogFileName { get; }
        public uint ClockType { get; }
        public uint LastFlushedBuffer { get; }
        public uint FlushTimer { get; }
        public uint FlushThreshold { get; }
        public _LARGE_INTEGER ByteOffset { get; }
        public uint MinimumBuffers { get; }
        public int BuffersAvailable { get; }
        public int NumberOfBuffers { get; }
        public uint MaximumBuffers { get; }
        public uint EventsLost { get; }
        public int PeakBuffersCount { get; }
        public uint BuffersWritten { get; }
        public uint LogBuffersLost { get; }
        public uint RealTimeBuffersDelivered { get; }
        public uint RealTimeBuffersLost { get; }
        public IntPtr SequencePtr { get; }
        public uint LocalSequence { get; }
        public _GUID InstanceGuid { get; }
        public uint MaximumFileSize { get; }
        public int FileCounter { get; }
        public uint PoolType { get; }
        public _ETW_REF_CLOCK ReferenceTime { get; }
        public int CollectionOn { get; }
        public uint ProviderInfoSize { get; }
        public _LIST_ENTRY Consumers { get; }
        public uint NumConsumers { get; }
        public IntPtr TransitionConsumer { get; }
        public IntPtr RealtimeLogfileHandle { get; }
        public _UNICODE_STRING RealtimeLogfileName { get; }
        public _LARGE_INTEGER RealtimeWriteOffset { get; }
        public _LARGE_INTEGER RealtimeReadOffset { get; }
        public _LARGE_INTEGER RealtimeLogfileSize { get; }
        public ulong RealtimeLogfileUsage { get; }
        public ulong RealtimeMaximumFileSize { get; }
        public uint RealtimeBuffersSaved { get; }
        public _ETW_REF_CLOCK RealtimeReferenceTime { get; }
        public uint NewRTEventsLost { get; }
        public _KEVENT LoggerEvent { get; }
        public _KEVENT FlushEvent { get; }
        public _KTIMER FlushTimeOutTimer { get; }
        public _KDPC LoggerDpc { get; }
        public _KMUTANT LoggerMutex { get; }
        public _EX_PUSH_LOCK LoggerLock { get; }
        public ulong BufferListSpinLock { get; }
        public _EX_PUSH_LOCK BufferListPushLock { get; }
        public _SECURITY_CLIENT_CONTEXT ClientSecurityContext { get; }
        public IntPtr TokenAccessInformation { get; }
        public _EX_FAST_REF SecurityDescriptor { get; }
        public _LARGE_INTEGER StartTime { get; }
        public IntPtr LogFileHandle { get; }
        public long BufferSequenceNumber { get; }
        public uint Flags { get; }
        public uint Persistent { get; }
        public uint AutoLogger { get; }
        public uint FsReady { get; }
        public uint RealTime { get; }
        public uint Wow { get; }
        public uint KernelTrace { get; }
        public uint NoMoreEnable { get; }
        public uint StackTracing { get; }
        public uint ErrorLogged { get; }
        public uint RealtimeLoggerContextFreed { get; }
        public uint PebsTracing { get; }
        public uint PmcCounters { get; }
        public uint PageAlignBuffers { get; }
        public uint StackLookasideListAllocated { get; }
        public uint SecurityTrace { get; }
        public uint LastBranchTracing { get; }
        public uint SystemLoggerIndex { get; }
        public uint StackCaching { get; }
        public uint ProviderTracking { get; }
        public uint ProcessorTrace { get; }
        public uint QpcDeltaTracking { get; }
        public uint MarkerBufferSaved { get; }
        public uint LargeMdlPages { get; }
        public uint ExcludeKernelStack { get; }
        public uint BootLogger { get; }
        public uint Flags2 { get; }
        public uint UnifiedStackCaching { get; }
        public uint RequestFlag { get; }
        public uint DbgRequestNewFile { get; }
        public uint DbgRequestUpdateFile { get; }
        public uint DbgRequestFlush { get; }
        public uint DbgRequestDisableRealtime { get; }
        public uint DbgRequestDisconnectConsumer { get; }
        public uint DbgRequestConnectConsumer { get; }
        public uint DbgRequestNotifyConsumer { get; }
        public uint DbgRequestUpdateHeader { get; }
        public uint DbgRequestDeferredFlush { get; }
        public uint DbgRequestDeferredFlushTimer { get; }
        public uint DbgRequestFlushTimer { get; }
        public uint DbgRequestUpdateDebugger { get; }
        public uint DbgSpareRequestFlags { get; }
        public _ETW_STACK_TRACE_BLOCK StackTraceBlock { get; }
        public _RTL_BITMAP StackHookIdMap { get; }
        public IntPtr StackCache { get; }
        public IntPtr PmcData { get; }
        public IntPtr LbrData { get; }
        public IntPtr IptData { get; }
        public _ETW_APC_POOL ContextRegisterLoggingApcPool { get; }
        public uint ContextRegisterTypes { get; }
        public uint ContextRegisterHookCount { get; }
        public ushort[] ContextRegisterHookIdMap { get; }
        public _LIST_ENTRY BinaryTrackingList { get; }
        public IntPtr ScratchArray { get; }
        public _DISALLOWED_GUIDS DisallowedGuids { get; }
        public IntPtr PeriodicCaptureStateContext { get; }
        public IntPtr SoftRestartContext { get; }
        public IntPtr SiloState { get; }
        public _WORK_QUEUE_ITEM CompressionWorkItem { get; }
        public int CompressionWorkItemState { get; }
        public _EX_PUSH_LOCK CompressionLock { get; }
        public IntPtr CompressionTarget { get; }
        public IntPtr CompressionWorkspace { get; }
        public int CompressionOn { get; }
        public uint CompressionRatioGuess { get; }
        public uint PartialBufferCompressionLevel { get; }
        public uint CompressionResumptionMode { get; }
        public _SINGLE_LIST_ENTRY PlaceholderList { get; }
        public _KDPC CompressionDpc { get; }
        public _LARGE_INTEGER LastBufferSwitchTime { get; }
        public _LARGE_INTEGER BufferWriteDuration { get; }
        public _LARGE_INTEGER BufferCompressDuration { get; }
        public long ReferenceQpcDelta { get; }
        public IntPtr CallbackContext { get; }
        public IntPtr LastDroppedTime { get; }
        public IntPtr FlushingLastDroppedTime { get; }
        public long FlushingSequenceNumber { get; }
        public _ETW_PARTITION_CONTEXT PartitionContext { get; }
        public IntPtr BufferMdl { get; }
        public IntPtr PfnArray { get; }

        public _WMI_LOGGER_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WMI_LOGGER_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.MaximumEventSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerMode),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.AcceptNewEvents),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.GetCpuClock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerThread),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerStatus),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FailureReason),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferQueue),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.OverflowQueue),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.GlobalList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DebugIdTrackingList),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DecodeControlList),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DecodeControlCount),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BatchedBufferList),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CurrentBuffer),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerName),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LogFileName),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LogFilePattern),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.NewLogFileName),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ClockType),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LastFlushedBuffer),
                    new ulong[]
                    {
                        204UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FlushTimer),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FlushThreshold),
                    new ulong[]
                    {
                        212UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ByteOffset),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.MinimumBuffers),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BuffersAvailable),
                    new ulong[]
                    {
                        228UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.NumberOfBuffers),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.MaximumBuffers),
                    new ulong[]
                    {
                        236UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.EventsLost),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PeakBuffersCount),
                    new ulong[]
                    {
                        244UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BuffersWritten),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LogBuffersLost),
                    new ulong[]
                    {
                        252UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealTimeBuffersDelivered),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealTimeBuffersLost),
                    new ulong[]
                    {
                        260UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.SequencePtr),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LocalSequence),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.InstanceGuid),
                    new ulong[]
                    {
                        276UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.MaximumFileSize),
                    new ulong[]
                    {
                        292UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FileCounter),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PoolType),
                    new ulong[]
                    {
                        300UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ReferenceTime),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CollectionOn),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ProviderInfoSize),
                    new ulong[]
                    {
                        324UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.Consumers),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.NumConsumers),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.TransitionConsumer),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeLogfileHandle),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeLogfileName),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeWriteOffset),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeReadOffset),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeLogfileSize),
                    new ulong[]
                    {
                        400UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeLogfileUsage),
                    new ulong[]
                    {
                        408UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeMaximumFileSize),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeBuffersSaved),
                    new ulong[]
                    {
                        424UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeReferenceTime),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.NewRTEventsLost),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerEvent),
                    new ulong[]
                    {
                        456UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FlushEvent),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FlushTimeOutTimer),
                    new ulong[]
                    {
                        504UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerDpc),
                    new ulong[]
                    {
                        568UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerMutex),
                    new ulong[]
                    {
                        632UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LoggerLock),
                    new ulong[]
                    {
                        688UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferListSpinLock),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferListPushLock),
                    new ulong[]
                    {
                        696UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ClientSecurityContext),
                    new ulong[]
                    {
                        704UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.TokenAccessInformation),
                    new ulong[]
                    {
                        776UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.SecurityDescriptor),
                    new ulong[]
                    {
                        784UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StartTime),
                    new ulong[]
                    {
                        792UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LogFileHandle),
                    new ulong[]
                    {
                        800UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferSequenceNumber),
                    new ulong[]
                    {
                        808UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.Flags),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.Persistent),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.AutoLogger),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FsReady),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealTime),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.Wow),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.KernelTrace),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.NoMoreEnable),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StackTracing),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ErrorLogged),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RealtimeLoggerContextFreed),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PebsTracing),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PmcCounters),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PageAlignBuffers),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StackLookasideListAllocated),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.SecurityTrace),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LastBranchTracing),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.SystemLoggerIndex),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StackCaching),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ProviderTracking),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ProcessorTrace),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.QpcDeltaTracking),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.MarkerBufferSaved),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LargeMdlPages),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ExcludeKernelStack),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BootLogger),
                    new ulong[]
                    {
                        816UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.Flags2),
                    new ulong[]
                    {
                        820UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.UnifiedStackCaching),
                    new ulong[]
                    {
                        820UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.RequestFlag),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestNewFile),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestUpdateFile),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestFlush),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestDisableRealtime),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestDisconnectConsumer),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestConnectConsumer),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestNotifyConsumer),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestUpdateHeader),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestDeferredFlush),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestDeferredFlushTimer),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestFlushTimer),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgRequestUpdateDebugger),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DbgSpareRequestFlags),
                    new ulong[]
                    {
                        824UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StackTraceBlock),
                    new ulong[]
                    {
                        832UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StackHookIdMap),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.StackCache),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PmcData),
                    new ulong[]
                    {
                        1064UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LbrData),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.IptData),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ContextRegisterLoggingApcPool),
                    new ulong[]
                    {
                        1088UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ContextRegisterTypes),
                    new ulong[]
                    {
                        1280UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ContextRegisterHookCount),
                    new ulong[]
                    {
                        1284UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ContextRegisterHookIdMap),
                    new ulong[]
                    {
                        1288UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BinaryTrackingList),
                    new ulong[]
                    {
                        1304UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ScratchArray),
                    new ulong[]
                    {
                        1320UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.DisallowedGuids),
                    new ulong[]
                    {
                        1328UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PeriodicCaptureStateContext),
                    new ulong[]
                    {
                        1344UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.SoftRestartContext),
                    new ulong[]
                    {
                        1352UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.SiloState),
                    new ulong[]
                    {
                        1360UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionWorkItem),
                    new ulong[]
                    {
                        1368UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionWorkItemState),
                    new ulong[]
                    {
                        1400UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionLock),
                    new ulong[]
                    {
                        1408UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionTarget),
                    new ulong[]
                    {
                        1416UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionWorkspace),
                    new ulong[]
                    {
                        1424UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionOn),
                    new ulong[]
                    {
                        1432UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionRatioGuess),
                    new ulong[]
                    {
                        1436UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PartialBufferCompressionLevel),
                    new ulong[]
                    {
                        1440UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionResumptionMode),
                    new ulong[]
                    {
                        1444UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PlaceholderList),
                    new ulong[]
                    {
                        1448UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CompressionDpc),
                    new ulong[]
                    {
                        1456UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LastBufferSwitchTime),
                    new ulong[]
                    {
                        1520UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferWriteDuration),
                    new ulong[]
                    {
                        1528UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferCompressDuration),
                    new ulong[]
                    {
                        1536UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.ReferenceQpcDelta),
                    new ulong[]
                    {
                        1544UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.CallbackContext),
                    new ulong[]
                    {
                        1552UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.LastDroppedTime),
                    new ulong[]
                    {
                        1560UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FlushingLastDroppedTime),
                    new ulong[]
                    {
                        1568UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.FlushingSequenceNumber),
                    new ulong[]
                    {
                        1576UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PartitionContext),
                    new ulong[]
                    {
                        1584UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.BufferMdl),
                    new ulong[]
                    {
                        1592UL
                    }
                },
                {
                    nameof(_WMI_LOGGER_CONTEXT.PfnArray),
                    new ulong[]
                    {
                        1600UL
                    }
                }
            };
            Register<_WMI_LOGGER_CONTEXT>((mem, ptr) => new _WMI_LOGGER_CONTEXT(mem, ptr), offsets);
        }
    }
}