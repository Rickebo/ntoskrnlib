using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KWAIT_STATUS_REGISTER")]
    public sealed class KwaitStatusRegister : DynamicStructure
    {
        [Offset(0UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(0UL)]
        public byte State { get => ReadHere<byte>(nameof(State)); set => WriteHere(nameof(State), value); }

        [Offset(0UL)]
        public byte Affinity { get => ReadHere<byte>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(0UL)]
        public byte Priority { get => ReadHere<byte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(0UL)]
        public byte Apc { get => ReadHere<byte>(nameof(Apc)); set => WriteHere(nameof(Apc), value); }

        [Offset(0UL)]
        public byte UserApc { get => ReadHere<byte>(nameof(UserApc)); set => WriteHere(nameof(UserApc), value); }

        [Offset(0UL)]
        public byte Alert { get => ReadHere<byte>(nameof(Alert)); set => WriteHere(nameof(Alert), value); }

        public KwaitStatusRegister(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KwaitStatusRegister>();
        }
    }
}