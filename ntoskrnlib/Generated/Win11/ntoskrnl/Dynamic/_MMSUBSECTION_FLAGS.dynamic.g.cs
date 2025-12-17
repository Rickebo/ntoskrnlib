using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSUBSECTION_FLAGS")]
    public sealed class _MMSUBSECTION_FLAGS : DynamicStructure
    {
        public uint SubsectionAccessed { get; }
        public uint Protection { get; }
        public uint StartingSector4132 { get; }
        public uint SubsectionStatic { get; }
        public uint GlobalMemory { get; }
        public uint Spare { get; }
        public uint OnDereferenceList { get; }
        public uint SectorEndOffset { get; }
        public uint EntireField { get; }

        public _MMSUBSECTION_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSUBSECTION_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSUBSECTION_FLAGS.SubsectionAccessed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.StartingSector4132),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.SubsectionStatic),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.GlobalMemory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.OnDereferenceList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.SectorEndOffset),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUBSECTION_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMSUBSECTION_FLAGS>((mem, ptr) => new _MMSUBSECTION_FLAGS(mem, ptr), offsets);
        }
    }
}