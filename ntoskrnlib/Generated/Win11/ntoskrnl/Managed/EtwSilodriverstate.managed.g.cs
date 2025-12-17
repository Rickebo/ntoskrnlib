using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_SILODRIVERSTATE")]
    public sealed class EtwSilodriverstate : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Silo { get => ReadHere<IntPtr>(nameof(Silo)); set => WriteHere(nameof(Silo), value); }

        [Offset(8UL)]
        public IntPtr SiloGlobals { get => ReadHere<IntPtr>(nameof(SiloGlobals)); set => WriteHere(nameof(SiloGlobals), value); }

        [Offset(16UL)]
        public uint MaxLoggers { get => ReadHere<uint>(nameof(MaxLoggers)); set => WriteHere(nameof(MaxLoggers), value); }

        [Offset(24UL)]
        public EtwGuidEntry EtwpSecurityProviderGuidEntry { get => ReadStructure<EtwGuidEntry>(nameof(EtwpSecurityProviderGuidEntry)); set => WriteStructure(nameof(EtwpSecurityProviderGuidEntry), value); }

        [Offset(448UL)]
        public IntPtr EtwpLoggerRundown { get => ReadHere<IntPtr>(nameof(EtwpLoggerRundown)); set => WriteHere(nameof(EtwpLoggerRundown), value); }

        [Offset(456UL)]
        public IntPtr EtwpLoggerContext { get => ReadHere<IntPtr>(nameof(EtwpLoggerContext)); set => WriteHere(nameof(EtwpLoggerContext), value); }

        [Offset(464UL)]
        [Length(64)]
        public DynamicArray EtwpGuidHashTable { get => ReadStructure<DynamicArray>(nameof(EtwpGuidHashTable)); set => WriteStructure(nameof(EtwpGuidHashTable), value); }

        [Offset(4048UL)]
        [Length(8)]
        public DynamicArray EtwpSecurityLoggers { get => ReadStructure<DynamicArray>(nameof(EtwpSecurityLoggers)); set => WriteStructure(nameof(EtwpSecurityLoggers), value); }

        [Offset(4064UL)]
        public byte EtwpSecurityProviderEnableMask { get => ReadHere<byte>(nameof(EtwpSecurityProviderEnableMask)); set => WriteHere(nameof(EtwpSecurityProviderEnableMask), value); }

        [Offset(4068UL)]
        public int EtwpShutdownInProgress { get => ReadHere<int>(nameof(EtwpShutdownInProgress)); set => WriteHere(nameof(EtwpShutdownInProgress), value); }

        [Offset(4072UL)]
        public uint EtwpSecurityProviderPID { get => ReadHere<uint>(nameof(EtwpSecurityProviderPID)); set => WriteHere(nameof(EtwpSecurityProviderPID), value); }

        [Offset(4080UL)]
        public EtwPrivHandleDemuxTable PrivHandleDemuxTable { get => ReadStructure<EtwPrivHandleDemuxTable>(nameof(PrivHandleDemuxTable)); set => WriteStructure(nameof(PrivHandleDemuxTable), value); }

        [Offset(4112UL)]
        public IntPtr RTBacklogFileRoot { get => ReadHere<IntPtr>(nameof(RTBacklogFileRoot)); set => WriteHere(nameof(RTBacklogFileRoot), value); }

        [Offset(4120UL)]
        public EtwCounters EtwpCounters { get => ReadStructure<EtwCounters>(nameof(EtwpCounters)); set => WriteStructure(nameof(EtwpCounters), value); }

        [Offset(4136UL)]
        public LargeInteger LogfileBytesWritten { get => ReadStructure<LargeInteger>(nameof(LogfileBytesWritten)); set => WriteStructure(nameof(LogfileBytesWritten), value); }

        [Offset(4144UL)]
        public IntPtr ProcessorBlocks { get => ReadHere<IntPtr>(nameof(ProcessorBlocks)); set => WriteHere(nameof(ProcessorBlocks), value); }

        [Offset(4152UL)]
        public IntPtr ContainerStateWnfSubscription { get => ReadHere<IntPtr>(nameof(ContainerStateWnfSubscription)); set => WriteHere(nameof(ContainerStateWnfSubscription), value); }

        [Offset(4160UL)]
        public uint ContainerStateWnfCallbackCalled { get => ReadHere<uint>(nameof(ContainerStateWnfCallbackCalled)); set => WriteHere(nameof(ContainerStateWnfCallbackCalled), value); }

        [Offset(4168UL)]
        public IntPtr UnsubscribeWorkItem { get => ReadHere<IntPtr>(nameof(UnsubscribeWorkItem)); set => WriteHere(nameof(UnsubscribeWorkItem), value); }

        [Offset(4176UL)]
        public Guid PartitionId { get => ReadStructure<Guid>(nameof(PartitionId)); set => WriteStructure(nameof(PartitionId), value); }

        [Offset(4192UL)]
        public Guid ParentId { get => ReadStructure<Guid>(nameof(ParentId)); set => WriteStructure(nameof(ParentId), value); }

        [Offset(4208UL)]
        public LargeInteger QpcOffsetFromRoot { get => ReadStructure<LargeInteger>(nameof(QpcOffsetFromRoot)); set => WriteStructure(nameof(QpcOffsetFromRoot), value); }

        [Offset(4216UL)]
        public IntPtr PartitionName { get => ReadHere<IntPtr>(nameof(PartitionName)); set => WriteHere(nameof(PartitionName), value); }

        [Offset(4224UL)]
        public ushort PartitionNameSize { get => ReadHere<ushort>(nameof(PartitionNameSize)); set => WriteHere(nameof(PartitionNameSize), value); }

        [Offset(4226UL)]
        public ushort UnusedPadding { get => ReadHere<ushort>(nameof(UnusedPadding)); set => WriteHere(nameof(UnusedPadding), value); }

        [Offset(4228UL)]
        public uint PartitionType { get => ReadHere<uint>(nameof(PartitionType)); set => WriteHere(nameof(PartitionType), value); }

        [Offset(4232UL)]
        public EtwSystemLoggerSettings SystemLoggerSettings { get => ReadStructure<EtwSystemLoggerSettings>(nameof(SystemLoggerSettings)); set => WriteStructure(nameof(SystemLoggerSettings), value); }

        [Offset(4608UL)]
        public Kmutant EtwpStartTraceMutex { get => ReadStructure<Kmutant>(nameof(EtwpStartTraceMutex)); set => WriteStructure(nameof(EtwpStartTraceMutex), value); }

        public EtwSilodriverstate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwSilodriverstate>();
        }
    }
}