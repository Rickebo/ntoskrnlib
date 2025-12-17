using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_LOCAL_X2APIC_NMISOURCE")]
    public sealed class LocalX2APICNmisource : DynamicStructure
    {
        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(1UL)]
        public byte Length { get => ReadHere<byte>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(2UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public uint ProcessorID { get => ReadHere<uint>(nameof(ProcessorID)); set => WriteHere(nameof(ProcessorID), value); }

        [Offset(8UL)]
        public byte LINTIN { get => ReadHere<byte>(nameof(LINTIN)); set => WriteHere(nameof(LINTIN), value); }

        [Offset(9UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public LocalX2APICNmisource(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<LocalX2APICNmisource>();
        }
    }
}