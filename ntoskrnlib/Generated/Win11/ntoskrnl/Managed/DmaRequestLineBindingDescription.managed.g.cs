using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DMA_REQUEST_LINE_BINDING_DESCRIPTION")]
    public sealed class DmaRequestLineBindingDescription : DynamicStructure
    {
        [Offset(0UL)]
        public uint RequestLine { get => ReadHere<uint>(nameof(RequestLine)); set => WriteHere(nameof(RequestLine), value); }

        [Offset(4UL)]
        public uint ChannelNumber { get => ReadHere<uint>(nameof(ChannelNumber)); set => WriteHere(nameof(ChannelNumber), value); }

        public DmaRequestLineBindingDescription(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DmaRequestLineBindingDescription>();
        }
    }
}