using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KCPU_PARTITION")]
    public sealed class KcpuPartition : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Affinity { get => ReadHere<IntPtr>(nameof(Affinity)); set => WriteHere(nameof(Affinity), value); }

        [Offset(8UL)]
        public ulong Lock { get => ReadHere<ulong>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(16UL)]
        public ListEntry ProcessList { get => ReadStructure<ListEntry>(nameof(ProcessList)); set => WriteStructure(nameof(ProcessList), value); }

        [Offset(32UL)]
        public IntPtr CpuPartitionObject { get => ReadHere<IntPtr>(nameof(CpuPartitionObject)); set => WriteHere(nameof(CpuPartitionObject), value); }

        [Offset(40UL)]
        public KiAvailableCpusWorkItem AvailableCpusNotificationWorkItem { get => ReadStructure<KiAvailableCpusWorkItem>(nameof(AvailableCpusNotificationWorkItem)); set => WriteStructure(nameof(AvailableCpusNotificationWorkItem), value); }

        [Offset(104UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public KcpuPartition(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KcpuPartition>();
        }
    }
}