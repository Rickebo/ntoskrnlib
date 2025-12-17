using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMCLONE_DESCRIPTOR")]
    public sealed class _MMCLONE_DESCRIPTOR : DynamicStructure
    {
        public _RTL_BALANCED_NODE CloneNode { get; }
        public IntPtr Next { get; }
        public IntPtr StartingCloneBlock { get; }
        public IntPtr EndingCloneBlock { get; }
        public ulong NumberOfPtes { get; }
        public ulong NumberOfReferences { get; }
        public IntPtr CloneHeader { get; }
        public ulong NonPagedPoolQuotaCharge { get; }
        public _SLIST_ENTRY DeleteList { get; }
        public ulong NestingLevel { get; }

        public _MMCLONE_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMCLONE_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMCLONE_DESCRIPTOR.CloneNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.StartingCloneBlock),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.EndingCloneBlock),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.NumberOfPtes),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.NumberOfReferences),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.CloneHeader),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.NonPagedPoolQuotaCharge),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.DeleteList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_MMCLONE_DESCRIPTOR.NestingLevel),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_MMCLONE_DESCRIPTOR>((mem, ptr) => new _MMCLONE_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}