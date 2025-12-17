using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_SUBALLOCATOR_CALLBACKS")]
    public sealed class _HEAP_SUBALLOCATOR_CALLBACKS : DynamicStructure
    {
        public ulong Allocate { get; }
        public ulong Free { get; }
        public ulong Commit { get; }
        public ulong Decommit { get; }
        public ulong ExtendContext { get; }
        public ulong TlsCleanup { get; }

        public _HEAP_SUBALLOCATOR_CALLBACKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_SUBALLOCATOR_CALLBACKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_SUBALLOCATOR_CALLBACKS.Allocate),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_SUBALLOCATOR_CALLBACKS.Free),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HEAP_SUBALLOCATOR_CALLBACKS.Commit),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HEAP_SUBALLOCATOR_CALLBACKS.Decommit),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HEAP_SUBALLOCATOR_CALLBACKS.ExtendContext),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_HEAP_SUBALLOCATOR_CALLBACKS.TlsCleanup),
                    new ulong[]
                    {
                        40UL
                    }
                }
            };
            Register<_HEAP_SUBALLOCATOR_CALLBACKS>((mem, ptr) => new _HEAP_SUBALLOCATOR_CALLBACKS(mem, ptr), offsets);
        }
    }
}