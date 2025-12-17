using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_HARDWARE")]
    public sealed class _MMPTE_HARDWARE : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong Dirty1 { get; }
        public ulong Owner { get; }
        public ulong WriteThrough { get; }
        public ulong CacheDisable { get; }
        public ulong Accessed { get; }
        public ulong Dirty { get; }
        public ulong LargePage { get; }
        public ulong Global { get; }
        public ulong CopyOnWrite { get; }
        public ulong Unused { get; }
        public ulong Write { get; }
        public ulong PageFrameNumber { get; }
        public ulong ReservedForSoftware { get; }
        public ulong WsleAge { get; }
        public ulong WsleProtection { get; }
        public ulong NoExecute { get; }

        public _MMPTE_HARDWARE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_HARDWARE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_HARDWARE.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Dirty1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Owner),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.WriteThrough),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.CacheDisable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Accessed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Dirty),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.LargePage),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Global),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.CopyOnWrite),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Unused),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.Write),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.PageFrameNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.ReservedForSoftware),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.WsleAge),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.WsleProtection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_HARDWARE.NoExecute),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_HARDWARE>((mem, ptr) => new _MMPTE_HARDWARE(mem, ptr), offsets);
        }
    }
}