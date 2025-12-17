using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KMUTANT")]
    public sealed class _KMUTANT : DynamicStructure
    {
        public _DISPATCHER_HEADER Header { get; }
        public _LIST_ENTRY MutantListEntry { get; }
        public IntPtr OwnerThread { get; }
        public byte MutantFlags { get; }
        public byte Abandoned { get; }
        public byte Spare1 { get; }
        public byte Abandoned2 { get; }
        public byte AbEnabled { get; }
        public byte Spare2 { get; }
        public byte ApcDisable { get; }

        public _KMUTANT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KMUTANT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KMUTANT.Header),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KMUTANT.MutantListEntry),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KMUTANT.OwnerThread),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KMUTANT.MutantFlags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KMUTANT.Abandoned),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KMUTANT.Spare1),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KMUTANT.Abandoned2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KMUTANT.AbEnabled),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KMUTANT.Spare2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KMUTANT.ApcDisable),
                    new ulong[]
                    {
                        49UL
                    }
                }
            };
            Register<_KMUTANT>((mem, ptr) => new _KMUTANT(mem, ptr), offsets);
        }
    }
}