using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_VACB")]
    public sealed class Vacb : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr BaseAddress { get => ReadHere<IntPtr>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(8UL)]
        public IntPtr SharedCacheMap { get => ReadHere<IntPtr>(nameof(SharedCacheMap)); set => WriteHere(nameof(SharedCacheMap), value); }

        [Offset(16UL)]
        public UnnamedTag Overlay { get => ReadStructure<UnnamedTag>(nameof(Overlay)); set => WriteStructure(nameof(Overlay), value); }

        [Offset(32UL)]
        public IntPtr ArrayHead { get => ReadHere<IntPtr>(nameof(ArrayHead)); set => WriteHere(nameof(ArrayHead), value); }

        public Vacb(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Vacb>();
        }
    }
}