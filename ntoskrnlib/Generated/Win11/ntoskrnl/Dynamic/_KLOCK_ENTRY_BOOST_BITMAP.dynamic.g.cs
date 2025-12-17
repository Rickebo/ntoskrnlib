using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KLOCK_ENTRY_BOOST_BITMAP")]
    public sealed class _KLOCK_ENTRY_BOOST_BITMAP : DynamicStructure
    {
        public ulong AllFields { get; }
        public uint AllBoosts { get; }
        public uint WaiterCounts { get; }
        public uint CpuBoostsBitmap { get; }
        public uint IoBoost { get; }
        public uint IoQoSBoost { get; }
        public uint IoNormalPriorityWaiterCount { get; }
        public uint IoQoSWaiterCount { get; }

        public _KLOCK_ENTRY_BOOST_BITMAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KLOCK_ENTRY_BOOST_BITMAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.AllFields),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.AllBoosts),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.WaiterCounts),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.CpuBoostsBitmap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.IoBoost),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.IoQoSBoost),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.IoNormalPriorityWaiterCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_KLOCK_ENTRY_BOOST_BITMAP.IoQoSWaiterCount),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_KLOCK_ENTRY_BOOST_BITMAP>((mem, ptr) => new _KLOCK_ENTRY_BOOST_BITMAP(mem, ptr), offsets);
        }
    }
}