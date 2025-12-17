using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_CALL_PERFORMANCE_DATA")]
    public sealed class CallPerformanceData : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SpinLock { get => ReadHere<ulong>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(8UL)]
        [Length(64)]
        public DynamicArray HashTable { get => ReadStructure<DynamicArray>(nameof(HashTable)); set => WriteStructure(nameof(HashTable), value); }

        public CallPerformanceData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<CallPerformanceData>();
        }
    }
}