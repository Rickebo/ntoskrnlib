using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CELL_DATA")]
    public sealed class _CELL_DATA : DynamicStructure
    {
        public _u u { get; }

        public _CELL_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CELL_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CELL_DATA.u),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CELL_DATA>((mem, ptr) => new _CELL_DATA(mem, ptr), offsets);
        }
    }
}