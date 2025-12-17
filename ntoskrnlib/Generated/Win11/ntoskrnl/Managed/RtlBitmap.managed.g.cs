using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_BITMAP")]
    public sealed class RtlBitmap : DynamicStructure
    {
        [Offset(0UL)]
        public uint SizeOfBitMap { get => ReadHere<uint>(nameof(SizeOfBitMap)); set => WriteHere(nameof(SizeOfBitMap), value); }

        [Offset(8UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        public RtlBitmap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlBitmap>();
        }
    }
}