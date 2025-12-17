using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PS_PROTECTION")]
    public sealed class PsProtection : DynamicStructure
    {
        [Offset(0UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(0UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(0UL)]
        public byte Audit { get => ReadHere<byte>(nameof(Audit)); set => WriteHere(nameof(Audit), value); }

        [Offset(0UL)]
        public byte Signer { get => ReadHere<byte>(nameof(Signer)); set => WriteHere(nameof(Signer), value); }

        public PsProtection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PsProtection>();
        }
    }
}