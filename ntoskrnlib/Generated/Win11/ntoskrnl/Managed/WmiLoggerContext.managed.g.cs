using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WMI_LOGGER_CONTEXT")]
    public sealed class WmiLoggerContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint LoggerId { get => ReadHere<uint>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        [Offset(4UL)]
        public uint BufferSize { get => ReadHere<uint>(nameof(BufferSize)); set => WriteHere(nameof(BufferSize), value); }

        [Offset(8UL)]
        public uint MaximumEventSize { get => ReadHere<uint>(nameof(MaximumEventSize)); set => WriteHere(nameof(MaximumEventSize), value); }

        [Offset(12UL)]
        public uint LoggerMode { get => ReadHere<uint>(nameof(LoggerMode)); set => WriteHere(nameof(LoggerMode), value); }

        [Offset(16UL)]
        public int AcceptNewEvents { get => ReadHere<int>(nameof(AcceptNewEvents)); set => WriteHere(nameof(AcceptNewEvents), value); }

        [Offset(24UL)]
        public ulong GetCpuClock { get => ReadHere<ulong>(nameof(GetCpuClock)); set => WriteHere(nameof(GetCpuClock), value); }

        [Offset(32UL)]
        public IntPtr LoggerThread { get => ReadHere<IntPtr>(nameof(LoggerThread)); set => WriteHere(nameof(LoggerThread), value); }

        [Offset(40UL)]
        public int LoggerStatus { get => ReadHere<int>(nameof(LoggerStatus)); set => WriteHere(nameof(LoggerStatus), value); }

        [Offset(44UL)]
        public uint FailureReason { get => ReadHere<uint>(nameof(FailureReason)); set => WriteHere(nameof(FailureReason), value); }

        [Offset(48UL)]
        public EtwBufferQueue BufferQueue { get => ReadStructure<EtwBufferQueue>(nameof(BufferQueue)); set => WriteStructure(nameof(BufferQueue), value); }

        [Offset(64UL)]
        public EtwBufferQueue OverflowQueue { get => ReadStructure<EtwBufferQueue>(nameof(OverflowQueue)); set => WriteStructure(nameof(OverflowQueue), value); }

        [Offset(80UL)]
        public ListEntry GlobalList { get => ReadStructure<ListEntry>(nameof(GlobalList)); set => WriteStructure(nameof(GlobalList), value); }

        [Offset(96UL)]
        public ListEntry DebugIdTrackingList { get => ReadStructure<ListEntry>(nameof(DebugIdTrackingList)); set => WriteStructure(nameof(DebugIdTrackingList), value); }

        [Offset(112UL)]
        public IntPtr DecodeControlList { get => ReadHere<IntPtr>(nameof(DecodeControlList)); set => WriteHere(nameof(DecodeControlList), value); }

        [Offset(120UL)]
        public uint DecodeControlCount { get => ReadHere<uint>(nameof(DecodeControlCount)); set => WriteHere(nameof(DecodeControlCount), value); }

        [Offset(128UL)]
        public IntPtr BatchedBufferList { get => ReadHere<IntPtr>(nameof(BatchedBufferList)); set => WriteHere(nameof(BatchedBufferList), value); }

        [Offset(128UL)]
        public ExFastRef CurrentBuffer { get => ReadStructure<ExFastRef>(nameof(CurrentBuffer)); set => WriteStructure(nameof(CurrentBuffer), value); }

        [Offset(136UL)]
        public UnicodeString LoggerName { get => ReadStructure<UnicodeString>(nameof(LoggerName)); set => WriteStructure(nameof(LoggerName), value); }

        [Offset(152UL)]
        public UnicodeString LogFileName { get => ReadStructure<UnicodeString>(nameof(LogFileName)); set => WriteStructure(nameof(LogFileName), value); }

        [Offset(168UL)]
        public UnicodeString LogFilePattern { get => ReadStructure<UnicodeString>(nameof(LogFilePattern)); set => WriteStructure(nameof(LogFilePattern), value); }

        [Offset(184UL)]
        public UnicodeString NewLogFileName { get => ReadStructure<UnicodeString>(nameof(NewLogFileName)); set => WriteStructure(nameof(NewLogFileName), value); }

        [Offset(200UL)]
        public uint ClockType { get => ReadHere<uint>(nameof(ClockType)); set => WriteHere(nameof(ClockType), value); }

        [Offset(204UL)]
        public uint LastFlushedBuffer { get => ReadHere<uint>(nameof(LastFlushedBuffer)); set => WriteHere(nameof(LastFlushedBuffer), value); }

        [Offset(208UL)]
        public uint FlushTimer { get => ReadHere<uint>(nameof(FlushTimer)); set => WriteHere(nameof(FlushTimer), value); }

        [Offset(212UL)]
        public uint FlushThreshold { get => ReadHere<uint>(nameof(FlushThreshold)); set => WriteHere(nameof(FlushThreshold), value); }

        [Offset(216UL)]
        public LargeInteger ByteOffset { get => ReadStructure<LargeInteger>(nameof(ByteOffset)); set => WriteStructure(nameof(ByteOffset), value); }

        [Offset(224UL)]
        public uint MinimumBuffers { get => ReadHere<uint>(nameof(MinimumBuffers)); set => WriteHere(nameof(MinimumBuffers), value); }

        [Offset(228UL)]
        public int BuffersAvailable { get => ReadHere<int>(nameof(BuffersAvailable)); set => WriteHere(nameof(BuffersAvailable), value); }

        [Offset(232UL)]
        public int NumberOfBuffers { get => ReadHere<int>(nameof(NumberOfBuffers)); set => WriteHere(nameof(NumberOfBuffers), value); }

        [Offset(236UL)]
        public uint MaximumBuffers { get => ReadHere<uint>(nameof(MaximumBuffers)); set => WriteHere(nameof(MaximumBuffers), value); }

        [Offset(240UL)]
        public uint EventsLost { get => ReadHere<uint>(nameof(EventsLost)); set => WriteHere(nameof(EventsLost), value); }

        [Offset(244UL)]
        public int PeakBuffersCount { get => ReadHere<int>(nameof(PeakBuffersCount)); set => WriteHere(nameof(PeakBuffersCount), value); }

        [Offset(248UL)]
        public uint BuffersWritten { get => ReadHere<uint>(nameof(BuffersWritten)); set => WriteHere(nameof(BuffersWritten), value); }

        [Offset(252UL)]
        public uint LogBuffersLost { get => ReadHere<uint>(nameof(LogBuffersLost)); set => WriteHere(nameof(LogBuffersLost), value); }

        [Offset(256UL)]
        public uint RealTimeBuffersDelivered { get => ReadHere<uint>(nameof(RealTimeBuffersDelivered)); set => WriteHere(nameof(RealTimeBuffersDelivered), value); }

        [Offset(260UL)]
        public uint RealTimeBuffersLost { get => ReadHere<uint>(nameof(RealTimeBuffersLost)); set => WriteHere(nameof(RealTimeBuffersLost), value); }

        [Offset(264UL)]
        public IntPtr SequencePtr { get => ReadHere<IntPtr>(nameof(SequencePtr)); set => WriteHere(nameof(SequencePtr), value); }

        [Offset(272UL)]
        public uint LocalSequence { get => ReadHere<uint>(nameof(LocalSequence)); set => WriteHere(nameof(LocalSequence), value); }

        [Offset(276UL)]
        public Guid InstanceGuid { get => ReadStructure<Guid>(nameof(InstanceGuid)); set => WriteStructure(nameof(InstanceGuid), value); }

        [Offset(292UL)]
        public uint MaximumFileSize { get => ReadHere<uint>(nameof(MaximumFileSize)); set => WriteHere(nameof(MaximumFileSize), value); }

        [Offset(296UL)]
        public int FileCounter { get => ReadHere<int>(nameof(FileCounter)); set => WriteHere(nameof(FileCounter), value); }

        [Offset(300UL)]
        public uint PoolType { get => ReadHere<uint>(nameof(PoolType)); set => WriteHere(nameof(PoolType), value); }

        [Offset(304UL)]
        public EtwRefClock ReferenceTime { get => ReadStructure<EtwRefClock>(nameof(ReferenceTime)); set => WriteStructure(nameof(ReferenceTime), value); }

        [Offset(320UL)]
        public int CollectionOn { get => ReadHere<int>(nameof(CollectionOn)); set => WriteHere(nameof(CollectionOn), value); }

        [Offset(324UL)]
        public uint ProviderInfoSize { get => ReadHere<uint>(nameof(ProviderInfoSize)); set => WriteHere(nameof(ProviderInfoSize), value); }

        [Offset(328UL)]
        public ListEntry Consumers { get => ReadStructure<ListEntry>(nameof(Consumers)); set => WriteStructure(nameof(Consumers), value); }

        [Offset(344UL)]
        public uint NumConsumers { get => ReadHere<uint>(nameof(NumConsumers)); set => WriteHere(nameof(NumConsumers), value); }

        [Offset(352UL)]
        public IntPtr TransitionConsumer { get => ReadHere<IntPtr>(nameof(TransitionConsumer)); set => WriteHere(nameof(TransitionConsumer), value); }

        [Offset(360UL)]
        public IntPtr RealtimeLogfileHandle { get => ReadHere<IntPtr>(nameof(RealtimeLogfileHandle)); set => WriteHere(nameof(RealtimeLogfileHandle), value); }

        [Offset(368UL)]
        public UnicodeString RealtimeLogfileName { get => ReadStructure<UnicodeString>(nameof(RealtimeLogfileName)); set => WriteStructure(nameof(RealtimeLogfileName), value); }

        [Offset(384UL)]
        public LargeInteger RealtimeWriteOffset { get => ReadStructure<LargeInteger>(nameof(RealtimeWriteOffset)); set => WriteStructure(nameof(RealtimeWriteOffset), value); }

        [Offset(392UL)]
        public LargeInteger RealtimeReadOffset { get => ReadStructure<LargeInteger>(nameof(RealtimeReadOffset)); set => WriteStructure(nameof(RealtimeReadOffset), value); }

        [Offset(400UL)]
        public LargeInteger RealtimeLogfileSize { get => ReadStructure<LargeInteger>(nameof(RealtimeLogfileSize)); set => WriteStructure(nameof(RealtimeLogfileSize), value); }

        [Offset(408UL)]
        public ulong RealtimeLogfileUsage { get => ReadHere<ulong>(nameof(RealtimeLogfileUsage)); set => WriteHere(nameof(RealtimeLogfileUsage), value); }

        [Offset(416UL)]
        public ulong RealtimeMaximumFileSize { get => ReadHere<ulong>(nameof(RealtimeMaximumFileSize)); set => WriteHere(nameof(RealtimeMaximumFileSize), value); }

        [Offset(424UL)]
        public uint RealtimeBuffersSaved { get => ReadHere<uint>(nameof(RealtimeBuffersSaved)); set => WriteHere(nameof(RealtimeBuffersSaved), value); }

        [Offset(432UL)]
        public EtwRefClock RealtimeReferenceTime { get => ReadStructure<EtwRefClock>(nameof(RealtimeReferenceTime)); set => WriteStructure(nameof(RealtimeReferenceTime), value); }

        [Offset(448UL)]
        public uint NewRTEventsLost { get => ReadHere<uint>(nameof(NewRTEventsLost)); set => WriteHere(nameof(NewRTEventsLost), value); }

        [Offset(456UL)]
        public Kevent LoggerEvent { get => ReadStructure<Kevent>(nameof(LoggerEvent)); set => WriteStructure(nameof(LoggerEvent), value); }

        [Offset(480UL)]
        public Kevent FlushEvent { get => ReadStructure<Kevent>(nameof(FlushEvent)); set => WriteStructure(nameof(FlushEvent), value); }

        [Offset(504UL)]
        public Ktimer FlushTimeOutTimer { get => ReadStructure<Ktimer>(nameof(FlushTimeOutTimer)); set => WriteStructure(nameof(FlushTimeOutTimer), value); }

        [Offset(568UL)]
        public Kdpc LoggerDpc { get => ReadStructure<Kdpc>(nameof(LoggerDpc)); set => WriteStructure(nameof(LoggerDpc), value); }

        [Offset(632UL)]
        public Kmutant LoggerMutex { get => ReadStructure<Kmutant>(nameof(LoggerMutex)); set => WriteStructure(nameof(LoggerMutex), value); }

        [Offset(688UL)]
        public ExPushLock LoggerLock { get => ReadStructure<ExPushLock>(nameof(LoggerLock)); set => WriteStructure(nameof(LoggerLock), value); }

        [Offset(696UL)]
        public ulong BufferListSpinLock { get => ReadHere<ulong>(nameof(BufferListSpinLock)); set => WriteHere(nameof(BufferListSpinLock), value); }

        [Offset(696UL)]
        public ExPushLock BufferListPushLock { get => ReadStructure<ExPushLock>(nameof(BufferListPushLock)); set => WriteStructure(nameof(BufferListPushLock), value); }

        [Offset(704UL)]
        public SecurityClientContext ClientSecurityContext { get => ReadStructure<SecurityClientContext>(nameof(ClientSecurityContext)); set => WriteStructure(nameof(ClientSecurityContext), value); }

        [Offset(776UL)]
        public IntPtr TokenAccessInformation { get => ReadHere<IntPtr>(nameof(TokenAccessInformation)); set => WriteHere(nameof(TokenAccessInformation), value); }

        [Offset(784UL)]
        public ExFastRef SecurityDescriptor { get => ReadStructure<ExFastRef>(nameof(SecurityDescriptor)); set => WriteStructure(nameof(SecurityDescriptor), value); }

        [Offset(792UL)]
        public LargeInteger StartTime { get => ReadStructure<LargeInteger>(nameof(StartTime)); set => WriteStructure(nameof(StartTime), value); }

        [Offset(800UL)]
        public IntPtr LogFileHandle { get => ReadHere<IntPtr>(nameof(LogFileHandle)); set => WriteHere(nameof(LogFileHandle), value); }

        [Offset(808UL)]
        public long BufferSequenceNumber { get => ReadHere<long>(nameof(BufferSequenceNumber)); set => WriteHere(nameof(BufferSequenceNumber), value); }

        [Offset(816UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(816UL)]
        public uint Persistent { get => ReadHere<uint>(nameof(Persistent)); set => WriteHere(nameof(Persistent), value); }

        [Offset(816UL)]
        public uint AutoLogger { get => ReadHere<uint>(nameof(AutoLogger)); set => WriteHere(nameof(AutoLogger), value); }

        [Offset(816UL)]
        public uint FsReady { get => ReadHere<uint>(nameof(FsReady)); set => WriteHere(nameof(FsReady), value); }

        [Offset(816UL)]
        public uint RealTime { get => ReadHere<uint>(nameof(RealTime)); set => WriteHere(nameof(RealTime), value); }

        [Offset(816UL)]
        public uint Wow { get => ReadHere<uint>(nameof(Wow)); set => WriteHere(nameof(Wow), value); }

        [Offset(816UL)]
        public uint KernelTrace { get => ReadHere<uint>(nameof(KernelTrace)); set => WriteHere(nameof(KernelTrace), value); }

        [Offset(816UL)]
        public uint NoMoreEnable { get => ReadHere<uint>(nameof(NoMoreEnable)); set => WriteHere(nameof(NoMoreEnable), value); }

        [Offset(816UL)]
        public uint StackTracing { get => ReadHere<uint>(nameof(StackTracing)); set => WriteHere(nameof(StackTracing), value); }

        [Offset(816UL)]
        public uint ErrorLogged { get => ReadHere<uint>(nameof(ErrorLogged)); set => WriteHere(nameof(ErrorLogged), value); }

        [Offset(816UL)]
        public uint RealtimeLoggerContextFreed { get => ReadHere<uint>(nameof(RealtimeLoggerContextFreed)); set => WriteHere(nameof(RealtimeLoggerContextFreed), value); }

        [Offset(816UL)]
        public uint PebsTracing { get => ReadHere<uint>(nameof(PebsTracing)); set => WriteHere(nameof(PebsTracing), value); }

        [Offset(816UL)]
        public uint PmcCounters { get => ReadHere<uint>(nameof(PmcCounters)); set => WriteHere(nameof(PmcCounters), value); }

        [Offset(816UL)]
        public uint PageAlignBuffers { get => ReadHere<uint>(nameof(PageAlignBuffers)); set => WriteHere(nameof(PageAlignBuffers), value); }

        [Offset(816UL)]
        public uint StackLookasideListAllocated { get => ReadHere<uint>(nameof(StackLookasideListAllocated)); set => WriteHere(nameof(StackLookasideListAllocated), value); }

        [Offset(816UL)]
        public uint SecurityTrace { get => ReadHere<uint>(nameof(SecurityTrace)); set => WriteHere(nameof(SecurityTrace), value); }

        [Offset(816UL)]
        public uint LastBranchTracing { get => ReadHere<uint>(nameof(LastBranchTracing)); set => WriteHere(nameof(LastBranchTracing), value); }

        [Offset(816UL)]
        public uint SystemLoggerIndex { get => ReadHere<uint>(nameof(SystemLoggerIndex)); set => WriteHere(nameof(SystemLoggerIndex), value); }

        [Offset(816UL)]
        public uint StackCaching { get => ReadHere<uint>(nameof(StackCaching)); set => WriteHere(nameof(StackCaching), value); }

        [Offset(816UL)]
        public uint ProviderTracking { get => ReadHere<uint>(nameof(ProviderTracking)); set => WriteHere(nameof(ProviderTracking), value); }

        [Offset(816UL)]
        public uint ProcessorTrace { get => ReadHere<uint>(nameof(ProcessorTrace)); set => WriteHere(nameof(ProcessorTrace), value); }

        [Offset(816UL)]
        public uint QpcDeltaTracking { get => ReadHere<uint>(nameof(QpcDeltaTracking)); set => WriteHere(nameof(QpcDeltaTracking), value); }

        [Offset(816UL)]
        public uint MarkerBufferSaved { get => ReadHere<uint>(nameof(MarkerBufferSaved)); set => WriteHere(nameof(MarkerBufferSaved), value); }

        [Offset(816UL)]
        public uint LargeMdlPages { get => ReadHere<uint>(nameof(LargeMdlPages)); set => WriteHere(nameof(LargeMdlPages), value); }

        [Offset(816UL)]
        public uint ExcludeKernelStack { get => ReadHere<uint>(nameof(ExcludeKernelStack)); set => WriteHere(nameof(ExcludeKernelStack), value); }

        [Offset(816UL)]
        public uint BootLogger { get => ReadHere<uint>(nameof(BootLogger)); set => WriteHere(nameof(BootLogger), value); }

        [Offset(820UL)]
        public uint Flags2 { get => ReadHere<uint>(nameof(Flags2)); set => WriteHere(nameof(Flags2), value); }

        [Offset(820UL)]
        public uint UnifiedStackCaching { get => ReadHere<uint>(nameof(UnifiedStackCaching)); set => WriteHere(nameof(UnifiedStackCaching), value); }

        [Offset(824UL)]
        public uint RequestFlag { get => ReadHere<uint>(nameof(RequestFlag)); set => WriteHere(nameof(RequestFlag), value); }

        [Offset(824UL)]
        public uint DbgRequestNewFile { get => ReadHere<uint>(nameof(DbgRequestNewFile)); set => WriteHere(nameof(DbgRequestNewFile), value); }

        [Offset(824UL)]
        public uint DbgRequestUpdateFile { get => ReadHere<uint>(nameof(DbgRequestUpdateFile)); set => WriteHere(nameof(DbgRequestUpdateFile), value); }

        [Offset(824UL)]
        public uint DbgRequestFlush { get => ReadHere<uint>(nameof(DbgRequestFlush)); set => WriteHere(nameof(DbgRequestFlush), value); }

        [Offset(824UL)]
        public uint DbgRequestDisableRealtime { get => ReadHere<uint>(nameof(DbgRequestDisableRealtime)); set => WriteHere(nameof(DbgRequestDisableRealtime), value); }

        [Offset(824UL)]
        public uint DbgRequestDisconnectConsumer { get => ReadHere<uint>(nameof(DbgRequestDisconnectConsumer)); set => WriteHere(nameof(DbgRequestDisconnectConsumer), value); }

        [Offset(824UL)]
        public uint DbgRequestConnectConsumer { get => ReadHere<uint>(nameof(DbgRequestConnectConsumer)); set => WriteHere(nameof(DbgRequestConnectConsumer), value); }

        [Offset(824UL)]
        public uint DbgRequestNotifyConsumer { get => ReadHere<uint>(nameof(DbgRequestNotifyConsumer)); set => WriteHere(nameof(DbgRequestNotifyConsumer), value); }

        [Offset(824UL)]
        public uint DbgRequestUpdateHeader { get => ReadHere<uint>(nameof(DbgRequestUpdateHeader)); set => WriteHere(nameof(DbgRequestUpdateHeader), value); }

        [Offset(824UL)]
        public uint DbgRequestDeferredFlush { get => ReadHere<uint>(nameof(DbgRequestDeferredFlush)); set => WriteHere(nameof(DbgRequestDeferredFlush), value); }

        [Offset(824UL)]
        public uint DbgRequestDeferredFlushTimer { get => ReadHere<uint>(nameof(DbgRequestDeferredFlushTimer)); set => WriteHere(nameof(DbgRequestDeferredFlushTimer), value); }

        [Offset(824UL)]
        public uint DbgRequestFlushTimer { get => ReadHere<uint>(nameof(DbgRequestFlushTimer)); set => WriteHere(nameof(DbgRequestFlushTimer), value); }

        [Offset(824UL)]
        public uint DbgRequestUpdateDebugger { get => ReadHere<uint>(nameof(DbgRequestUpdateDebugger)); set => WriteHere(nameof(DbgRequestUpdateDebugger), value); }

        [Offset(824UL)]
        public uint DbgSpareRequestFlags { get => ReadHere<uint>(nameof(DbgSpareRequestFlags)); set => WriteHere(nameof(DbgSpareRequestFlags), value); }

        [Offset(832UL)]
        public EtwStackTraceBlock StackTraceBlock { get => ReadStructure<EtwStackTraceBlock>(nameof(StackTraceBlock)); set => WriteStructure(nameof(StackTraceBlock), value); }

        [Offset(1040UL)]
        public RtlBitmap StackHookIdMap { get => ReadStructure<RtlBitmap>(nameof(StackHookIdMap)); set => WriteStructure(nameof(StackHookIdMap), value); }

        [Offset(1056UL)]
        public IntPtr StackCache { get => ReadHere<IntPtr>(nameof(StackCache)); set => WriteHere(nameof(StackCache), value); }

        [Offset(1064UL)]
        public IntPtr PmcData { get => ReadHere<IntPtr>(nameof(PmcData)); set => WriteHere(nameof(PmcData), value); }

        [Offset(1072UL)]
        public IntPtr LbrData { get => ReadHere<IntPtr>(nameof(LbrData)); set => WriteHere(nameof(LbrData), value); }

        [Offset(1080UL)]
        public IntPtr IptData { get => ReadHere<IntPtr>(nameof(IptData)); set => WriteHere(nameof(IptData), value); }

        [Offset(1088UL)]
        public EtwApcPool ContextRegisterLoggingApcPool { get => ReadStructure<EtwApcPool>(nameof(ContextRegisterLoggingApcPool)); set => WriteStructure(nameof(ContextRegisterLoggingApcPool), value); }

        [Offset(1280UL)]
        public uint ContextRegisterTypes { get => ReadHere<uint>(nameof(ContextRegisterTypes)); set => WriteHere(nameof(ContextRegisterTypes), value); }

        [Offset(1284UL)]
        public uint ContextRegisterHookCount { get => ReadHere<uint>(nameof(ContextRegisterHookCount)); set => WriteHere(nameof(ContextRegisterHookCount), value); }

        [Offset(1288UL)]
        [Length(8)]
        public DynamicArray ContextRegisterHookIdMap { get => ReadStructure<DynamicArray>(nameof(ContextRegisterHookIdMap)); set => WriteStructure(nameof(ContextRegisterHookIdMap), value); }

        [Offset(1304UL)]
        public ListEntry BinaryTrackingList { get => ReadStructure<ListEntry>(nameof(BinaryTrackingList)); set => WriteStructure(nameof(BinaryTrackingList), value); }

        [Offset(1320UL)]
        public IntPtr ScratchArray { get => ReadHere<IntPtr>(nameof(ScratchArray)); set => WriteHere(nameof(ScratchArray), value); }

        [Offset(1328UL)]
        public DisallowedGuids DisallowedGuids { get => ReadStructure<DisallowedGuids>(nameof(DisallowedGuids)); set => WriteStructure(nameof(DisallowedGuids), value); }

        [Offset(1344UL)]
        public IntPtr PeriodicCaptureStateContext { get => ReadHere<IntPtr>(nameof(PeriodicCaptureStateContext)); set => WriteHere(nameof(PeriodicCaptureStateContext), value); }

        [Offset(1352UL)]
        public IntPtr SoftRestartContext { get => ReadHere<IntPtr>(nameof(SoftRestartContext)); set => WriteHere(nameof(SoftRestartContext), value); }

        [Offset(1360UL)]
        public IntPtr SiloState { get => ReadHere<IntPtr>(nameof(SiloState)); set => WriteHere(nameof(SiloState), value); }

        [Offset(1368UL)]
        public WorkQueueItem CompressionWorkItem { get => ReadStructure<WorkQueueItem>(nameof(CompressionWorkItem)); set => WriteStructure(nameof(CompressionWorkItem), value); }

        [Offset(1400UL)]
        public int CompressionWorkItemState { get => ReadHere<int>(nameof(CompressionWorkItemState)); set => WriteHere(nameof(CompressionWorkItemState), value); }

        [Offset(1408UL)]
        public ExPushLock CompressionLock { get => ReadStructure<ExPushLock>(nameof(CompressionLock)); set => WriteStructure(nameof(CompressionLock), value); }

        [Offset(1416UL)]
        public IntPtr CompressionTarget { get => ReadHere<IntPtr>(nameof(CompressionTarget)); set => WriteHere(nameof(CompressionTarget), value); }

        [Offset(1424UL)]
        public IntPtr CompressionWorkspace { get => ReadHere<IntPtr>(nameof(CompressionWorkspace)); set => WriteHere(nameof(CompressionWorkspace), value); }

        [Offset(1432UL)]
        public int CompressionOn { get => ReadHere<int>(nameof(CompressionOn)); set => WriteHere(nameof(CompressionOn), value); }

        [Offset(1436UL)]
        public uint CompressionRatioGuess { get => ReadHere<uint>(nameof(CompressionRatioGuess)); set => WriteHere(nameof(CompressionRatioGuess), value); }

        [Offset(1440UL)]
        public uint PartialBufferCompressionLevel { get => ReadHere<uint>(nameof(PartialBufferCompressionLevel)); set => WriteHere(nameof(PartialBufferCompressionLevel), value); }

        [Offset(1444UL)]
        public uint CompressionResumptionMode { get => ReadHere<uint>(nameof(CompressionResumptionMode)); set => WriteHere(nameof(CompressionResumptionMode), value); }

        [Offset(1448UL)]
        public SingleListEntry PlaceholderList { get => ReadStructure<SingleListEntry>(nameof(PlaceholderList)); set => WriteStructure(nameof(PlaceholderList), value); }

        [Offset(1456UL)]
        public Kdpc CompressionDpc { get => ReadStructure<Kdpc>(nameof(CompressionDpc)); set => WriteStructure(nameof(CompressionDpc), value); }

        [Offset(1520UL)]
        public LargeInteger LastBufferSwitchTime { get => ReadStructure<LargeInteger>(nameof(LastBufferSwitchTime)); set => WriteStructure(nameof(LastBufferSwitchTime), value); }

        [Offset(1528UL)]
        public LargeInteger BufferWriteDuration { get => ReadStructure<LargeInteger>(nameof(BufferWriteDuration)); set => WriteStructure(nameof(BufferWriteDuration), value); }

        [Offset(1536UL)]
        public LargeInteger BufferCompressDuration { get => ReadStructure<LargeInteger>(nameof(BufferCompressDuration)); set => WriteStructure(nameof(BufferCompressDuration), value); }

        [Offset(1544UL)]
        public long ReferenceQpcDelta { get => ReadHere<long>(nameof(ReferenceQpcDelta)); set => WriteHere(nameof(ReferenceQpcDelta), value); }

        [Offset(1552UL)]
        public IntPtr CallbackContext { get => ReadHere<IntPtr>(nameof(CallbackContext)); set => WriteHere(nameof(CallbackContext), value); }

        [Offset(1560UL)]
        public IntPtr LastDroppedTime { get => ReadHere<IntPtr>(nameof(LastDroppedTime)); set => WriteHere(nameof(LastDroppedTime), value); }

        [Offset(1568UL)]
        public IntPtr FlushingLastDroppedTime { get => ReadHere<IntPtr>(nameof(FlushingLastDroppedTime)); set => WriteHere(nameof(FlushingLastDroppedTime), value); }

        [Offset(1576UL)]
        public long FlushingSequenceNumber { get => ReadHere<long>(nameof(FlushingSequenceNumber)); set => WriteHere(nameof(FlushingSequenceNumber), value); }

        [Offset(1584UL)]
        public EtwPartitionContext PartitionContext { get => ReadStructure<EtwPartitionContext>(nameof(PartitionContext)); set => WriteStructure(nameof(PartitionContext), value); }

        [Offset(1592UL)]
        public IntPtr BufferMdl { get => ReadHere<IntPtr>(nameof(BufferMdl)); set => WriteHere(nameof(BufferMdl), value); }

        [Offset(1600UL)]
        public IntPtr PfnArray { get => ReadHere<IntPtr>(nameof(PfnArray)); set => WriteHere(nameof(PfnArray), value); }

        public WmiLoggerContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WmiLoggerContext>();
        }
    }
}