using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTRANSITION_STACK")]
    public sealed class _KTRANSITION_STACK : DynamicStructure
    {
        public byte[] Stack { get; }
        public byte[] IstStack { get; }
        public _KIST_BASE_FRAME IstFrame { get; }

        public _KTRANSITION_STACK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTRANSITION_STACK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTRANSITION_STACK.Stack),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTRANSITION_STACK.IstStack),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTRANSITION_STACK.IstFrame),
                    new ulong[]
                    {
                        464UL
                    }
                }
            };
            Register<_KTRANSITION_STACK>((mem, ptr) => new _KTRANSITION_STACK(mem, ptr), offsets);
        }
    }
}