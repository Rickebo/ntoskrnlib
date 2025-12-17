using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_GET_CONTEXT")]
    public sealed class _DBGKD_GET_CONTEXT : DynamicStructure
    {
        public uint Unused { get; }

        public _DBGKD_GET_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_GET_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_GET_CONTEXT.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_GET_CONTEXT>((mem, ptr) => new _DBGKD_GET_CONTEXT(mem, ptr), offsets);
        }
    }
}