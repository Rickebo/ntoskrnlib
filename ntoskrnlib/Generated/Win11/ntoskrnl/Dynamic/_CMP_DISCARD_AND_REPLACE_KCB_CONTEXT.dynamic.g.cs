using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CMP_DISCARD_AND_REPLACE_KCB_CONTEXT")]
    public sealed class _CMP_DISCARD_AND_REPLACE_KCB_CONTEXT : DynamicStructure
    {
        public IntPtr BaseKcb { get; }
        public int PrepareStatus { get; }
        public _LIST_ENTRY ClonedKcbListHead { get; }

        public _CMP_DISCARD_AND_REPLACE_KCB_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CMP_DISCARD_AND_REPLACE_KCB_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CMP_DISCARD_AND_REPLACE_KCB_CONTEXT.BaseKcb),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CMP_DISCARD_AND_REPLACE_KCB_CONTEXT.PrepareStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CMP_DISCARD_AND_REPLACE_KCB_CONTEXT.ClonedKcbListHead),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_CMP_DISCARD_AND_REPLACE_KCB_CONTEXT>((mem, ptr) => new _CMP_DISCARD_AND_REPLACE_KCB_CONTEXT(mem, ptr), offsets);
        }
    }
}