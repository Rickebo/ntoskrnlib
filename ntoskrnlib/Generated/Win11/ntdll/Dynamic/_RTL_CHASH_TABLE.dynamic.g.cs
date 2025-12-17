using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_CHASH_TABLE")]
    public sealed class _RTL_CHASH_TABLE : DynamicStructure
    {
        public IntPtr Table { get; }
        public uint EntrySizeShift { get; }
        public uint EntryMax { get; }
        public uint EntryCount { get; }

        public _RTL_CHASH_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_CHASH_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_CHASH_TABLE.Table),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_CHASH_TABLE.EntrySizeShift),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_CHASH_TABLE.EntryMax),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_RTL_CHASH_TABLE.EntryCount),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_RTL_CHASH_TABLE>((mem, ptr) => new _RTL_CHASH_TABLE(mem, ptr), offsets);
        }
    }
}