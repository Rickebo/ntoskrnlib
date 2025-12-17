using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MM_PAGE_ACCESS_INFO")]
    public sealed class _MM_PAGE_ACCESS_INFO : DynamicStructure
    {
        public _MM_PAGE_ACCESS_INFO_FLAGS Flags { get; }
        public ulong FileOffset { get; }
        public IntPtr VirtualAddress { get; }
        public IntPtr PointerProtoPte { get; }

        public _MM_PAGE_ACCESS_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MM_PAGE_ACCESS_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MM_PAGE_ACCESS_INFO.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO.FileOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO.VirtualAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MM_PAGE_ACCESS_INFO.PointerProtoPte),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MM_PAGE_ACCESS_INFO>((mem, ptr) => new _MM_PAGE_ACCESS_INFO(mem, ptr), offsets);
        }
    }
}