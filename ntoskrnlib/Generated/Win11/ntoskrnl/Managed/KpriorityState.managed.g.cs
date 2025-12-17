using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KPRIORITY_STATE")]
    public sealed class KpriorityState : DynamicStructure
    {
        [Offset(0UL)]
        public byte Priority { get => ReadHere<byte>(nameof(Priority)); set => WriteHere(nameof(Priority), value); }

        [Offset(0UL)]
        public byte IsolationWidth { get => ReadHere<byte>(nameof(IsolationWidth)); set => WriteHere(nameof(IsolationWidth), value); }

        [Offset(0UL)]
        public byte AllFields { get => ReadHere<byte>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        public KpriorityState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KpriorityState>();
        }
    }
}