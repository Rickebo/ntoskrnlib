using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_RW_LOCK")]
    public sealed class _POP_RW_LOCK : DynamicStructure
    {
        public _EX_PUSH_LOCK Lock { get; }
        public IntPtr Thread { get; }

        public _POP_RW_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_RW_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_RW_LOCK.Lock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_RW_LOCK.Thread),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_POP_RW_LOCK>((mem, ptr) => new _POP_RW_LOCK(mem, ptr), offsets);
        }
    }
}