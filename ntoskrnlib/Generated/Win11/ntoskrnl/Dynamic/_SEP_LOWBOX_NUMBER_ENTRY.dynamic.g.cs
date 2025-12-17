using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SEP_LOWBOX_NUMBER_ENTRY")]
    public sealed class _SEP_LOWBOX_NUMBER_ENTRY : DynamicStructure
    {
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry { get; }
        public long ReferenceCount { get; }
        public IntPtr PackageSid { get; }
        public uint LowboxNumber { get; }
        public IntPtr AtomTable { get; }

        public _SEP_LOWBOX_NUMBER_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SEP_LOWBOX_NUMBER_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SEP_LOWBOX_NUMBER_ENTRY.HashEntry),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_ENTRY.ReferenceCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_ENTRY.PackageSid),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_ENTRY.LowboxNumber),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_SEP_LOWBOX_NUMBER_ENTRY.AtomTable),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_SEP_LOWBOX_NUMBER_ENTRY>((mem, ptr) => new _SEP_LOWBOX_NUMBER_ENTRY(mem, ptr), offsets);
        }
    }
}