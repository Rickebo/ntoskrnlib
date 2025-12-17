using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PROCLOCALSAPIC")]
    public sealed class Proclocalsapic : DynamicStructure
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
        public byte APICEID { get => ReadHere<byte>(nameof(APICEID)); set => WriteHere(nameof(APICEID), value); }

        [Offset(5UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint ACPIProcessorUIDInteger { get => ReadHere<uint>(nameof(ACPIProcessorUIDInteger)); set => WriteHere(nameof(ACPIProcessorUIDInteger), value); }

        [Offset(16UL)]
        [Length(1)]
        public DynamicArray ACPIProcessorUIDString { get => ReadStructure<DynamicArray>(nameof(ACPIProcessorUIDString)); set => WriteStructure(nameof(ACPIProcessorUIDString), value); }

        public Proclocalsapic(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Proclocalsapic>();
        }
    }
}