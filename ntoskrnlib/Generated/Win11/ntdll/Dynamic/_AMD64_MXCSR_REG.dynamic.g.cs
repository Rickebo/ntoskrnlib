using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_AMD64_MXCSR_REG")]
    public sealed class _AMD64_MXCSR_REG : DynamicStructure
    {
        public uint Value { get; }
        public uint IE { get; }
        public uint DE { get; }
        public uint ZE { get; }
        public uint OE { get; }
        public uint UE { get; }
        public uint PE { get; }
        public uint DAZ { get; }
        public uint IM { get; }
        public uint DM { get; }
        public uint ZM { get; }
        public uint OM { get; }
        public uint UM { get; }
        public uint PM { get; }
        public uint RC { get; }
        public uint FZ { get; }
        public uint res { get; }

        public _AMD64_MXCSR_REG(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AMD64_MXCSR_REG()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AMD64_MXCSR_REG.Value),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.IE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.DE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.ZE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.OE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.UE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.PE),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.DAZ),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.IM),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.DM),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.ZM),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.OM),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.UM),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.PM),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.RC),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.FZ),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD64_MXCSR_REG.res),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_AMD64_MXCSR_REG>((mem, ptr) => new _AMD64_MXCSR_REG(mem, ptr), offsets);
        }
    }
}