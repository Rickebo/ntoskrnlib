using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!POHANDLE__")]
    public sealed class POHANDLE__ : DynamicStructure
    {
        public int unused { get; }

        public POHANDLE__(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static POHANDLE__()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(POHANDLE__.unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<POHANDLE__>((mem, ptr) => new POHANDLE__(mem, ptr), offsets);
        }
    }
}