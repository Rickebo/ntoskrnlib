using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_RTL_RANGE")]
    public sealed class RtlRange : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Start { get => ReadHere<ulong>(nameof(Start)); set => WriteHere(nameof(Start), value); }

        [Offset(8UL)]
        public ulong End { get => ReadHere<ulong>(nameof(End)); set => WriteHere(nameof(End), value); }

        [Offset(16UL)]
        public IntPtr UserData { get => ReadHere<IntPtr>(nameof(UserData)); set => WriteHere(nameof(UserData), value); }

        [Offset(24UL)]
        public IntPtr Owner { get => ReadHere<IntPtr>(nameof(Owner)); set => WriteHere(nameof(Owner), value); }

        [Offset(32UL)]
        public byte Attributes { get => ReadHere<byte>(nameof(Attributes)); set => WriteHere(nameof(Attributes), value); }

        [Offset(33UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public RtlRange(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlRange>();
        }
    }
}