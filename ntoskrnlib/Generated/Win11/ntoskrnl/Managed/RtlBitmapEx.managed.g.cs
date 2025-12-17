using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_BITMAP_EX")]
    public sealed class RtlBitmapEx : DynamicStructure
    {
        [Offset(0UL)]
        public ulong SizeOfBitMap { get => ReadHere<ulong>(nameof(SizeOfBitMap)); set => WriteHere(nameof(SizeOfBitMap), value); }

        [Offset(8UL)]
        public IntPtr Buffer { get => ReadHere<IntPtr>(nameof(Buffer)); set => WriteHere(nameof(Buffer), value); }

        public RtlBitmapEx(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlBitmapEx>();
        }
    }
}