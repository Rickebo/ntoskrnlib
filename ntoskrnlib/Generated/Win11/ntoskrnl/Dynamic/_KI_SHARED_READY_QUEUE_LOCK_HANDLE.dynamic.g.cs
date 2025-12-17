using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KI_SHARED_READY_QUEUE_LOCK_HANDLE")]
    public sealed class _KI_SHARED_READY_QUEUE_LOCK_HANDLE : DynamicStructure
    {
        public _KSPIN_LOCK_QUEUE Queue { get; }

        public _KI_SHARED_READY_QUEUE_LOCK_HANDLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KI_SHARED_READY_QUEUE_LOCK_HANDLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KI_SHARED_READY_QUEUE_LOCK_HANDLE.Queue),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KI_SHARED_READY_QUEUE_LOCK_HANDLE>((mem, ptr) => new _KI_SHARED_READY_QUEUE_LOCK_HANDLE(mem, ptr), offsets);
        }
    }
}