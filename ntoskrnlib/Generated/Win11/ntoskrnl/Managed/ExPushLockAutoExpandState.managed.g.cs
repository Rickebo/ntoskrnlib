using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EX_PUSH_LOCK_AUTO_EXPAND_STATE")]
    public sealed class ExPushLockAutoExpandState : DynamicStructure
    {
        [Offset(0UL)]
        public uint Expanded { get => ReadHere<uint>(nameof(Expanded)); set => WriteHere(nameof(Expanded), value); }

        [Offset(0UL)]
        public uint Transitioning { get => ReadHere<uint>(nameof(Transitioning)); set => WriteHere(nameof(Transitioning), value); }

        [Offset(0UL)]
        public uint Pageable { get => ReadHere<uint>(nameof(Pageable)); set => WriteHere(nameof(Pageable), value); }

        [Offset(0UL)]
        public uint Value { get => ReadHere<uint>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        public ExPushLockAutoExpandState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ExPushLockAutoExpandState>();
        }
    }
}