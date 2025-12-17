using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_IOP_MC_BUFFER_ENTRY")]
    public sealed class _IOP_MC_BUFFER_ENTRY : DynamicStructure
    {
        public ushort Type { get; }
        public ushort Reserved { get; }
        public uint Size { get; }
        public int ReferenceCount { get; }
        public uint Flags { get; }
        public _LIST_ENTRY GlobalDataLink { get; }
        public IntPtr Address { get; }
        public uint Length { get; }
        public sbyte AccessMode { get; }
        public int MdlRef { get; }
        public IntPtr Mdl { get; }
        public _KEVENT MdlRundownEvent { get; }
        public IntPtr PfnArray { get; }
        public byte[] PageNodes { get; }

        public _IOP_MC_BUFFER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IOP_MC_BUFFER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Size),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.ReferenceCount),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.GlobalDataLink),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Address),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Length),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.AccessMode),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.MdlRef),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.Mdl),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.MdlRundownEvent),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.PfnArray),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_IOP_MC_BUFFER_ENTRY.PageNodes),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_IOP_MC_BUFFER_ENTRY>((mem, ptr) => new _IOP_MC_BUFFER_ENTRY(mem, ptr), offsets);
        }
    }
}