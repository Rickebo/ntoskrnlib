using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KTIMER2")]
    public sealed class _KTIMER2 : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public byte[] RbNodes { get; }
        public _LIST_ENTRY ListEntry { get; }
        public ulong[] DueTime { get; }
        public long Period { get; }
        public IntPtr Callback { get; }
        public IntPtr CallbackContext { get; }
        public IntPtr DisableCallback { get; }
        public IntPtr DisableContext { get; }
        public byte AbsoluteSystemTime { get; }
        public byte TypeFlags { get; }
        public byte Unused { get; }
        public byte IdleResilient { get; }
        public byte HighResolution { get; }
        public byte NoWake { get; }
        public byte PseudoHighRes { get; }
        public byte AusterityResilient { get; }
        public byte Unused1 { get; }
        public byte[] CollectionIndex { get; }

        public _KTIMER2(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTIMER2()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTIMER2.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTIMER2.RbNodes),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTIMER2.ListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTIMER2.DueTime),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KTIMER2.Period),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KTIMER2.Callback),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KTIMER2.CallbackContext),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KTIMER2.DisableCallback),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KTIMER2.DisableContext),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KTIMER2.AbsoluteSystemTime),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KTIMER2.TypeFlags),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.Unused),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.IdleResilient),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.HighResolution),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.NoWake),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.PseudoHighRes),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.AusterityResilient),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.Unused1),
                    new ulong[]
                    {
                        129UL
                    }
                },
                {
                    nameof(_KTIMER2.CollectionIndex),
                    new ulong[]
                    {
                        130UL
                    }
                }
            };
            Register<_KTIMER2>((mem, ptr) => new _KTIMER2(mem, ptr), offsets);
        }
    }
}