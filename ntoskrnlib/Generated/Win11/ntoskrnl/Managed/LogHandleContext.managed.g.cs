using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOG_HANDLE_CONTEXT")]
    public sealed class LogHandleContext : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr LogHandle { get => ReadHere<IntPtr>(nameof(LogHandle)); set => WriteHere(nameof(LogHandle), value); }

        [Offset(8UL)]
        public IntPtr FlushToLsnRoutine { get => ReadHere<IntPtr>(nameof(FlushToLsnRoutine)); set => WriteHere(nameof(FlushToLsnRoutine), value); }

        [Offset(16UL)]
        public IntPtr QueryLogHandleInfoRoutine { get => ReadHere<IntPtr>(nameof(QueryLogHandleInfoRoutine)); set => WriteHere(nameof(QueryLogHandleInfoRoutine), value); }

        [Offset(24UL)]
        public DirtyPageStatistics DirtyPageStatistics { get => ReadStructure<DirtyPageStatistics>(nameof(DirtyPageStatistics)); set => WriteStructure(nameof(DirtyPageStatistics), value); }

        [Offset(48UL)]
        public DirtyPageThresholds DirtyPageThresholds { get => ReadStructure<DirtyPageThresholds>(nameof(DirtyPageThresholds)); set => WriteStructure(nameof(DirtyPageThresholds), value); }

        [Offset(104UL)]
        public uint AdditionalPagesToWrite { get => ReadHere<uint>(nameof(AdditionalPagesToWrite)); set => WriteHere(nameof(AdditionalPagesToWrite), value); }

        [Offset(108UL)]
        public uint CcLWScanDPThreshold { get => ReadHere<uint>(nameof(CcLWScanDPThreshold)); set => WriteHere(nameof(CcLWScanDPThreshold), value); }

        [Offset(112UL)]
        public LargeInteger LargestLsnForCurrentLWScan { get => ReadStructure<LargeInteger>(nameof(LargestLsnForCurrentLWScan)); set => WriteStructure(nameof(LargestLsnForCurrentLWScan), value); }

        [Offset(120UL)]
        public IntPtr RelatedFileObject { get => ReadHere<IntPtr>(nameof(RelatedFileObject)); set => WriteHere(nameof(RelatedFileObject), value); }

        [Offset(128UL)]
        public ulong LargestLsnFileObjectKey { get => ReadHere<ulong>(nameof(LargestLsnFileObjectKey)); set => WriteHere(nameof(LargestLsnFileObjectKey), value); }

        [Offset(136UL)]
        public LargeInteger LastLWTimeStamp { get => ReadStructure<LargeInteger>(nameof(LastLWTimeStamp)); set => WriteStructure(nameof(LastLWTimeStamp), value); }

        [Offset(144UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public LogHandleContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LogHandleContext>();
        }
    }
}