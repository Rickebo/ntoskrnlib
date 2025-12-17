using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HV_GET_CELL_CONTEXT")]
    public sealed class _HV_GET_CELL_CONTEXT : DynamicStructure
    {
        public uint Cell { get; }
        public _HV_GET_BIN_CONTEXT BinContext { get; }

        public _HV_GET_CELL_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HV_GET_CELL_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HV_GET_CELL_CONTEXT.Cell),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HV_GET_CELL_CONTEXT.BinContext),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_HV_GET_CELL_CONTEXT>((mem, ptr) => new _HV_GET_CELL_CONTEXT(mem, ptr), offsets);
        }
    }
}