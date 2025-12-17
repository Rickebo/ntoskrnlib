using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARBITER_ALTERNATIVE")]
    public sealed class ArbiterAlternative : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Minimum { get => ReadHere<ulong>(nameof(Minimum)); set => WriteHere(nameof(Minimum), value); }

        [Offset(8UL)]
        public ulong Maximum { get => ReadHere<ulong>(nameof(Maximum)); set => WriteHere(nameof(Maximum), value); }

        [Offset(16UL)]
        public ulong Length { get => ReadHere<ulong>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(24UL)]
        public ulong Alignment { get => ReadHere<ulong>(nameof(Alignment)); set => WriteHere(nameof(Alignment), value); }

        [Offset(32UL)]
        public int Priority { get => ReadHere<int>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(36UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(40UL)]
        public IntPtr Descriptor { get => ReadHere<IntPtr>(nameof(Descriptor)); set => WriteHere(nameof(Descriptor), value); }

        [Offset(48UL)]
        [Length(3)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public ArbiterAlternative(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArbiterAlternative>();
        }
    }
}