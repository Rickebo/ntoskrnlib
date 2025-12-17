using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_INTENT_LOCK")]
    public sealed class _CM_INTENT_LOCK : DynamicStructure
    {
        public uint OwnerCount { get; }
        public IntPtr OwnerTable { get; }

        public _CM_INTENT_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_INTENT_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_INTENT_LOCK.OwnerCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_INTENT_LOCK.OwnerTable),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CM_INTENT_LOCK>((mem, ptr) => new _CM_INTENT_LOCK(mem, ptr), offsets);
        }
    }
}