using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HARDWARE_PTE")]
    public sealed class _HARDWARE_PTE : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong Write { get; }
        public ulong Owner { get; }
        public ulong WriteThrough { get; }
        public ulong CacheDisable { get; }
        public ulong Accessed { get; }
        public ulong Dirty { get; }
        public ulong LargePage { get; }
        public ulong Global { get; }
        public ulong CopyOnWrite { get; }
        public ulong Prototype { get; }
        public ulong reserved0 { get; }
        public ulong PageFrameNumber { get; }
        public ulong SoftwareWsIndex { get; }
        public ulong NoExecute { get; }

        public _HARDWARE_PTE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HARDWARE_PTE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HARDWARE_PTE.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.Write),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.Owner),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.WriteThrough),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.CacheDisable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.Accessed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.Dirty),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.LargePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.Global),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.CopyOnWrite),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.reserved0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.PageFrameNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.SoftwareWsIndex),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HARDWARE_PTE.NoExecute),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_HARDWARE_PTE>((mem, ptr) => new _HARDWARE_PTE(mem, ptr), offsets);
        }
    }
}