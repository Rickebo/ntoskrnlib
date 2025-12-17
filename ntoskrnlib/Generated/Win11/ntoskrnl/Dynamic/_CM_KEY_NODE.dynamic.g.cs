using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CM_KEY_NODE")]
    public sealed class _CM_KEY_NODE : DynamicStructure
    {
        public ushort Signature { get; }
        public ushort Flags { get; }
        public _LARGE_INTEGER LastWriteTime { get; }
        public byte AccessBits { get; }
        public byte LayerSemantics { get; }
        public byte Spare1 { get; }
        public byte InheritClass { get; }
        public ushort Spare2 { get; }
        public uint Parent { get; }
        public uint[] SubKeyCounts { get; }
        public uint[] SubKeyLists { get; }
        public _CHILD_LIST ValueList { get; }
        public _CM_KEY_REFERENCE ChildHiveReference { get; }
        public uint Security { get; }
        public uint Class { get; }
        public uint MaxNameLen { get; }
        public uint UserFlags { get; }
        public uint VirtControlFlags { get; }
        public uint Debug { get; }
        public uint MaxClassLen { get; }
        public uint MaxValueNameLen { get; }
        public uint MaxValueDataLen { get; }
        public uint WorkVar { get; }
        public ushort NameLength { get; }
        public ushort ClassLength { get; }
        public short[] Name { get; }

        public _CM_KEY_NODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CM_KEY_NODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CM_KEY_NODE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Flags),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.LastWriteTime),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.AccessBits),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.LayerSemantics),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Spare1),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.InheritClass),
                    new ulong[]
                    {
                        13UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Spare2),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Parent),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.SubKeyCounts),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.SubKeyLists),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.ValueList),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.ChildHiveReference),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Security),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Class),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.MaxNameLen),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.UserFlags),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.VirtControlFlags),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Debug),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.MaxClassLen),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.MaxValueNameLen),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.MaxValueDataLen),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.WorkVar),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.NameLength),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.ClassLength),
                    new ulong[]
                    {
                        74UL
                    }
                },
                {
                    nameof(_CM_KEY_NODE.Name),
                    new ulong[]
                    {
                        76UL
                    }
                }
            };
            Register<_CM_KEY_NODE>((mem, ptr) => new _CM_KEY_NODE(mem, ptr), offsets);
        }
    }
}