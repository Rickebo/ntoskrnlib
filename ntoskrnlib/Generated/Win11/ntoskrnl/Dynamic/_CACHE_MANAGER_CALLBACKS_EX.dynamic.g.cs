using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CACHE_MANAGER_CALLBACKS_EX")]
    public sealed class _CACHE_MANAGER_CALLBACKS_EX : DynamicStructure
    {
        public ushort Version { get; }
        public ushort Size { get; }
        public _CACHE_MANAGER_CALLBACK_FUNCTIONS Functions { get; }

        public _CACHE_MANAGER_CALLBACKS_EX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CACHE_MANAGER_CALLBACKS_EX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CACHE_MANAGER_CALLBACKS_EX.Version),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACKS_EX.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CACHE_MANAGER_CALLBACKS_EX.Functions),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CACHE_MANAGER_CALLBACKS_EX>((mem, ptr) => new _CACHE_MANAGER_CALLBACKS_EX(mem, ptr), offsets);
        }
    }
}