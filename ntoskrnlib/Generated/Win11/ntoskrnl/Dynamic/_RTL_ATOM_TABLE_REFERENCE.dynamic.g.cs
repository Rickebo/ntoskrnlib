using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_ATOM_TABLE_REFERENCE")]
    public sealed class _RTL_ATOM_TABLE_REFERENCE : DynamicStructure
    {
        public _LIST_ENTRY LowBoxList { get; }
        public uint LowBoxID { get; }
        public ushort ReferenceCount { get; }
        public ushort Flags { get; }

        public _RTL_ATOM_TABLE_REFERENCE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_ATOM_TABLE_REFERENCE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_ATOM_TABLE_REFERENCE.LowBoxList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_REFERENCE.LowBoxID),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_REFERENCE.ReferenceCount),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_REFERENCE.Flags),
                    new ulong[]
                    {
                        22UL
                    }
                }
            };
            Register<_RTL_ATOM_TABLE_REFERENCE>((mem, ptr) => new _RTL_ATOM_TABLE_REFERENCE(mem, ptr), offsets);
        }
    }
}