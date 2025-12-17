using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_HIVE_WAIT_PACKET")]
    public sealed class HiveWaitPacket : DynamicStructure
    {
        [Offset(0UL)]
        public Kevent WakeEvent { get => ReadStructure<Kevent>(nameof(WakeEvent)); set => WriteStructure(nameof(WakeEvent), value); }

        [Offset(24UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(32UL)]
        public IntPtr Next { get => ReadHere<IntPtr>(nameof(Next)); set => WriteHere(nameof(Next), value); }

        public HiveWaitPacket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<HiveWaitPacket>();
        }
    }
}