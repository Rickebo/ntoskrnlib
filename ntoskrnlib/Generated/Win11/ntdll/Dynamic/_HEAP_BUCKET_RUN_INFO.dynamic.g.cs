using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_BUCKET_RUN_INFO")]
    public sealed class _HEAP_BUCKET_RUN_INFO : DynamicStructure
    {
        public uint Bucket { get; }
        public uint RunLength { get; }
        public long Aggregate64 { get; }

        public _HEAP_BUCKET_RUN_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_BUCKET_RUN_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_BUCKET_RUN_INFO.Bucket),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET_RUN_INFO.RunLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HEAP_BUCKET_RUN_INFO.Aggregate64),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_BUCKET_RUN_INFO>((mem, ptr) => new _HEAP_BUCKET_RUN_INFO(mem, ptr), offsets);
        }
    }
}