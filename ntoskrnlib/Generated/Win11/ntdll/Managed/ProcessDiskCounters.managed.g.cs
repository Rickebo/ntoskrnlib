using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROCESS_DISK_COUNTERS")]
    public sealed class ProcessDiskCounters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BytesRead { get => ReadHere<ulong>(nameof(BytesRead)); set => WriteHere(nameof(BytesRead), value); }

        [Offset(8UL)]
        public ulong BytesWritten { get => ReadHere<ulong>(nameof(BytesWritten)); set => WriteHere(nameof(BytesWritten), value); }

        [Offset(16UL)]
        public ulong ReadOperationCount { get => ReadHere<ulong>(nameof(ReadOperationCount)); set => WriteHere(nameof(ReadOperationCount), value); }

        [Offset(24UL)]
        public ulong WriteOperationCount { get => ReadHere<ulong>(nameof(WriteOperationCount)); set => WriteHere(nameof(WriteOperationCount), value); }

        [Offset(32UL)]
        public ulong FlushOperationCount { get => ReadHere<ulong>(nameof(FlushOperationCount)); set => WriteHere(nameof(FlushOperationCount), value); }

        public ProcessDiskCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessDiskCounters>();
        }
    }
}