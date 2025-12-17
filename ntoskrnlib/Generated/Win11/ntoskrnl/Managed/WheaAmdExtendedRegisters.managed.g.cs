using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_AMD_EXTENDED_REGISTERS")]
    public sealed class WheaAmdExtendedRegisters : DynamicStructure
    {
        [Offset(0UL)]
        public ulong IPID { get => ReadHere<ulong>(nameof(IPID)); set => WriteHere(nameof(IPID), value); }

        [Offset(8UL)]
        public ulong SYND { get => ReadHere<ulong>(nameof(SYND)); set => WriteHere(nameof(SYND), value); }

        [Offset(16UL)]
        public ulong CONFIG { get => ReadHere<ulong>(nameof(CONFIG)); set => WriteHere(nameof(CONFIG), value); }

        [Offset(24UL)]
        public ulong DESTAT { get => ReadHere<ulong>(nameof(DESTAT)); set => WriteHere(nameof(DESTAT), value); }

        [Offset(32UL)]
        public ulong DEADDR { get => ReadHere<ulong>(nameof(DEADDR)); set => WriteHere(nameof(DEADDR), value); }

        [Offset(40UL)]
        public ulong MISC1 { get => ReadHere<ulong>(nameof(MISC1)); set => WriteHere(nameof(MISC1), value); }

        [Offset(48UL)]
        public ulong MISC2 { get => ReadHere<ulong>(nameof(MISC2)); set => WriteHere(nameof(MISC2), value); }

        [Offset(56UL)]
        public ulong MISC3 { get => ReadHere<ulong>(nameof(MISC3)); set => WriteHere(nameof(MISC3), value); }

        [Offset(64UL)]
        public ulong MISC4 { get => ReadHere<ulong>(nameof(MISC4)); set => WriteHere(nameof(MISC4), value); }

        [Offset(72UL)]
        public ulong RasCap { get => ReadHere<ulong>(nameof(RasCap)); set => WriteHere(nameof(RasCap), value); }

        [Offset(80UL)]
        [Length(14)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        public WheaAmdExtendedRegisters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaAmdExtendedRegisters>();
        }
    }
}