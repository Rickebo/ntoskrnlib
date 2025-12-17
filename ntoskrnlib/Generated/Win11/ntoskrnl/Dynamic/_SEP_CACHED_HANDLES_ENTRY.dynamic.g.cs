using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_CACHED_HANDLES_ENTRY")]
    public sealed class _SEP_CACHED_HANDLES_ENTRY : DynamicStructure
    {
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry { get; }
        public long ReferenceCount { get; }
        public _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR EntryDescriptor { get; }
        public uint HandleCount { get; }
        public IntPtr Handles { get; }

        public _SEP_CACHED_HANDLES_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_CACHED_HANDLES_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY.HashEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY.ReferenceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY.EntryDescriptor),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY.HandleCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_SEP_CACHED_HANDLES_ENTRY.Handles),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_SEP_CACHED_HANDLES_ENTRY>((mem, ptr) => new _SEP_CACHED_HANDLES_ENTRY(mem, ptr), offsets);
        }
    }
}