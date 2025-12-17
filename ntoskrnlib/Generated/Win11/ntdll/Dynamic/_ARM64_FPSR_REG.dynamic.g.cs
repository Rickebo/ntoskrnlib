using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_ARM64_FPSR_REG")]
    public sealed class _ARM64_FPSR_REG : DynamicStructure
    {
        public uint Value { get; }
        public uint IOC { get; }
        public uint DZC { get; }
        public uint OFC { get; }
        public uint UFC { get; }
        public uint IXC { get; }
        public uint res0_1 { get; }
        public uint IDC { get; }
        public uint res0_2 { get; }
        public uint QC { get; }
        public uint V { get; }
        public uint C { get; }
        public uint Z { get; }
        public uint N { get; }

        public _ARM64_FPSR_REG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _ARM64_FPSR_REG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_ARM64_FPSR_REG.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.IOC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.DZC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.OFC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.UFC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.IXC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.res0_1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.IDC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.res0_2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.QC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.V),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.C),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.Z),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_ARM64_FPSR_REG.N),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_ARM64_FPSR_REG>((mem, ptr) => new _ARM64_FPSR_REG(mem, ptr), offsets);
        }
    }
}