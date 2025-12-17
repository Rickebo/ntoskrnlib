using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ALPC_COMPLETION_LIST_STATE")]
    public sealed class _ALPC_COMPLETION_LIST_STATE : DynamicStructure
    {
        public _unnamed_tag_ u1 { get; }

        public _ALPC_COMPLETION_LIST_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ALPC_COMPLETION_LIST_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ALPC_COMPLETION_LIST_STATE.u1),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ALPC_COMPLETION_LIST_STATE>((mem, ptr) => new _ALPC_COMPLETION_LIST_STATE(mem, ptr), offsets);
        }
    }
}