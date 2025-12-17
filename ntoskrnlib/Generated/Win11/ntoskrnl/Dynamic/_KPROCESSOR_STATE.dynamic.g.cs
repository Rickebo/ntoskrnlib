using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPROCESSOR_STATE")]
    public sealed class _KPROCESSOR_STATE : DynamicStructure
    {
        public _KSPECIAL_REGISTERS SpecialRegisters { get; }
        public _CONTEXT ContextFrame { get; }

        public _KPROCESSOR_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPROCESSOR_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPROCESSOR_STATE.SpecialRegisters),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPROCESSOR_STATE.ContextFrame),
                    new ulong[]
                    {
                        240UL
                    }
                }
            };
            Register<_KPROCESSOR_STATE>((mem, ptr) => new _KPROCESSOR_STATE(mem, ptr), offsets);
        }
    }
}