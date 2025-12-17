using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TP_ALPC")]
    public sealed class TpAlpc : DynamicStructure
    {
        [Offset(0UL)]
        public TpDirect Direct { get => ReadStructure<TpDirect>(nameof(Direct)); set => WriteStructure(nameof(Direct), value); }

        [Offset(72UL)]
        public TppCleanupGroupMember CleanupGroupMember { get => ReadStructure<TppCleanupGroupMember>(nameof(CleanupGroupMember)); set => WriteStructure(nameof(CleanupGroupMember), value); }

        [Offset(272UL)]
        public IntPtr AlpcPort { get => ReadHere<IntPtr>(nameof(AlpcPort)); set => WriteHere(nameof(AlpcPort), value); }

        [Offset(280UL)]
        public int DeferredSendCount { get => ReadHere<int>(nameof(DeferredSendCount)); set => WriteHere(nameof(DeferredSendCount), value); }

        [Offset(284UL)]
        public int LastConcurrencyCount { get => ReadHere<int>(nameof(LastConcurrencyCount)); set => WriteHere(nameof(LastConcurrencyCount), value); }

        [Offset(288UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(288UL)]
        public uint ExTypeCallback { get => ReadHere<uint>(nameof(ExTypeCallback)); set => WriteHere(nameof(ExTypeCallback), value); }

        [Offset(288UL)]
        public uint CompletionListRegistered { get => ReadHere<uint>(nameof(CompletionListRegistered)); set => WriteHere(nameof(CompletionListRegistered), value); }

        [Offset(288UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public TpAlpc(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TpAlpc>();
        }
    }
}