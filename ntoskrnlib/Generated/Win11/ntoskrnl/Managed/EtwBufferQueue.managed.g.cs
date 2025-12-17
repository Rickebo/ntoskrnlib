using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_BUFFER_QUEUE")]
    public sealed class EtwBufferQueue : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr QueueTail { get => ReadHere<IntPtr>(nameof(QueueTail)); set => WriteHere(nameof(QueueTail), value); }

        [Offset(8UL)]
        public SingleListEntry QueueEntry { get => ReadStructure<SingleListEntry>(nameof(QueueEntry)); set => WriteStructure(nameof(QueueEntry), value); }

        public EtwBufferQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwBufferQueue>();
        }
    }
}