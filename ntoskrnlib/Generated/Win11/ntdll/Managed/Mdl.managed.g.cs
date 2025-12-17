using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MDL")]
    public sealed class Mdl : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        [Offset(8UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(10UL)]
        public short MdlFlags { get => ReadHere<short>(nameof(MdlFlags)); set => WriteHere(nameof(MdlFlags), value); }

        [Offset(12UL)]
        public ushort AllocationProcessorNumber { get => ReadHere<ushort>(nameof(AllocationProcessorNumber)); set => WriteHere(nameof(AllocationProcessorNumber), value); }

        [Offset(14UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(16UL)]
        public IntPtr Process { get => ReadHere<IntPtr>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(24UL)]
        public IntPtr MappedSystemVa { get => ReadHere<IntPtr>(nameof(MappedSystemVa)); set => WriteHere(nameof(MappedSystemVa), value); }

        [Offset(32UL)]
        public IntPtr StartVa { get => ReadHere<IntPtr>(nameof(StartVa)); set => WriteHere(nameof(StartVa), value); }

        [Offset(40UL)]
        public uint ByteCount { get => ReadHere<uint>(nameof(ByteCount)); set => WriteHere(nameof(ByteCount), value); }

        [Offset(44UL)]
        public uint ByteOffset { get => ReadHere<uint>(nameof(ByteOffset)); set => WriteHere(nameof(ByteOffset), value); }

        public Mdl(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Mdl>();
        }
    }
}