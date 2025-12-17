using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KSTACK_CONTROL")]
    public sealed class _KSTACK_CONTROL : DynamicStructure
    {
        public ulong StackBase { get; }
        public ulong ActualLimit { get; }
        public ulong StackExpansion { get; }
        public _KERNEL_STACK_SEGMENT Previous { get; }

        public _KSTACK_CONTROL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSTACK_CONTROL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSTACK_CONTROL.StackBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSTACK_CONTROL.ActualLimit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSTACK_CONTROL.StackExpansion),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSTACK_CONTROL.Previous),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_KSTACK_CONTROL>((mem, ptr) => new _KSTACK_CONTROL(mem, ptr), offsets);
        }
    }
}