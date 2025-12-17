using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BLOB_COUNTERS")]
    public sealed class _BLOB_COUNTERS : DynamicStructure
    {
        public uint CreatedObjects { get; }
        public uint DeletedObjects { get; }

        public _BLOB_COUNTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BLOB_COUNTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BLOB_COUNTERS.CreatedObjects),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BLOB_COUNTERS.DeletedObjects),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_BLOB_COUNTERS>((mem, ptr) => new _BLOB_COUNTERS(mem, ptr), offsets);
        }
    }
}