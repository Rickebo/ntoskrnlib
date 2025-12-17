using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!PEPHANDLE__")]
    public sealed class PEPHANDLE__ : DynamicStructure
    {
        public int unused { get; }

        public PEPHANDLE__(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static PEPHANDLE__()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(PEPHANDLE__.unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<PEPHANDLE__>((mem, ptr) => new PEPHANDLE__(mem, ptr), offsets);
        }
    }
}