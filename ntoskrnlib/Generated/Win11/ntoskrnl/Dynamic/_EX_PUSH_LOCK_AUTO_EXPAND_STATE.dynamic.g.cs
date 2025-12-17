using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EX_PUSH_LOCK_AUTO_EXPAND_STATE")]
    public sealed class _EX_PUSH_LOCK_AUTO_EXPAND_STATE : DynamicStructure
    {
        public uint Expanded { get; }
        public uint Transitioning { get; }
        public uint Pageable { get; }
        public uint Value { get; }

        public _EX_PUSH_LOCK_AUTO_EXPAND_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EX_PUSH_LOCK_AUTO_EXPAND_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND_STATE.Expanded),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND_STATE.Transitioning),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND_STATE.Pageable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EX_PUSH_LOCK_AUTO_EXPAND_STATE.Value),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_EX_PUSH_LOCK_AUTO_EXPAND_STATE>((mem, ptr) => new _EX_PUSH_LOCK_AUTO_EXPAND_STATE(mem, ptr), offsets);
        }
    }
}