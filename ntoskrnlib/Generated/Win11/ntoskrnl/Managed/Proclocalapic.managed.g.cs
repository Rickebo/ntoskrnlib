using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCLOCALAPIC")]
    public sealed class Proclocalapic : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public byte ACPIProcessorID { get => ReadHere<byte>(nameof(ACPIProcessorID)); set => WriteHere(nameof(ACPIProcessorID), value); }

        [Offset(3UL)]
        public byte APICID { get => ReadHere<byte>(nameof(APICID)); set => WriteHere(nameof(APICID), value); }

        [Offset(4UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public Proclocalapic(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Proclocalapic>();
        }
    }
}