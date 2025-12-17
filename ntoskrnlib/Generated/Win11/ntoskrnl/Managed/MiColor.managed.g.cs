using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_COLOR")]
    public sealed class MiColor : DynamicStructure
    {
        [Offset(0UL)]
        public uint EntireField { get => ReadHere<uint>(nameof(EntireField)); set => WriteHere(nameof(EntireField), value); }

        [Offset(0UL)]
        public uint Cache { get => ReadHere<uint>(nameof(Cache)); set => WriteHere(nameof(Cache), value); }

        [Offset(0UL)]
        public uint Channel { get => ReadHere<uint>(nameof(Channel)); set => WriteHere(nameof(Channel), value); }

        [Offset(0UL)]
        public uint Node { get => ReadHere<uint>(nameof(Node)); set => WriteHere(nameof(Node), value); }

        [Offset(0UL)]
        public uint HighLow { get => ReadHere<uint>(nameof(HighLow)); set => WriteHere(nameof(HighLow), value); }

        [Offset(0UL)]
        public uint LargePageIndex { get => ReadHere<uint>(nameof(LargePageIndex)); set => WriteHere(nameof(LargePageIndex), value); }

        [Offset(0UL)]
        public uint CacheAttribute { get => ReadHere<uint>(nameof(CacheAttribute)); set => WriteHere(nameof(CacheAttribute), value); }

        [Offset(0UL)]
        public uint ListName { get => ReadHere<uint>(nameof(ListName)); set => WriteHere(nameof(ListName), value); }

        public MiColor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiColor>();
        }
    }
}