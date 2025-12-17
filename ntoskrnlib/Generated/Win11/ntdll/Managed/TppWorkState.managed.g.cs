using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_WORK_STATE")]
    public sealed class TppWorkState : DynamicStructure
    {
        [Offset(0UL)]
        public int Exchange { get => ReadHere<int>(nameof(Exchange)); set => WriteHere(nameof(Exchange), value); }

        [Offset(0UL)]
        public uint Insertable { get => ReadHere<uint>(nameof(Insertable)); set => WriteHere(nameof(Insertable), value); }

        [Offset(0UL)]
        public uint PendingCallbackCount { get => ReadHere<uint>(nameof(PendingCallbackCount)); set => WriteHere(nameof(PendingCallbackCount), value); }

        public TppWorkState(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppWorkState>();
        }
    }
}