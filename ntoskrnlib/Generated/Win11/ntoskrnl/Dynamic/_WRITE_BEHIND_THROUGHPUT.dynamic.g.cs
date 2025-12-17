using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WRITE_BEHIND_THROUGHPUT")]
    public sealed class _WRITE_BEHIND_THROUGHPUT : DynamicStructure
    {
        public uint PagesYetToWrite { get; }
        public uint Throughput { get; }

        public _WRITE_BEHIND_THROUGHPUT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WRITE_BEHIND_THROUGHPUT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WRITE_BEHIND_THROUGHPUT.PagesYetToWrite),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WRITE_BEHIND_THROUGHPUT.Throughput),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_WRITE_BEHIND_THROUGHPUT>((mem, ptr) => new _WRITE_BEHIND_THROUGHPUT(mem, ptr), offsets);
        }
    }
}