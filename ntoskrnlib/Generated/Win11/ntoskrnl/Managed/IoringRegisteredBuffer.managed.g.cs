using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!IORING_REGISTERED_BUFFER")]
    public sealed class IoringRegisteredBuffer : DynamicStructure
    {
        [Offset(0UL)]
        public uint BufferIndex { get => ReadHere<uint>(nameof(BufferIndex)); set => WriteHere(nameof(BufferIndex), value); }

        [Offset(4UL)]
        public uint Offset { get => ReadHere<uint>(nameof(Offset)); set => WriteHere(nameof(Offset), value); }

        public IoringRegisteredBuffer(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoringRegisteredBuffer>();
        }
    }
}