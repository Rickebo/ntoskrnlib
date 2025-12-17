using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_KDPC_DATA")]
    public sealed class KdpcData : DynamicStructure
    {
        [Offset(0UL)]
        public KdpcList DpcList { get => ReadStructure<KdpcList>(nameof(DpcList)); set => WriteStructure(nameof(DpcList), value); }

        [Offset(16UL)]
        public ulong DpcLock { get => ReadHere<ulong>(nameof(DpcLock)); set => WriteHere(nameof(DpcLock), value); }

        [Offset(24UL)]
        public int DpcQueueDepth { get => ReadHere<int>(nameof(DpcQueueDepth)); set => WriteHere(nameof(DpcQueueDepth), value); }

        [Offset(28UL)]
        public uint DpcCount { get => ReadHere<uint>(nameof(DpcCount)); set => WriteHere(nameof(DpcCount), value); }

        [Offset(32UL)]
        public IntPtr ActiveDpc { get => ReadHere<IntPtr>(nameof(ActiveDpc)); set => WriteHere(nameof(ActiveDpc), value); }

        [Offset(40UL)]
        public uint LongDpcPresent { get => ReadHere<uint>(nameof(LongDpcPresent)); set => WriteHere(nameof(LongDpcPresent), value); }

        [Offset(44UL)]
        public uint Padding { get => ReadHere<uint>(nameof(Padding)); set => WriteHere(nameof(Padding), value); }

        public KdpcData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KdpcData>();
        }
    }
}