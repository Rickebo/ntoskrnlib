using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_XSAVE_AREA")]
    public sealed class _XSAVE_AREA : DynamicStructure
    {
        public _XSAVE_FORMAT LegacyState { get; }
        public _XSAVE_AREA_HEADER Header { get; }

        public _XSAVE_AREA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _XSAVE_AREA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_XSAVE_AREA.LegacyState),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_XSAVE_AREA.Header),
                    new ulong[]
                    {
                        512UL
                    }
                }
            };
            Register<_XSAVE_AREA>((mem, ptr) => new _XSAVE_AREA(mem, ptr), offsets);
        }
    }
}