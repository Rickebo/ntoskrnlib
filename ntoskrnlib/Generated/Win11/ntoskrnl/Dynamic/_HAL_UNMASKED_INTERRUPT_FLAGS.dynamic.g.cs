using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_UNMASKED_INTERRUPT_FLAGS")]
    public sealed class _HAL_UNMASKED_INTERRUPT_FLAGS : DynamicStructure
    {
        public ushort SecondaryInterrupt { get; }
        public ushort Reserved { get; }
        public ushort AsUSHORT { get; }

        public _HAL_UNMASKED_INTERRUPT_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_UNMASKED_INTERRUPT_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_FLAGS.SecondaryInterrupt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_UNMASKED_INTERRUPT_FLAGS.AsUSHORT),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HAL_UNMASKED_INTERRUPT_FLAGS>((mem, ptr) => new _HAL_UNMASKED_INTERRUPT_FLAGS(mem, ptr), offsets);
        }
    }
}