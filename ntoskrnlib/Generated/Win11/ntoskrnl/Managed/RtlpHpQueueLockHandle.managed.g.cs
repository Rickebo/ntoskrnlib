using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTLP_HP_QUEUE_LOCK_HANDLE")]
    public sealed class RtlpHpQueueLockHandle : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Reserved1 { get => ReadHere<ulong>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(8UL)]
        public ulong LockPtr { get => ReadHere<ulong>(nameof(LockPtr)); set => WriteHere(nameof(LockPtr), value); }

        [Offset(16UL)]
        public ulong HandleData { get => ReadHere<ulong>(nameof(HandleData)); set => WriteHere(nameof(HandleData), value); }

        public RtlpHpQueueLockHandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlpHpQueueLockHandle>();
        }
    }
}