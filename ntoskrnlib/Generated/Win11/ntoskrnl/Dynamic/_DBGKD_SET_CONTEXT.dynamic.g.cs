using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_SET_CONTEXT")]
    public sealed class _DBGKD_SET_CONTEXT : DynamicStructure
    {
        public uint ContextFlags { get; }

        public _DBGKD_SET_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_SET_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_SET_CONTEXT.ContextFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_SET_CONTEXT>((mem, ptr) => new _DBGKD_SET_CONTEXT(mem, ptr), offsets);
        }
    }
}