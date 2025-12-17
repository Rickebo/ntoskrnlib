using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_DYNAMIC_HASH_TABLE")]
    public sealed class _RTL_DYNAMIC_HASH_TABLE : DynamicStructure
    {
        public uint Flags { get; }
        public uint Shift { get; }
        public uint TableSize { get; }
        public uint Pivot { get; }
        public uint DivisorMask { get; }
        public uint NumEntries { get; }
        public uint NonEmptyBuckets { get; }
        public uint NumEnumerators { get; }
        public IntPtr Directory { get; }

        public _RTL_DYNAMIC_HASH_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_DYNAMIC_HASH_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.Shift),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.TableSize),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.Pivot),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.DivisorMask),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.NumEntries),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.NonEmptyBuckets),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.NumEnumerators),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_RTL_DYNAMIC_HASH_TABLE.Directory),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_RTL_DYNAMIC_HASH_TABLE>((mem, ptr) => new _RTL_DYNAMIC_HASH_TABLE(mem, ptr), offsets);
        }
    }
}