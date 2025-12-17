using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CMSI_RW_LOCK")]
    public sealed class _CMSI_RW_LOCK : DynamicStructure
    {
        public IntPtr Reserved { get; }

        public _CMSI_RW_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CMSI_RW_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CMSI_RW_LOCK.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_CMSI_RW_LOCK>((mem, ptr) => new _CMSI_RW_LOCK(mem, ptr), offsets);
        }
    }
}