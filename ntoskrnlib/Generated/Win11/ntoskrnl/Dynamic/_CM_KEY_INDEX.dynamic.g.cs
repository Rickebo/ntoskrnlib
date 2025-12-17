using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_INDEX")]
    public sealed class _CM_KEY_INDEX : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Count { get; }
        public uint[] List { get; }

        public _CM_KEY_INDEX(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_INDEX()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_INDEX.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_INDEX.Count),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_KEY_INDEX.List),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_CM_KEY_INDEX>((mem, ptr) => new _CM_KEY_INDEX(mem, ptr), offsets);
        }
    }
}