using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NLS_DATA_BLOCK")]
    public sealed class _NLS_DATA_BLOCK : DynamicStructure
    {
        public IntPtr AnsiCodePageData { get; }
        public IntPtr OemCodePageData { get; }
        public IntPtr UnicodeCaseTableData { get; }

        public _NLS_DATA_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NLS_DATA_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NLS_DATA_BLOCK.AnsiCodePageData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NLS_DATA_BLOCK.OemCodePageData),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NLS_DATA_BLOCK.UnicodeCaseTableData),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_NLS_DATA_BLOCK>((mem, ptr) => new _NLS_DATA_BLOCK(mem, ptr), offsets);
        }
    }
}