using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_REPLY_QUEUE")]
    public sealed class EtwReplyQueue : DynamicStructure
    {
        [Offset(0UL)]
        public Kqueue Queue { get => ReadStructure<Kqueue>(nameof(Queue)); set => WriteStructure(nameof(Queue), value); }

        [Offset(64UL)]
        public int EventsLost { get => ReadHere<int>(nameof(EventsLost)); set => WriteHere(nameof(EventsLost), value); }

        public EtwReplyQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwReplyQueue>();
        }
    }
}