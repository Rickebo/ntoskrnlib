using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_QUERY_SPECIAL_CALLS")]
    public sealed class _DBGKD_QUERY_SPECIAL_CALLS : DynamicStructure
    {
        public uint NumberOfSpecialCalls { get; }

        public _DBGKD_QUERY_SPECIAL_CALLS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_QUERY_SPECIAL_CALLS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_QUERY_SPECIAL_CALLS.NumberOfSpecialCalls),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_QUERY_SPECIAL_CALLS>((mem, ptr) => new _DBGKD_QUERY_SPECIAL_CALLS(mem, ptr), offsets);
        }
    }
}