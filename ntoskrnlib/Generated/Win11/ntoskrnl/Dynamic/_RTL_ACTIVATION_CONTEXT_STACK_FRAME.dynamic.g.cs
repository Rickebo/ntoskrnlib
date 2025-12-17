using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_ACTIVATION_CONTEXT_STACK_FRAME")]
    public sealed class _RTL_ACTIVATION_CONTEXT_STACK_FRAME : DynamicStructure
    {
        public IntPtr Previous { get; }
        public IntPtr ActivationContext { get; }
        public uint Flags { get; }

        public _RTL_ACTIVATION_CONTEXT_STACK_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_ACTIVATION_CONTEXT_STACK_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_ACTIVATION_CONTEXT_STACK_FRAME.Previous),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_ACTIVATION_CONTEXT_STACK_FRAME.ActivationContext),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_ACTIVATION_CONTEXT_STACK_FRAME.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_ACTIVATION_CONTEXT_STACK_FRAME>((mem, ptr) => new _RTL_ACTIVATION_CONTEXT_STACK_FRAME(mem, ptr), offsets);
        }
    }
}