using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARBITER_CONFLICT_INFO")]
    public sealed class _ARBITER_CONFLICT_INFO : DynamicStructure
    {
        public IntPtr OwningObject { get; }
        public ulong Start { get; }
        public ulong End { get; }

        public _ARBITER_CONFLICT_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARBITER_CONFLICT_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARBITER_CONFLICT_INFO.OwningObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARBITER_CONFLICT_INFO.Start),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_ARBITER_CONFLICT_INFO.End),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_ARBITER_CONFLICT_INFO>((mem, ptr) => new _ARBITER_CONFLICT_INFO(mem, ptr), offsets);
        }
    }
}