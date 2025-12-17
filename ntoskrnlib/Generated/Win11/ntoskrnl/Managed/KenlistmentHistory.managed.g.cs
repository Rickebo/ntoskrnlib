using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KENLISTMENT_HISTORY")]
    public sealed class KenlistmentHistory : DynamicStructure
    {
        [Offset(0UL)]
        public uint Notification { get => ReadHere<uint>(nameof(Notification)); set => WriteHere(nameof(Notification), value); }

        [Offset(4UL)]
        public uint NewState { get => ReadHere<uint>(nameof(NewState)); set => WriteHere(nameof(NewState), value); }

        public KenlistmentHistory(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KenlistmentHistory>();
        }
    }
}