using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SESSION_LOWBOX_MAP")]
    public sealed class SessionLowboxMap : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(24UL)]
        public SepLowboxNumberMapping LowboxMap { get => ReadStructure<SepLowboxNumberMapping>(nameof(LowboxMap)); set => WriteStructure(nameof(LowboxMap), value); }

        public SessionLowboxMap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<SessionLowboxMap>();
        }
    }
}