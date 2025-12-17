using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KERNEL_STACK_SEGMENT")]
    public sealed class _KERNEL_STACK_SEGMENT : DynamicStructure
    {
        public ulong StackBase { get; }
        public ulong StackLimit { get; }
        public ulong KernelStack { get; }
        public ulong InitialStack { get; }
        public ulong KernelShadowStackBase { get; }
        public _KERNEL_SHADOW_STACK_LIMIT KernelShadowStackLimit { get; }
        public ulong KernelShadowStack { get; }
        public ulong KernelShadowStackInitial { get; }

        public _KERNEL_STACK_SEGMENT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KERNEL_STACK_SEGMENT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KERNEL_STACK_SEGMENT.StackBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.StackLimit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.KernelStack),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.InitialStack),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.KernelShadowStackBase),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.KernelShadowStackLimit),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.KernelShadowStack),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KERNEL_STACK_SEGMENT.KernelShadowStackInitial),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_KERNEL_STACK_SEGMENT>((mem, ptr) => new _KERNEL_STACK_SEGMENT(mem, ptr), offsets);
        }
    }
}