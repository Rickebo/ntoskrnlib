using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBP_LOOKUP_CONTEXT")]
    public sealed class _OBP_LOOKUP_CONTEXT : DynamicStructure
    {
        public IntPtr Directory { get; }
        public IntPtr EntryLink { get; }
        public uint HashValue { get; }
        public byte HashIndex { get; }
        public byte LockedExclusive { get; }
        public byte DirectoryReferenced { get; }
        public byte Unused { get; }

        public _OBP_LOOKUP_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBP_LOOKUP_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBP_LOOKUP_CONTEXT.Directory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBP_LOOKUP_CONTEXT.EntryLink),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBP_LOOKUP_CONTEXT.HashValue),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_OBP_LOOKUP_CONTEXT.HashIndex),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_OBP_LOOKUP_CONTEXT.LockedExclusive),
                    new ulong[]
                    {
                        21UL
                    }
                },
                {
                    nameof(_OBP_LOOKUP_CONTEXT.DirectoryReferenced),
                    new ulong[]
                    {
                        22UL
                    }
                },
                {
                    nameof(_OBP_LOOKUP_CONTEXT.Unused),
                    new ulong[]
                    {
                        23UL
                    }
                }
            };
            Register<_OBP_LOOKUP_CONTEXT>((mem, ptr) => new _OBP_LOOKUP_CONTEXT(mem, ptr), offsets);
        }
    }
}