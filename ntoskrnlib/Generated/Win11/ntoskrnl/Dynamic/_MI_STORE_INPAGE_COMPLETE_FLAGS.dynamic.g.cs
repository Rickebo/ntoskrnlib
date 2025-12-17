using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_STORE_INPAGE_COMPLETE_FLAGS")]
    public sealed class _MI_STORE_INPAGE_COMPLETE_FLAGS : DynamicStructure
    {
        public uint EntireFlags { get; }
        public uint StoreFault { get; }
        public uint LowResourceFailure { get; }
        public uint Spare { get; }

        public _MI_STORE_INPAGE_COMPLETE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_STORE_INPAGE_COMPLETE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_STORE_INPAGE_COMPLETE_FLAGS.EntireFlags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_STORE_INPAGE_COMPLETE_FLAGS.StoreFault),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_STORE_INPAGE_COMPLETE_FLAGS.LowResourceFailure),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_STORE_INPAGE_COMPLETE_FLAGS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_STORE_INPAGE_COMPLETE_FLAGS>((mem, ptr) => new _MI_STORE_INPAGE_COMPLETE_FLAGS(mem, ptr), offsets);
        }
    }
}