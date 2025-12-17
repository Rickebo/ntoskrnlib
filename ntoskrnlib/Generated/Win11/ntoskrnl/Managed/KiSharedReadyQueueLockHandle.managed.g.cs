using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KI_SHARED_READY_QUEUE_LOCK_HANDLE")]
    public sealed class KiSharedReadyQueueLockHandle : DynamicStructure
    {
        [Offset(0UL)]
        public KspinLockQueue Queue { get => ReadStructure<KspinLockQueue>(nameof(Queue)); set => WriteStructure(nameof(Queue), value); }

        public KiSharedReadyQueueLockHandle(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KiSharedReadyQueueLockHandle>();
        }
    }
}