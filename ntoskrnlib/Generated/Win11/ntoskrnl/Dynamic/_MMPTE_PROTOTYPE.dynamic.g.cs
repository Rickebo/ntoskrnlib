using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMPTE_PROTOTYPE")]
    public sealed class _MMPTE_PROTOTYPE : DynamicStructure
    {
        public ulong Valid { get; }
        public ulong DemandFillProto { get; }
        public ulong HiberVerifyConverted { get; }
        public ulong ReadOnly { get; }
        public ulong SwizzleBit { get; }
        public ulong Protection { get; }
        public ulong Prototype { get; }
        public ulong Combined { get; }
        public ulong Unused1 { get; }
        public long ProtoAddress { get; }

        public _MMPTE_PROTOTYPE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMPTE_PROTOTYPE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMPTE_PROTOTYPE.Valid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.DemandFillProto),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.HiberVerifyConverted),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.ReadOnly),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.SwizzleBit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.Protection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.Prototype),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.Combined),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.Unused1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMPTE_PROTOTYPE.ProtoAddress),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMPTE_PROTOTYPE>((mem, ptr) => new _MMPTE_PROTOTYPE(mem, ptr), offsets);
        }
    }
}