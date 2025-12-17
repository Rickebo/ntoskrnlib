using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOCAL_NMISOURCE")]
    public sealed class LocalNmisource : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public byte ProcessorID { get => ReadHere<byte>(nameof(ProcessorID)); set => WriteHere(nameof(ProcessorID), value); }

        [Offset(3UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(5UL)]
        public byte LINTIN { get => ReadHere<byte>(nameof(LINTIN)); set => WriteHere(nameof(LINTIN), value); }

        public LocalNmisource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LocalNmisource>();
        }
    }
}