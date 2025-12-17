using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!__m128")]
    public sealed class __m128 : DynamicStructure
    {
        public int[] m128_f32 { get; }
        public ulong[] m128_u64 { get; }
        public sbyte[] m128_i8 { get; }
        public short[] m128_i16 { get; }
        public int[] m128_i32 { get; }
        public long[] m128_i64 { get; }
        public byte[] m128_u8 { get; }
        public ushort[] m128_u16 { get; }
        public uint[] m128_u32 { get; }

        public __m128(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static __m128()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(__m128.m128_f32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_u64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_i8),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_i16),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_i32),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_i64),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_u8),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_u16),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(__m128.m128_u32),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<__m128>((mem, ptr) => new __m128(mem, ptr), offsets);
        }
    }
}