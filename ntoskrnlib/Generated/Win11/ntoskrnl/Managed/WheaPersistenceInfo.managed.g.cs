using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_PERSISTENCE_INFO")]
    public sealed class WheaPersistenceInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Signature { get => ReadHere<ulong>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(0UL)]
        public ulong Length { get => ReadHere<ulong>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(0UL)]
        public ulong Identifier { get => ReadHere<ulong>(nameof(Identifier)); set => WriteHere(nameof(Identifier), value); }

        [Offset(0UL)]
        public ulong Attributes { get => ReadHere<ulong>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        [Offset(0UL)]
        public ulong DoNotLog { get => ReadHere<ulong>(nameof(DoNotLog)); set => WriteHere(nameof(DoNotLog), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong AsULONGLONG { get => ReadHere<ulong>(nameof(AsULONGLONG)); set => WriteHere(nameof(AsULONGLONG), value); }

        public WheaPersistenceInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaPersistenceInfo>();
        }
    }
}