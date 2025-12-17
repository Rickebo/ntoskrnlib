using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_HP_HEAP_VA_CALLBACKS_ENCODED")]
    public sealed class _RTL_HP_HEAP_VA_CALLBACKS_ENCODED : DynamicStructure
    {
        public ulong CallbackContext { get; }
        public ulong AllocateVirtualMemoryEncoded { get; }
        public ulong FreeVirtualMemoryEncoded { get; }
        public ulong QueryVirtualMemoryEncoded { get; }

        public _RTL_HP_HEAP_VA_CALLBACKS_ENCODED(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_HP_HEAP_VA_CALLBACKS_ENCODED()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_HP_HEAP_VA_CALLBACKS_ENCODED.CallbackContext),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_HP_HEAP_VA_CALLBACKS_ENCODED.AllocateVirtualMemoryEncoded),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_HP_HEAP_VA_CALLBACKS_ENCODED.FreeVirtualMemoryEncoded),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_HP_HEAP_VA_CALLBACKS_ENCODED.QueryVirtualMemoryEncoded),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_RTL_HP_HEAP_VA_CALLBACKS_ENCODED>((mem, ptr) => new _RTL_HP_HEAP_VA_CALLBACKS_ENCODED(mem, ptr), offsets);
        }
    }
}