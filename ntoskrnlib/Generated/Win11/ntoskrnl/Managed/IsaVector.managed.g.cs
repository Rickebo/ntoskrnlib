using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ISA_VECTOR")]
    public sealed class IsaVector : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public byte Bus { get => ReadHere<byte>(nameof(Bus)); set => WriteHere(nameof(Bus), value); }

        [Offset(3UL)]
        public byte Source { get => ReadHere<byte>(nameof(Source)); set => WriteHere(nameof(Source), value); }

        [Offset(4UL)]
        public uint GlobalSystemInterruptVector { get => ReadHere<uint>(nameof(GlobalSystemInterruptVector)); set => WriteHere(nameof(GlobalSystemInterruptVector), value); }

        [Offset(8UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public IsaVector(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IsaVector>();
        }
    }
}