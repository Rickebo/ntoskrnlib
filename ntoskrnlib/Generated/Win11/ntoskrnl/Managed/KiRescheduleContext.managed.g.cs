using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_RESCHEDULE_CONTEXT")]
    public sealed class KiRescheduleContext : DynamicStructure
    {
        [Offset(0UL)]
        public byte ProcessorCount { get => ReadHere<byte>(nameof(ProcessorCount)); set => WriteHere(nameof(ProcessorCount), value); }

        [Offset(1UL)]
        public byte ScanStart { get => ReadHere<byte>(nameof(ScanStart)); set => WriteHere(nameof(ScanStart), value); }

        [Offset(4UL)]
        public uint MaximumThreadIsolationWidth { get => ReadHere<uint>(nameof(MaximumThreadIsolationWidth)); set => WriteHere(nameof(MaximumThreadIsolationWidth), value); }

        [Offset(8UL)]
        public uint IsolationWidth { get => ReadHere<uint>(nameof(IsolationWidth)); set => WriteHere(nameof(IsolationWidth), value); }

        [Offset(16UL)]
        [Length(4)]
        public DynamicArray ProcessorEntries { get => ReadStructure<DynamicArray>(nameof(ProcessorEntries)); set => WriteStructure(nameof(ProcessorEntries), value); }

        [Offset(176UL)]
        [Length(4)]
        public DynamicArray SharedReadyLockQueues { get => ReadStructure<DynamicArray>(nameof(SharedReadyLockQueues)); set => WriteStructure(nameof(SharedReadyLockQueues), value); }

        public KiRescheduleContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiRescheduleContext>();
        }
    }
}