using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HEAP_LFH_COMMIT_UNIT_INFO")]
    public sealed class _HEAP_LFH_COMMIT_UNIT_INFO : DynamicStructure
    {
        public byte CommitUnitShift { get; }
        public byte CommitUnitCount { get; }
        public ushort UShort { get; }

        public _HEAP_LFH_COMMIT_UNIT_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HEAP_LFH_COMMIT_UNIT_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HEAP_LFH_COMMIT_UNIT_INFO.CommitUnitShift),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HEAP_LFH_COMMIT_UNIT_INFO.CommitUnitCount),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_HEAP_LFH_COMMIT_UNIT_INFO.UShort),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HEAP_LFH_COMMIT_UNIT_INFO>((mem, ptr) => new _HEAP_LFH_COMMIT_UNIT_INFO(mem, ptr), offsets);
        }
    }
}