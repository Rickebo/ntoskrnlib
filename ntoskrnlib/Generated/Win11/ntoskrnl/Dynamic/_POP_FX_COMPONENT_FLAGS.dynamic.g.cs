using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_COMPONENT_FLAGS")]
    public sealed class _POP_FX_COMPONENT_FLAGS : DynamicStructure
    {
        public int Value { get; }
        public int Value2 { get; }
        public uint RefCount { get; }
        public uint Idling { get; }
        public uint Active { get; }
        public uint CriticalIdleOverride { get; }
        public uint ResidentOverride { get; }
        public uint Reserved { get; }

        public _POP_FX_COMPONENT_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_COMPONENT_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.Value2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.Idling),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.Active),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.CriticalIdleOverride),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.ResidentOverride),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_POP_FX_COMPONENT_FLAGS.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_POP_FX_COMPONENT_FLAGS>((mem, ptr) => new _POP_FX_COMPONENT_FLAGS(mem, ptr), offsets);
        }
    }
}