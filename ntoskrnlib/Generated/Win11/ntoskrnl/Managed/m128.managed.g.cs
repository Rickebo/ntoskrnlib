using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!__m128")]
    public sealed class m128 : DynamicStructure
    {
        [Offset(0UL)]
        [Length(4)]
        public DynamicArray m128_f32 { get => ReadStructure<DynamicArray>(nameof(m128_f32)); set => WriteStructure(nameof(m128_f32), value); }

        [Offset(0UL)]
        [Length(2)]
        public DynamicArray m128_u64 { get => ReadStructure<DynamicArray>(nameof(m128_u64)); set => WriteStructure(nameof(m128_u64), value); }

        [Offset(0UL)]
        [Length(16)]
        public DynamicArray m128_i8 { get => ReadStructure<DynamicArray>(nameof(m128_i8)); set => WriteStructure(nameof(m128_i8), value); }

        [Offset(0UL)]
        [Length(8)]
        public DynamicArray m128_i16 { get => ReadStructure<DynamicArray>(nameof(m128_i16)); set => WriteStructure(nameof(m128_i16), value); }

        [Offset(0UL)]
        [Length(4)]
        public DynamicArray m128_i32 { get => ReadStructure<DynamicArray>(nameof(m128_i32)); set => WriteStructure(nameof(m128_i32), value); }

        [Offset(0UL)]
        [Length(2)]
        public DynamicArray m128_i64 { get => ReadStructure<DynamicArray>(nameof(m128_i64)); set => WriteStructure(nameof(m128_i64), value); }

        [Offset(0UL)]
        [Length(16)]
        public DynamicArray m128_u8 { get => ReadStructure<DynamicArray>(nameof(m128_u8)); set => WriteStructure(nameof(m128_u8), value); }

        [Offset(0UL)]
        [Length(8)]
        public DynamicArray m128_u16 { get => ReadStructure<DynamicArray>(nameof(m128_u16)); set => WriteStructure(nameof(m128_u16), value); }

        [Offset(0UL)]
        [Length(4)]
        public DynamicArray m128_u32 { get => ReadStructure<DynamicArray>(nameof(m128_u32)); set => WriteStructure(nameof(m128_u32), value); }

        public m128(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<m128>();
        }
    }
}