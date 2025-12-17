using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_RUNDOWN_REF")]
    public sealed class _EX_RUNDOWN_REF : DynamicStructure
    {
        public ulong Count { get; }
        public IntPtr Ptr { get; }

        public _EX_RUNDOWN_REF(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_RUNDOWN_REF()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_RUNDOWN_REF.Count),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_RUNDOWN_REF.Ptr),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EX_RUNDOWN_REF>((mem, ptr) => new _EX_RUNDOWN_REF(mem, ptr), offsets);
        }
    }
}