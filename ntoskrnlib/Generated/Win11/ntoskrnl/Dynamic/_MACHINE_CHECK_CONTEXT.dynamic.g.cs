using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MACHINE_CHECK_CONTEXT")]
    public sealed class _MACHINE_CHECK_CONTEXT : DynamicStructure
    {
        public _MACHINE_FRAME MachineFrame { get; }
        public ulong Rax { get; }
        public ulong Rcx { get; }
        public ulong Rdx { get; }
        public ulong GsBase { get; }
        public ulong Cr3 { get; }

        public _MACHINE_CHECK_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MACHINE_CHECK_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MACHINE_CHECK_CONTEXT.MachineFrame),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MACHINE_CHECK_CONTEXT.Rax),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MACHINE_CHECK_CONTEXT.Rcx),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MACHINE_CHECK_CONTEXT.Rdx),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MACHINE_CHECK_CONTEXT.GsBase),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MACHINE_CHECK_CONTEXT.Cr3),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_MACHINE_CHECK_CONTEXT>((mem, ptr) => new _MACHINE_CHECK_CONTEXT(mem, ptr), offsets);
        }
    }
}