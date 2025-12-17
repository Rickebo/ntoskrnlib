using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CALL_PERFORMANCE_DATA")]
    public sealed class _CALL_PERFORMANCE_DATA : DynamicStructure
    {
        public ulong SpinLock { get; }
        public byte[] HashTable { get; }

        public _CALL_PERFORMANCE_DATA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CALL_PERFORMANCE_DATA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CALL_PERFORMANCE_DATA.SpinLock),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CALL_PERFORMANCE_DATA.HashTable),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_CALL_PERFORMANCE_DATA>((mem, ptr) => new _CALL_PERFORMANCE_DATA(mem, ptr), offsets);
        }
    }
}