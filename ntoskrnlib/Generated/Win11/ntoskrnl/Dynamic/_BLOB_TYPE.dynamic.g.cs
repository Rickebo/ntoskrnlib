using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BLOB_TYPE")]
    public sealed class _BLOB_TYPE : DynamicStructure
    {
        public uint ResourceId { get; }
        public uint PoolTag { get; }
        public uint LookasideIndex { get; }
        public uint Flags { get; }
        public IntPtr Counters { get; }
        public IntPtr CleanupProcedure { get; }
        public IntPtr DeleteProcedure { get; }
        public IntPtr DestroyProcedure { get; }
        public ulong UsualSize { get; }

        public _BLOB_TYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BLOB_TYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BLOB_TYPE.ResourceId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.PoolTag),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.LookasideIndex),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.Flags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.Counters),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.CleanupProcedure),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.DeleteProcedure),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.DestroyProcedure),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_BLOB_TYPE.UsualSize),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_BLOB_TYPE>((mem, ptr) => new _BLOB_TYPE(mem, ptr), offsets);
        }
    }
}