using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_ATOM_TABLE")]
    public sealed class _RTL_ATOM_TABLE : DynamicStructure
    {
        public uint Signature { get; }
        public int ReferenceCount { get; }
        public _EX_PUSH_LOCK PushLock { get; }
        public IntPtr ExHandleTable { get; }
        public uint Flags { get; }
        public uint NumberOfBuckets { get; }
        public byte[] Buckets { get; }

        public _RTL_ATOM_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_ATOM_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_ATOM_TABLE.Signature),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE.ReferenceCount),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE.PushLock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE.ExHandleTable),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE.NumberOfBuckets),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_RTL_ATOM_TABLE.Buckets),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_RTL_ATOM_TABLE>((mem, ptr) => new _RTL_ATOM_TABLE(mem, ptr), offsets);
        }
    }
}