using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_PUSH_LOCK_AUTO_EXPAND")]
    public sealed class ExPushLockAutoExpand : DynamicStructure
    {
        [Offset(0UL)]
        public ExPushLock LocalLock { get => ReadStructure<ExPushLock>(nameof(LocalLock)); set => WriteStructure(nameof(LocalLock), value); }

        [Offset(8UL)]
        public ExPushLockAutoExpandState State { get => ReadStructure<ExPushLockAutoExpandState>(nameof(State)); set => WriteStructure(nameof(State), value); }

        [Offset(12UL)]
        public uint Stats { get => ReadHere<uint>(nameof(Stats)); set => WriteHere(nameof(Stats), value); }

        public ExPushLockAutoExpand(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExPushLockAutoExpand>();
        }
    }
}