using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRACE_LOGFILE_HEADER")]
    public sealed class TraceLogfileHeader : DynamicStructure
    {
        [Offset(0UL)]
        public uint BufferSize { get => ReadHere<uint>(nameof(BufferSize)); set => WriteHere(nameof(BufferSize), value); }

        [Offset(4UL)]
        public uint Version { get => ReadHere<uint>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(4UL)]
        public UnnamedTag VersionDetail { get => ReadStructure<UnnamedTag>(nameof(VersionDetail)); set => WriteStructure(nameof(VersionDetail), value); }

        [Offset(8UL)]
        public uint ProviderVersion { get => ReadHere<uint>(nameof(ProviderVersion)); set => WriteHere(nameof(ProviderVersion), value); }

        [Offset(12UL)]
        public uint NumberOfProcessors { get => ReadHere<uint>(nameof(NumberOfProcessors)); set => WriteHere(nameof(NumberOfProcessors), value); }

        [Offset(16UL)]
        public LargeInteger EndTime { get => ReadStructure<LargeInteger>(nameof(EndTime)); set => WriteStructure(nameof(EndTime), value); }

        [Offset(24UL)]
        public uint TimerResolution { get => ReadHere<uint>(nameof(TimerResolution)); set => WriteHere(nameof(TimerResolution), value); }

        [Offset(28UL)]
        public uint MaximumFileSize { get => ReadHere<uint>(nameof(MaximumFileSize)); set => WriteHere(nameof(MaximumFileSize), value); }

        [Offset(32UL)]
        public uint LogFileMode { get => ReadHere<uint>(nameof(LogFileMode)); set => WriteHere(nameof(LogFileMode), value); }

        [Offset(36UL)]
        public uint BuffersWritten { get => ReadHere<uint>(nameof(BuffersWritten)); set => WriteHere(nameof(BuffersWritten), value); }

        [Offset(40UL)]
        public Guid LogInstanceGuid { get => ReadStructure<Guid>(nameof(LogInstanceGuid)); set => WriteStructure(nameof(LogInstanceGuid), value); }

        [Offset(40UL)]
        public uint StartBuffers { get => ReadHere<uint>(nameof(StartBuffers)); set => WriteHere(nameof(StartBuffers), value); }

        [Offset(44UL)]
        public uint PointerSize { get => ReadHere<uint>(nameof(PointerSize)); set => WriteHere(nameof(PointerSize), value); }

        [Offset(48UL)]
        public uint EventsLost { get => ReadHere<uint>(nameof(EventsLost)); set => WriteHere(nameof(EventsLost), value); }

        [Offset(52UL)]
        public uint CpuSpeedInMHz { get => ReadHere<uint>(nameof(CpuSpeedInMHz)); set => WriteHere(nameof(CpuSpeedInMHz), value); }

        [Offset(56UL)]
        public IntPtr LoggerName { get => ReadHere<IntPtr>(nameof(LoggerName)); set => WriteHere(nameof(LoggerName), value); }

        [Offset(64UL)]
        public IntPtr LogFileName { get => ReadHere<IntPtr>(nameof(LogFileName)); set => WriteHere(nameof(LogFileName), value); }

        [Offset(72UL)]
        public RtlTimeZoneInformation TimeZone { get => ReadStructure<RtlTimeZoneInformation>(nameof(TimeZone)); set => WriteStructure(nameof(TimeZone), value); }

        [Offset(248UL)]
        public LargeInteger BootTime { get => ReadStructure<LargeInteger>(nameof(BootTime)); set => WriteStructure(nameof(BootTime), value); }

        [Offset(256UL)]
        public LargeInteger PerfFreq { get => ReadStructure<LargeInteger>(nameof(PerfFreq)); set => WriteStructure(nameof(PerfFreq), value); }

        [Offset(264UL)]
        public LargeInteger StartTime { get => ReadStructure<LargeInteger>(nameof(StartTime)); set => WriteStructure(nameof(StartTime), value); }

        [Offset(272UL)]
        public uint ReservedFlags { get => ReadHere<uint>(nameof(ReservedFlags)); set => WriteHere(nameof(ReservedFlags), value); }

        [Offset(276UL)]
        public uint BuffersLost { get => ReadHere<uint>(nameof(BuffersLost)); set => WriteHere(nameof(BuffersLost), value); }

        public TraceLogfileHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TraceLogfileHeader>();
        }
    }
}