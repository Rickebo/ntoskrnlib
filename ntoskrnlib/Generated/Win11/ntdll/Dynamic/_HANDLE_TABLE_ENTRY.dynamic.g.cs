using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_HANDLE_TABLE_ENTRY")]
    public sealed class _HANDLE_TABLE_ENTRY : DynamicStructure
    {
        public long VolatileLowValue { get; }
        public long LowValue { get; }
        public IntPtr InfoTable { get; }
        public long HighValue { get; }
        public IntPtr NextFreeHandleEntry { get; }
        public _EXHANDLE LeafHandleValue { get; }
        public long RefCountField { get; }
        public ulong Unlocked { get; }
        public ulong RefCnt { get; }
        public ulong Attributes { get; }
        public ulong ObjectPointerBits { get; }
        public uint GrantedAccessBits { get; }
        public uint NoRightsUpgrade { get; }
        public uint Spare1 { get; }
        public uint Spare2 { get; }

        public _HANDLE_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_TABLE_ENTRY.VolatileLowValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.LowValue),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.InfoTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.HighValue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.NextFreeHandleEntry),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.LeafHandleValue),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.RefCountField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.Unlocked),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.RefCnt),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.Attributes),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.ObjectPointerBits),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.GrantedAccessBits),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.NoRightsUpgrade),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.Spare1),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE_ENTRY.Spare2),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_HANDLE_TABLE_ENTRY>((mem, ptr) => new _HANDLE_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}