using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_NMISOURCE")]
    public sealed class IoNmisource : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public uint GlobalSystemInterruptVector { get => ReadHere<uint>(nameof(GlobalSystemInterruptVector)); set => WriteHere(nameof(GlobalSystemInterruptVector), value); }

        public IoNmisource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoNmisource>();
        }
    }
}