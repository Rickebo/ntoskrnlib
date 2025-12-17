using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MCI_STATS")]
    public sealed class _MCI_STATS : DynamicStructure
    {
        public _unnamed_tag_ MciStatus { get; }
        public ulong QuadPart { get; }

        public _MCI_STATS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCI_STATS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCI_STATS.MciStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCI_STATS.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCI_STATS>((mem, ptr) => new _MCI_STATS(mem, ptr), offsets);
        }
    }
}