using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HV_GET_BIN_CONTEXT")]
    public sealed class _HV_GET_BIN_CONTEXT : DynamicStructure
    {
        public ushort OutstandingReference { get; }

        public _HV_GET_BIN_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HV_GET_BIN_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HV_GET_BIN_CONTEXT.OutstandingReference),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HV_GET_BIN_CONTEXT>((mem, ptr) => new _HV_GET_BIN_CONTEXT(mem, ptr), offsets);
        }
    }
}