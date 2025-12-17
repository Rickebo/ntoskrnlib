using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!__m64")]
    public sealed class m64 : DynamicStructure
    {
        [Offset(0UL)]
        public ulong m64_u64 { get => ReadHere<ulong>(nameof(m64_u64)); set => WriteHere(nameof(m64_u64), value); }

        [Offset(0UL)]
        [Length(2)]
        public DynamicArray m64_f32 { get => ReadStructure<DynamicArray>(nameof(m64_f32)); set => WriteStructure(nameof(m64_f32), value); }

        [Offset(0UL)]
        [Length(8)]
        public DynamicArray m64_i8 { get => ReadStructure<DynamicArray>(nameof(m64_i8)); set => WriteStructure(nameof(m64_i8), value); }

        [Offset(0UL)]
        [Length(4)]
        public DynamicArray m64_i16 { get => ReadStructure<DynamicArray>(nameof(m64_i16)); set => WriteStructure(nameof(m64_i16), value); }

        [Offset(0UL)]
        [Length(2)]
        public DynamicArray m64_i32 { get => ReadStructure<DynamicArray>(nameof(m64_i32)); set => WriteStructure(nameof(m64_i32), value); }

        [Offset(0UL)]
        public long m64_i64 { get => ReadHere<long>(nameof(m64_i64)); set => WriteHere(nameof(m64_i64), value); }

        [Offset(0UL)]
        [Length(8)]
        public DynamicArray m64_u8 { get => ReadStructure<DynamicArray>(nameof(m64_u8)); set => WriteStructure(nameof(m64_u8), value); }

        [Offset(0UL)]
        [Length(4)]
        public DynamicArray m64_u16 { get => ReadStructure<DynamicArray>(nameof(m64_u16)); set => WriteStructure(nameof(m64_u16), value); }

        [Offset(0UL)]
        [Length(2)]
        public DynamicArray m64_u32 { get => ReadStructure<DynamicArray>(nameof(m64_u32)); set => WriteStructure(nameof(m64_u32), value); }

        public m64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<m64>();
        }
    }
}