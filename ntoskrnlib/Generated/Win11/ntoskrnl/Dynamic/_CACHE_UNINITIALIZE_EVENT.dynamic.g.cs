using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CACHE_UNINITIALIZE_EVENT")]
    public sealed class _CACHE_UNINITIALIZE_EVENT : DynamicStructure
    {
        public IntPtr Next { get; }
        public _KEVENT Event { get; }

        public _CACHE_UNINITIALIZE_EVENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CACHE_UNINITIALIZE_EVENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CACHE_UNINITIALIZE_EVENT.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CACHE_UNINITIALIZE_EVENT.Event),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CACHE_UNINITIALIZE_EVENT>((mem, ptr) => new _CACHE_UNINITIALIZE_EVENT(mem, ptr), offsets);
        }
    }
}