using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IO_REMOVE_LOCK")]
    public sealed class _IO_REMOVE_LOCK : DynamicStructure
    {
        public _IO_REMOVE_LOCK_COMMON_BLOCK Common { get; }

        public _IO_REMOVE_LOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_REMOVE_LOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_REMOVE_LOCK.Common),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_IO_REMOVE_LOCK>((mem, ptr) => new _IO_REMOVE_LOCK(mem, ptr), offsets);
        }
    }
}