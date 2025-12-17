using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_OWNER_ENTRY")]
    public sealed class _OWNER_ENTRY : DynamicStructure
    {
        public ulong OwnerThread { get; }
        public uint IoPriorityBoosted { get; }
        public uint OwnerReferenced { get; }
        public uint IoQoSPriorityBoosted { get; }
        public uint OwnerCount { get; }
        public uint TableSize { get; }

        public _OWNER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OWNER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OWNER_ENTRY.OwnerThread),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OWNER_ENTRY.IoPriorityBoosted),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OWNER_ENTRY.OwnerReferenced),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OWNER_ENTRY.IoQoSPriorityBoosted),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OWNER_ENTRY.OwnerCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OWNER_ENTRY.TableSize),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_OWNER_ENTRY>((mem, ptr) => new _OWNER_ENTRY(mem, ptr), offsets);
        }
    }
}