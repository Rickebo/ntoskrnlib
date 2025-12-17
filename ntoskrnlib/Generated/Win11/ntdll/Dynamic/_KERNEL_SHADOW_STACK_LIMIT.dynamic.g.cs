using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KERNEL_SHADOW_STACK_LIMIT")]
    public sealed class _KERNEL_SHADOW_STACK_LIMIT : DynamicStructure
    {
        public ulong AllFields { get; }
        public ulong ShadowStackType { get; }
        public ulong Unused { get; }
        public ulong ShadowStackLimitPfn { get; }

        public _KERNEL_SHADOW_STACK_LIMIT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KERNEL_SHADOW_STACK_LIMIT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KERNEL_SHADOW_STACK_LIMIT.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KERNEL_SHADOW_STACK_LIMIT.ShadowStackType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KERNEL_SHADOW_STACK_LIMIT.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KERNEL_SHADOW_STACK_LIMIT.ShadowStackLimitPfn),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KERNEL_SHADOW_STACK_LIMIT>((mem, ptr) => new _KERNEL_SHADOW_STACK_LIMIT(mem, ptr), offsets);
        }
    }
}