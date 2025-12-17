using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_ARM64_FPCR_REG")]
    public sealed class _ARM64_FPCR_REG : DynamicStructure
    {
        public uint Value { get; }
        public uint res0_1 { get; }
        public uint IOE { get; }
        public uint DZE { get; }
        public uint OFE { get; }
        public uint UFE { get; }
        public uint IXE { get; }
        public uint res0_2 { get; }
        public uint IDE { get; }
        public uint Len { get; }
        public uint FZ16 { get; }
        public uint Stride { get; }
        public uint RMode { get; }
        public uint FZ { get; }
        public uint DN { get; }
        public uint AHP { get; }
        public uint res0_3 { get; }

        public _ARM64_FPCR_REG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARM64_FPCR_REG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARM64_FPCR_REG.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.res0_1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.IOE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.DZE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.OFE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.UFE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.IXE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.res0_2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.IDE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.Len),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.FZ16),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.Stride),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.RMode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.FZ),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.DN),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.AHP),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPCR_REG.res0_3),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARM64_FPCR_REG>((mem, ptr) => new _ARM64_FPCR_REG(mem, ptr), offsets);
        }
    }
}