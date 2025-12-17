using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBJECT_REF_STACK_INFO")]
    public sealed class _OBJECT_REF_STACK_INFO : DynamicStructure
    {
        public uint Sequence { get; }
        public ushort Index { get; }
        public ushort NumTraces { get; }
        public uint Tag { get; }

        public _OBJECT_REF_STACK_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBJECT_REF_STACK_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBJECT_REF_STACK_INFO.Sequence),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBJECT_REF_STACK_INFO.Index),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_OBJECT_REF_STACK_INFO.NumTraces),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_OBJECT_REF_STACK_INFO.Tag),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OBJECT_REF_STACK_INFO>((mem, ptr) => new _OBJECT_REF_STACK_INFO(mem, ptr), offsets);
        }
    }
}