using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_BCB")]
    public sealed class _BCB : DynamicStructure
    {
        public _MBCB Dummy { get; }
        public short NodeTypeCode { get; }
        public byte Dirty { get; }
        public byte Reserved { get; }
        public uint ByteLength { get; }
        public _LARGE_INTEGER FileOffset { get; }
        public _LIST_ENTRY BcbLinks { get; }
        public _LARGE_INTEGER BeyondLastByte { get; }
        public _LARGE_INTEGER OldestLsn { get; }
        public _LARGE_INTEGER NewestLsn { get; }
        public IntPtr Vacb { get; }
        public uint PinCount { get; }
        public _ERESOURCE Resource { get; }
        public IntPtr SharedCacheMap { get; }
        public IntPtr BaseAddress { get; }

        public _BCB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _BCB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_BCB.Dummy),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BCB.NodeTypeCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_BCB.Dirty),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_BCB.Reserved),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_BCB.ByteLength),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_BCB.FileOffset),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_BCB.BcbLinks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_BCB.BeyondLastByte),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_BCB.OldestLsn),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_BCB.NewestLsn),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_BCB.Vacb),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_BCB.PinCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_BCB.Resource),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_BCB.SharedCacheMap),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_BCB.BaseAddress),
                    new ulong[]
                    {
                        184UL
                    }
                }
            };
            Register<_BCB>((mem, ptr) => new _BCB(mem, ptr), offsets);
        }
    }
}