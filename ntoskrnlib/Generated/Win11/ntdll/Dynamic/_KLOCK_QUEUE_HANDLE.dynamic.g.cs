using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KLOCK_QUEUE_HANDLE")]
    public sealed class _KLOCK_QUEUE_HANDLE : DynamicStructure
    {
        public _KSPIN_LOCK_QUEUE LockQueue { get; }
        public byte OldIrql { get; }

        public _KLOCK_QUEUE_HANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLOCK_QUEUE_HANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLOCK_QUEUE_HANDLE.LockQueue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_QUEUE_HANDLE.OldIrql),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KLOCK_QUEUE_HANDLE>((mem, ptr) => new _KLOCK_QUEUE_HANDLE(mem, ptr), offsets);
        }
    }
}