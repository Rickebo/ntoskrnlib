using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MMSECURE_FLAGS")]
    public sealed class MmsecureFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint ReadOnly { get => ReadHere<uint>(nameof(ReadOnly)); set => WriteHere(nameof(ReadOnly), value); }

        [Offset(0UL)]
        public uint ReadWrite { get => ReadHere<uint>(nameof(ReadWrite)); set => WriteHere(nameof(ReadWrite), value); }

        [Offset(0UL)]
        public uint SecNoChange { get => ReadHere<uint>(nameof(SecNoChange)); set => WriteHere(nameof(SecNoChange), value); }

        [Offset(0UL)]
        public uint NoDelete { get => ReadHere<uint>(nameof(NoDelete)); set => WriteHere(nameof(NoDelete), value); }

        [Offset(0UL)]
        public uint RequiresPteReversal { get => ReadHere<uint>(nameof(RequiresPteReversal)); set => WriteHere(nameof(RequiresPteReversal), value); }

        [Offset(0UL)]
        public uint ExclusiveSecure { get => ReadHere<uint>(nameof(ExclusiveSecure)); set => WriteHere(nameof(ExclusiveSecure), value); }

        [Offset(0UL)]
        public uint UserModeOnly { get => ReadHere<uint>(nameof(UserModeOnly)); set => WriteHere(nameof(UserModeOnly), value); }

        [Offset(0UL)]
        public uint NoInherit { get => ReadHere<uint>(nameof(NoInherit)); set => WriteHere(nameof(NoInherit), value); }

        [Offset(0UL)]
        public uint CheckVad { get => ReadHere<uint>(nameof(CheckVad)); set => WriteHere(nameof(CheckVad), value); }

        [Offset(0UL)]
        public uint Spare { get => ReadHere<uint>(nameof(Spare)); set => WriteHere(nameof(Spare), value); }

        public MmsecureFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsecureFlags>();
        }
    }
}