using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_WNF_STATE_NAME")]
    public sealed class _WNF_STATE_NAME : DynamicStructure
    {
        public uint[] Data { get; }

        public _WNF_STATE_NAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_STATE_NAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_STATE_NAME.Data),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WNF_STATE_NAME>((mem, ptr) => new _WNF_STATE_NAME(mem, ptr), offsets);
        }
    }
}