using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KALPC_DIRECT_EVENT")]
    public sealed class KalpcDirectEvent : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public ulong DirectType { get => ReadHere<ulong>(nameof(DirectType)); set => WriteHere(nameof(DirectType), value); }

        [Offset(0UL)]
        public ulong EventReferenced { get => ReadHere<ulong>(nameof(EventReferenced)); set => WriteHere(nameof(EventReferenced), value); }

        [Offset(0UL)]
        public ulong EventObjectBits { get => ReadHere<ulong>(nameof(EventObjectBits)); set => WriteHere(nameof(EventObjectBits), value); }

        public KalpcDirectEvent(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KalpcDirectEvent>();
        }
    }
}