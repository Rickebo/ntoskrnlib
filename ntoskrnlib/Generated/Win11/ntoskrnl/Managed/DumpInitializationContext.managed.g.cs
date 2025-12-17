using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DUMP_INITIALIZATION_CONTEXT")]
    public sealed class DumpInitializationContext : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public IntPtr MemoryBlock { get => ReadHere<IntPtr>(nameof(MemoryBlock)); set => WriteHere(nameof(MemoryBlock), value); }

        [Offset(16UL)]
        [Length(2)]
        public DynamicArray CommonBuffer { get => ReadStructure<DynamicArray>(nameof(CommonBuffer)); set => WriteStructure(nameof(CommonBuffer), value); }

        [Offset(32UL)]
        [Length(2)]
        public DynamicArray PhysicalAddress { get => ReadStructure<DynamicArray>(nameof(PhysicalAddress)); set => WriteStructure(nameof(PhysicalAddress), value); }

        [Offset(48UL)]
        public IntPtr StallRoutine { get => ReadHere<IntPtr>(nameof(StallRoutine)); set => WriteHere(nameof(StallRoutine), value); }

        [Offset(56UL)]
        public IntPtr OpenRoutine { get => ReadHere<IntPtr>(nameof(OpenRoutine)); set => WriteHere(nameof(OpenRoutine), value); }

        [Offset(64UL)]
        public IntPtr WriteRoutine { get => ReadHere<IntPtr>(nameof(WriteRoutine)); set => WriteHere(nameof(WriteRoutine), value); }

        [Offset(72UL)]
        public IntPtr FinishRoutine { get => ReadHere<IntPtr>(nameof(FinishRoutine)); set => WriteHere(nameof(FinishRoutine), value); }

        [Offset(80UL)]
        public IntPtr AdapterObject { get => ReadHere<IntPtr>(nameof(AdapterObject)); set => WriteHere(nameof(AdapterObject), value); }

        [Offset(88UL)]
        public IntPtr MappedRegisterBase { get => ReadHere<IntPtr>(nameof(MappedRegisterBase)); set => WriteHere(nameof(MappedRegisterBase), value); }

        [Offset(96UL)]
        public IntPtr PortConfiguration { get => ReadHere<IntPtr>(nameof(PortConfiguration)); set => WriteHere(nameof(PortConfiguration), value); }

        [Offset(104UL)]
        public byte CrashDump { get => ReadHere<byte>(nameof(CrashDump)); set => WriteHere(nameof(CrashDump), value); }

        [Offset(105UL)]
        public byte MarkMemoryOnly { get => ReadHere<byte>(nameof(MarkMemoryOnly)); set => WriteHere(nameof(MarkMemoryOnly), value); }

        [Offset(106UL)]
        public byte HiberResume { get => ReadHere<byte>(nameof(HiberResume)); set => WriteHere(nameof(HiberResume), value); }

        [Offset(107UL)]
        public byte InitDumpStackInvoked { get => ReadHere<byte>(nameof(InitDumpStackInvoked)); set => WriteHere(nameof(InitDumpStackInvoked), value); }

        [Offset(108UL)]
        public uint MaximumTransferSize { get => ReadHere<uint>(nameof(MaximumTransferSize)); set => WriteHere(nameof(MaximumTransferSize), value); }

        [Offset(112UL)]
        public uint CommonBufferSize { get => ReadHere<uint>(nameof(CommonBufferSize)); set => WriteHere(nameof(CommonBufferSize), value); }

        [Offset(120UL)]
        public IntPtr TargetAddress { get => ReadHere<IntPtr>(nameof(TargetAddress)); set => WriteHere(nameof(TargetAddress), value); }

        [Offset(128UL)]
        public IntPtr WritePendingRoutine { get => ReadHere<IntPtr>(nameof(WritePendingRoutine)); set => WriteHere(nameof(WritePendingRoutine), value); }

        [Offset(136UL)]
        public uint PartitionStyle { get => ReadHere<uint>(nameof(PartitionStyle)); set => WriteHere(nameof(PartitionStyle), value); }

        [Offset(140UL)]
        public UnnamedTag DiskInfo { get => ReadStructure<UnnamedTag>(nameof(DiskInfo)); set => WriteStructure(nameof(DiskInfo), value); }

        [Offset(160UL)]
        public IntPtr ReadRoutine { get => ReadHere<IntPtr>(nameof(ReadRoutine)); set => WriteHere(nameof(ReadRoutine), value); }

        [Offset(168UL)]
        public IntPtr GetDriveTelemetryRoutine { get => ReadHere<IntPtr>(nameof(GetDriveTelemetryRoutine)); set => WriteHere(nameof(GetDriveTelemetryRoutine), value); }

        [Offset(176UL)]
        public uint LogSectionTruncateSize { get => ReadHere<uint>(nameof(LogSectionTruncateSize)); set => WriteHere(nameof(LogSectionTruncateSize), value); }

        [Offset(180UL)]
        [Length(16)]
        public DynamicArray Parameters { get => ReadStructure<DynamicArray>(nameof(Parameters)); set => WriteStructure(nameof(Parameters), value); }

        [Offset(248UL)]
        public IntPtr GetTransferSizesRoutine { get => ReadHere<IntPtr>(nameof(GetTransferSizesRoutine)); set => WriteHere(nameof(GetTransferSizesRoutine), value); }

        [Offset(256UL)]
        public IntPtr DumpNotifyRoutine { get => ReadHere<IntPtr>(nameof(DumpNotifyRoutine)); set => WriteHere(nameof(DumpNotifyRoutine), value); }

        public DumpInitializationContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DumpInitializationContext>();
        }
    }
}