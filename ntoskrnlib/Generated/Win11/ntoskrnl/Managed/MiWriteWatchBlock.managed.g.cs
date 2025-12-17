using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_WRITE_WATCH_BLOCK")]
    public sealed class MiWriteWatchBlock : DynamicStructure
    {
        [Offset(0UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public RtlBitmapEx BitMap { get => ReadStructure<RtlBitmapEx>(nameof(BitMap)); set => WriteStructure(nameof(BitMap), value); }

        public MiWriteWatchBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiWriteWatchBlock>();
        }
    }
}