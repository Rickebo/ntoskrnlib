using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMCLONE_HEADER")]
    public sealed class _MMCLONE_HEADER : DynamicStructure
    {
        public ulong NumberOfPtes { get; }
        public ulong NumberOfProcessReferences { get; }
        public IntPtr ClonePtes { get; }
        public IntPtr Partition { get; }

        public _MMCLONE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMCLONE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMCLONE_HEADER.NumberOfPtes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMCLONE_HEADER.NumberOfProcessReferences),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MMCLONE_HEADER.ClonePtes),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MMCLONE_HEADER.Partition),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_MMCLONE_HEADER>((mem, ptr) => new _MMCLONE_HEADER(mem, ptr), offsets);
        }
    }
}