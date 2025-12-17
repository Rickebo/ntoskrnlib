using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KPRIORITY_STATE")]
    public sealed class _KPRIORITY_STATE : DynamicStructure
    {
        public byte Priority { get; }
        public byte IsolationWidth { get; }
        public byte AllFields { get; }

        public _KPRIORITY_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KPRIORITY_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KPRIORITY_STATE.Priority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRIORITY_STATE.IsolationWidth),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KPRIORITY_STATE.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KPRIORITY_STATE>((mem, ptr) => new _KPRIORITY_STATE(mem, ptr), offsets);
        }
    }
}