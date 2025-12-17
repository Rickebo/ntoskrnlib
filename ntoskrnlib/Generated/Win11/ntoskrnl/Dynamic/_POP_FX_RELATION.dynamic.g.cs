using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_RELATION")]
    public sealed class _POP_FX_RELATION : DynamicStructure
    {
        public uint RelationType { get; }
        public ulong RelationLock { get; }
        public _unnamed_tag_ Flags { get; }
        public IntPtr ParentComponent { get; }
        public _LIST_ENTRY ParentLink { get; }
        public IntPtr ChildRelationLock { get; }
        public _LIST_ENTRY ChildLink { get; }

        public _POP_FX_RELATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_RELATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_RELATION.RelationType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_RELATION.RelationLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_FX_RELATION.Flags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_RELATION.ParentComponent),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_RELATION.ParentLink),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_RELATION.ChildRelationLock),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_FX_RELATION.ChildLink),
                    new ulong[]
                    {
                        56UL
                    }
                }
            };
            Register<_POP_FX_RELATION>((mem, ptr) => new _POP_FX_RELATION(mem, ptr), offsets);
        }
    }
}