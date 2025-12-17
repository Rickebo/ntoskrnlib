using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ASYNC_READ_THREAD_STATS")]
    public sealed class _ASYNC_READ_THREAD_STATS : DynamicStructure
    {
        public uint[] CurrentLoad { get; }

        public _ASYNC_READ_THREAD_STATS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ASYNC_READ_THREAD_STATS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ASYNC_READ_THREAD_STATS.CurrentLoad),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ASYNC_READ_THREAD_STATS>((mem, ptr) => new _ASYNC_READ_THREAD_STATS(mem, ptr), offsets);
        }
    }
}