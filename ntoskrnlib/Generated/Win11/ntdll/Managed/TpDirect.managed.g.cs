using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_DIRECT")]
    public sealed class TpDirect : DynamicStructure
    {
        [Offset(0UL)]
        public TpTask Task { get => ReadStructure<TpTask>(nameof(Task)); set => WriteStructure(nameof(Task), value); }

        [Offset(32UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(40UL)]
        public ListEntry IoCompletionInformationList { get => ReadStructure<ListEntry>(nameof(IoCompletionInformationList)); set => WriteStructure(nameof(IoCompletionInformationList), value); }

        [Offset(56UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(64UL)]
        public uint NumaNode { get => ReadHere<uint>(nameof(NumaNode)); set => WriteHere(nameof(NumaNode), value); }

        [Offset(68UL)]
        public byte IdealProcessor { get => ReadHere<byte>(nameof(IdealProcessor)); set => WriteHere(nameof(IdealProcessor), value); }

        public TpDirect(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpDirect>();
        }
    }
}