using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_ATOM_TABLE_ENTRY")]
    public sealed class _RTL_ATOM_TABLE_ENTRY : DynamicStructure
    {
        public IntPtr HashLink { get; }
        public ushort HandleIndex { get; }
        public ushort Atom { get; }
        public _RTL_ATOM_TABLE_REFERENCE Reference { get; }
        public byte NameLength { get; }
        public short[] Name { get; }

        public _RTL_ATOM_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_ATOM_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_ATOM_TABLE_ENTRY.HashLink),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_ENTRY.HandleIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_ENTRY.Atom),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_ENTRY.Reference),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_ENTRY.NameLength),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE_ENTRY.Name),
                    new ulong[]
                    {
                        42UL
                    }
                }
            };
            Register<_RTL_ATOM_TABLE_ENTRY>((mem, ptr) => new _RTL_ATOM_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}