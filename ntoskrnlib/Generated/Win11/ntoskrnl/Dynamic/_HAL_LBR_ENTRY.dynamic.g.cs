using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HAL_LBR_ENTRY")]
    public sealed class _HAL_LBR_ENTRY : DynamicStructure
    {
        public IntPtr FromAddress { get; }
        public IntPtr ToAddress { get; }
        public IntPtr Information { get; }

        public _HAL_LBR_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HAL_LBR_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HAL_LBR_ENTRY.FromAddress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HAL_LBR_ENTRY.ToAddress),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HAL_LBR_ENTRY.Information),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_HAL_LBR_ENTRY>((mem, ptr) => new _HAL_LBR_ENTRY(mem, ptr), offsets);
        }
    }
}