using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_RESERVATION_CLUSTER_INFO")]
    public sealed class MiReservationClusterInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint ClusterSize { get => ReadHere<uint>(nameof(ClusterSize)); set => WriteHere(nameof(ClusterSize), value); }

        [Offset(0UL)]
        public uint SequenceNumber { get => ReadHere<uint>(nameof(SequenceNumber)); set => WriteHere(nameof(SequenceNumber), value); }

        [Offset(0UL)]
        public int EntireInfo { get => ReadHere<int>(nameof(EntireInfo)); set => WriteHere(nameof(EntireInfo), value); }

        public MiReservationClusterInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiReservationClusterInfo>();
        }
    }
}