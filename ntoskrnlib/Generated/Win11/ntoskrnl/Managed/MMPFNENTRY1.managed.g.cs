using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMPFNENTRY1")]
    public sealed class MMPFNENTRY1 : DynamicStructure
    {
        [Offset(0UL)]
        public byte PageLocation { get => ReadHere<byte>(nameof(PageLocation)); set => WriteHere(nameof(PageLocation), value); }

        [Offset(0UL)]
        public byte WriteInProgress { get => ReadHere<byte>(nameof(WriteInProgress)); set => WriteHere(nameof(WriteInProgress), value); }

        [Offset(0UL)]
        public byte Modified { get => ReadHere<byte>(nameof(Modified)); set => WriteHere(nameof(Modified), value); }

        [Offset(0UL)]
        public byte ReadInProgress { get => ReadHere<byte>(nameof(ReadInProgress)); set => WriteHere(nameof(ReadInProgress), value); }

        [Offset(0UL)]
        public byte CacheAttribute { get => ReadHere<byte>(nameof(CacheAttribute)); set => WriteHere(nameof(CacheAttribute), value); }

        public MMPFNENTRY1(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MMPFNENTRY1>();
        }
    }
}