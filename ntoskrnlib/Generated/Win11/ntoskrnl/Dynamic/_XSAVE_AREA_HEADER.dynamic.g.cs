using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_XSAVE_AREA_HEADER")]
    public sealed class _XSAVE_AREA_HEADER : DynamicStructure
    {
        public ulong Mask { get; }
        public ulong CompactionMask { get; }
        public ulong[] Reserved2 { get; }

        public _XSAVE_AREA_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSAVE_AREA_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSAVE_AREA_HEADER.Mask),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSAVE_AREA_HEADER.CompactionMask),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_XSAVE_AREA_HEADER.Reserved2),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_XSAVE_AREA_HEADER>((mem, ptr) => new _XSAVE_AREA_HEADER(mem, ptr), offsets);
        }
    }
}