using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FAST_MUTEX")]
    public sealed class _FAST_MUTEX : DynamicStructure
    {
        public int Count { get; }
        public IntPtr Owner { get; }
        public uint Contention { get; }
        public _KEVENT Event { get; }
        public uint OldIrql { get; }

        public _FAST_MUTEX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FAST_MUTEX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FAST_MUTEX.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FAST_MUTEX.Owner),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FAST_MUTEX.Contention),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FAST_MUTEX.Event),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_FAST_MUTEX.OldIrql),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_FAST_MUTEX>((mem, ptr) => new _FAST_MUTEX(mem, ptr), offsets);
        }
    }
}