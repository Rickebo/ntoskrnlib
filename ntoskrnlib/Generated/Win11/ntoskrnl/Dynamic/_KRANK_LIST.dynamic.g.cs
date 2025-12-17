using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KRANK_LIST")]
    public sealed class _KRANK_LIST : DynamicStructure
    {
        public byte[] Ranks { get; }
        public ulong[] AsUlong64s { get; }

        public _KRANK_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KRANK_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KRANK_LIST.Ranks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KRANK_LIST.AsUlong64s),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KRANK_LIST>((mem, ptr) => new _KRANK_LIST(mem, ptr), offsets);
        }
    }
}