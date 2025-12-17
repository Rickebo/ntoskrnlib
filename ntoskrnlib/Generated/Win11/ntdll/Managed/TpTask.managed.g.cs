using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_TASK")]
    public sealed class TpTask : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Callbacks { get => ReadHere<IntPtr>(nameof(Callbacks)); set => WriteHere(nameof(Callbacks), value); }

        [Offset(8UL)]
        public uint NumaNode { get => ReadHere<uint>(nameof(NumaNode)); set => WriteHere(nameof(NumaNode), value); }

        [Offset(12UL)]
        public byte IdealProcessor { get => ReadHere<byte>(nameof(IdealProcessor)); set => WriteHere(nameof(IdealProcessor), value); }

        [Offset(16UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        public TpTask(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpTask>();
        }
    }
}