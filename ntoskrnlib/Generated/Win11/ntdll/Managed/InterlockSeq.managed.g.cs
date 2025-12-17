using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_INTERLOCK_SEQ")]
    public sealed class InterlockSeq : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Depth { get => ReadHere<ushort>(nameof(Depth)); set => WriteHere(nameof(Depth), value); }

        [Offset(2UL)]
        public ushort Hint { get => ReadHere<ushort>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        [Offset(2UL)]
        public ushort Lock { get => ReadHere<ushort>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(2UL)]
        public ushort Hint16 { get => ReadHere<ushort>(nameof(Hint16)); set => WriteHere(nameof(Hint16), value); }

        [Offset(0UL)]
        public int Exchg { get => ReadHere<int>(nameof(Exchg)); set => WriteHere(nameof(Exchg), value); }

        public InterlockSeq(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<InterlockSeq>();
        }
    }
}