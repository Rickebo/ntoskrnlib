using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MSUBSECTION")]
    public sealed class _MSUBSECTION : DynamicStructure
    {
        public _SUBSECTION Core { get; }
        public _RTL_BALANCED_NODE SubsectionNode { get; }
        public ulong NumberOfMappedViews { get; }
        public _LIST_ENTRY DereferenceList { get; }
        public uint NumberOfPfnReferences { get; }
        public uint LargeViews { get; }
        public IntPtr SubsectionExtentList { get; }
        public _MI_PROTOTYPE_PTES_NODE ProtosNode { get; }

        public _MSUBSECTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MSUBSECTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MSUBSECTION.Core),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MSUBSECTION.SubsectionNode),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MSUBSECTION.NumberOfMappedViews),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MSUBSECTION.DereferenceList),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_MSUBSECTION.NumberOfPfnReferences),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_MSUBSECTION.LargeViews),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_MSUBSECTION.SubsectionExtentList),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_MSUBSECTION.ProtosNode),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_MSUBSECTION>((mem, ptr) => new _MSUBSECTION(mem, ptr), offsets);
        }
    }
}