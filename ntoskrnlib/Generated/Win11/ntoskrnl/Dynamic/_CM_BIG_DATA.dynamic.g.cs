using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_BIG_DATA")]
    public sealed class _CM_BIG_DATA : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Count { get; }
        public uint List { get; }

        public _CM_BIG_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_BIG_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_BIG_DATA.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_BIG_DATA.Count),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_BIG_DATA.List),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_BIG_DATA>((mem, ptr) => new _CM_BIG_DATA(mem, ptr), offsets);
        }
    }
}