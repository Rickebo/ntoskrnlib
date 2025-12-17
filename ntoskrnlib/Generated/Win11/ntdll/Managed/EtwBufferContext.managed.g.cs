using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_ETW_BUFFER_CONTEXT")]
    public sealed class EtwBufferContext : DynamicStructure
    {
        [Offset(0UL)]
        public byte ProcessorNumber { get => ReadHere<byte>(nameof(ProcessorNumber)); set => WriteHere(nameof(ProcessorNumber), value); }

        [Offset(1UL)]
        public byte Alignment { get => ReadHere<byte>(nameof(Alignment)); set => WriteHere(nameof(Alignment), value); }

        [Offset(0UL)]
        public ushort ProcessorIndex { get => ReadHere<ushort>(nameof(ProcessorIndex)); set => WriteHere(nameof(ProcessorIndex), value); }

        [Offset(2UL)]
        public ushort LoggerId { get => ReadHere<ushort>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        public EtwBufferContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwBufferContext>();
        }
    }
}