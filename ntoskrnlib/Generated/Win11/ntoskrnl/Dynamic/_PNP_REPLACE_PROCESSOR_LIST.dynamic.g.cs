using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PNP_REPLACE_PROCESSOR_LIST")]
    public sealed class _PNP_REPLACE_PROCESSOR_LIST : DynamicStructure
    {
        public IntPtr Affinity { get; }
        public uint GroupCount { get; }
        public uint AllocatedCount { get; }
        public uint Count { get; }
        public uint[] ApicIds { get; }

        public _PNP_REPLACE_PROCESSOR_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PNP_REPLACE_PROCESSOR_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PNP_REPLACE_PROCESSOR_LIST.Affinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PNP_REPLACE_PROCESSOR_LIST.GroupCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PNP_REPLACE_PROCESSOR_LIST.AllocatedCount),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PNP_REPLACE_PROCESSOR_LIST.Count),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PNP_REPLACE_PROCESSOR_LIST.ApicIds),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_PNP_REPLACE_PROCESSOR_LIST>((mem, ptr) => new _PNP_REPLACE_PROCESSOR_LIST(mem, ptr), offsets);
        }
    }
}