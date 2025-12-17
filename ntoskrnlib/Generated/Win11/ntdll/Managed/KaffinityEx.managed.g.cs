using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KAFFINITY_EX")]
    public sealed class KaffinityEx : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Count { get => ReadHere<ushort>(nameof(Count)); set => WriteHere(nameof(Count), value); }

        [Offset(2UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        [Length(1)]
        public DynamicArray Bitmap { get => ReadStructure<DynamicArray>(nameof(Bitmap)); set => WriteStructure(nameof(Bitmap), value); }

        [Offset(8UL)]
        [Length(32)]
        public DynamicArray StaticBitmap { get => ReadStructure<DynamicArray>(nameof(StaticBitmap)); set => WriteStructure(nameof(StaticBitmap), value); }

        public KaffinityEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KaffinityEx>();
        }
    }
}