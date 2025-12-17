using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_LOCK")]
    public sealed class _WNF_LOCK : DynamicStructure
    {
        public _EX_PUSH_LOCK PushLock { get; }

        public _WNF_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_LOCK.PushLock),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WNF_LOCK>((mem, ptr) => new _WNF_LOCK(mem, ptr), offsets);
        }
    }
}