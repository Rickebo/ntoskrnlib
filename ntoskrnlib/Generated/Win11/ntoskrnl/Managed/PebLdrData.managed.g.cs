using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_PEB_LDR_DATA")]
    public sealed class PebLdrData : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(4UL)]
        public byte Initialized { get => ReadHere<byte>(nameof(Initialized)); set => WriteHere(nameof(Initialized), value); }

        [Offset(8UL)]
        public IntPtr SsHandle { get => ReadHere<IntPtr>(nameof(SsHandle)); set => WriteHere(nameof(SsHandle), value); }

        [Offset(16UL)]
        public ListEntry InLoadOrderModuleList { get => ReadStructure<ListEntry>(nameof(InLoadOrderModuleList)); set => WriteStructure(nameof(InLoadOrderModuleList), value); }

        [Offset(32UL)]
        public ListEntry InMemoryOrderModuleList { get => ReadStructure<ListEntry>(nameof(InMemoryOrderModuleList)); set => WriteStructure(nameof(InMemoryOrderModuleList), value); }

        [Offset(48UL)]
        public ListEntry InInitializationOrderModuleList { get => ReadStructure<ListEntry>(nameof(InInitializationOrderModuleList)); set => WriteStructure(nameof(InInitializationOrderModuleList), value); }

        [Offset(64UL)]
        public IntPtr EntryInProgress { get => ReadHere<IntPtr>(nameof(EntryInProgress)); set => WriteHere(nameof(EntryInProgress), value); }

        [Offset(72UL)]
        public byte ShutdownInProgress { get => ReadHere<byte>(nameof(ShutdownInProgress)); set => WriteHere(nameof(ShutdownInProgress), value); }

        [Offset(80UL)]
        public IntPtr ShutdownThreadId { get => ReadHere<IntPtr>(nameof(ShutdownThreadId)); set => WriteHere(nameof(ShutdownThreadId), value); }

        public PebLdrData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PebLdrData>();
        }
    }
}