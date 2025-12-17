using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KLOCK_QUEUE_HANDLE")]
    public sealed class KlockQueueHandle : DynamicStructure
    {
        [Offset(0UL)]
        public KspinLockQueue LockQueue { get => ReadStructure<KspinLockQueue>(nameof(LockQueue)); set => WriteStructure(nameof(LockQueue), value); }

        [Offset(16UL)]
        public byte OldIrql { get => ReadHere<byte>(nameof(OldIrql)); set => WriteHere(nameof(OldIrql), value); }

        public KlockQueueHandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KlockQueueHandle>();
        }
    }
}