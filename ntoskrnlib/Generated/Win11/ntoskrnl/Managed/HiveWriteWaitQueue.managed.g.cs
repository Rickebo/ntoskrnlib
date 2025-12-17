using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HIVE_WRITE_WAIT_QUEUE")]
    public sealed class HiveWriteWaitQueue : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ActiveThread { get => ReadHere<IntPtr>(nameof(ActiveThread)); set => WriteHere(nameof(ActiveThread), value); }

        [Offset(8UL)]
        public IntPtr WaitList { get => ReadHere<IntPtr>(nameof(WaitList)); set => WriteHere(nameof(WaitList), value); }

        public HiveWriteWaitQueue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HiveWriteWaitQueue>();
        }
    }
}