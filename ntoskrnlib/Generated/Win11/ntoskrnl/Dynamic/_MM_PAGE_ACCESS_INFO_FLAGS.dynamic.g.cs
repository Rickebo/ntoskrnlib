using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_PAGE_ACCESS_INFO_FLAGS")]
    public sealed class _MM_PAGE_ACCESS_INFO_FLAGS : DynamicStructure
    {
        public _unnamed_tag_ File { get; }
        public _unnamed_tag_ Private { get; }

        public _MM_PAGE_ACCESS_INFO_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_PAGE_ACCESS_INFO_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_PAGE_ACCESS_INFO_FLAGS.File),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO_FLAGS.Private),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MM_PAGE_ACCESS_INFO_FLAGS>((mem, ptr) => new _MM_PAGE_ACCESS_INFO_FLAGS(mem, ptr), offsets);
        }
    }
}