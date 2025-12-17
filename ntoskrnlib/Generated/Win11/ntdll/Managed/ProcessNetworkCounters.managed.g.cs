using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PROCESS_NETWORK_COUNTERS")]
    public sealed class ProcessNetworkCounters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong BytesIn { get => ReadHere<ulong>(nameof(BytesIn)); set => WriteHere(nameof(BytesIn), value); }

        [Offset(8UL)]
        public ulong BytesOut { get => ReadHere<ulong>(nameof(BytesOut)); set => WriteHere(nameof(BytesOut), value); }

        public ProcessNetworkCounters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ProcessNetworkCounters>();
        }
    }
}