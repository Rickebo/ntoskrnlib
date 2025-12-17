using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!__m64")]
    public sealed class __m64 : DynamicStructure
    {
        public ulong m64_u64 { get; }
        public int[] m64_f32 { get; }
        public sbyte[] m64_i8 { get; }
        public short[] m64_i16 { get; }
        public int[] m64_i32 { get; }
        public long m64_i64 { get; }
        public byte[] m64_u8 { get; }
        public ushort[] m64_u16 { get; }
        public uint[] m64_u32 { get; }

        public __m64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static __m64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(__m64.m64_u64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_f32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_i8),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_i16),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_i32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_i64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_u8),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_u16),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m64.m64_u32),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<__m64>((mem, ptr) => new __m64(mem, ptr), offsets);
        }
    }
}