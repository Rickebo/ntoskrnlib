using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSPIN_LOCK_QUEUE")]
    public sealed class _KSPIN_LOCK_QUEUE : DynamicStructure
    {
        public IntPtr Next { get; }
        public IntPtr Lock { get; }

        public _KSPIN_LOCK_QUEUE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSPIN_LOCK_QUEUE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSPIN_LOCK_QUEUE.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSPIN_LOCK_QUEUE.Lock),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_KSPIN_LOCK_QUEUE>((mem, ptr) => new _KSPIN_LOCK_QUEUE(mem, ptr), offsets);
        }
    }
}