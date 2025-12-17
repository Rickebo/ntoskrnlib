using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FREE_DISPLAY")]
    public sealed class FreeDisplay : DynamicStructure
    {
        [Offset(0UL)]
        public uint RealVectorSize { get => ReadHere<uint>(nameof(RealVectorSize)); set => WriteHere(nameof(RealVectorSize), value); }

        [Offset(4UL)]
        public uint Hint { get => ReadHere<uint>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        [Offset(8UL)]
        public RtlBitmap Display { get => ReadStructure<RtlBitmap>(nameof(Display)); set => WriteStructure(nameof(Display), value); }

        public FreeDisplay(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FreeDisplay>();
        }
    }
}