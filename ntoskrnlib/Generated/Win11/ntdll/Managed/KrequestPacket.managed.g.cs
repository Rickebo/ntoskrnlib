using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KREQUEST_PACKET")]
    public sealed class KrequestPacket : DynamicStructure
    {
        [Offset(0UL)]
        [Length(3)]
        public DynamicArray CurrentPacket { get => ReadStructure<DynamicArray>(nameof(CurrentPacket)); set => WriteStructure(nameof(CurrentPacket), value); }

        [Offset(24UL)]
        public IntPtr WorkerRoutine { get => ReadHere<IntPtr>(nameof(WorkerRoutine)); set => WriteHere(nameof(WorkerRoutine), value); }

        public KrequestPacket(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KrequestPacket>();
        }
    }
}