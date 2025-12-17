using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_KLOCK_ENTRY_BOOST_BITMAP")]
    public sealed class KlockEntryBoostBitmap : DynamicStructure
    {
        [Offset(0UL)]
        public ulong AllFields { get => ReadHere<ulong>(nameof(AllFields)); set => WriteHere(nameof(AllFields), value); }

        [Offset(0UL)]
        public uint AllBoosts { get => ReadHere<uint>(nameof(AllBoosts)); set => WriteHere(nameof(AllBoosts), value); }

        [Offset(4UL)]
        public uint WaiterCounts { get => ReadHere<uint>(nameof(WaiterCounts)); set => WriteHere(nameof(WaiterCounts), value); }

        [Offset(0UL)]
        public uint CpuBoostsBitmap { get => ReadHere<uint>(nameof(CpuBoostsBitmap)); set => WriteHere(nameof(CpuBoostsBitmap), value); }

        [Offset(0UL)]
        public uint IoBoost { get => ReadHere<uint>(nameof(IoBoost)); set => WriteHere(nameof(IoBoost), value); }

        [Offset(0UL)]
        public uint IoQoSBoost { get => ReadHere<uint>(nameof(IoQoSBoost)); set => WriteHere(nameof(IoQoSBoost), value); }

        [Offset(4UL)]
        public uint IoNormalPriorityWaiterCount { get => ReadHere<uint>(nameof(IoNormalPriorityWaiterCount)); set => WriteHere(nameof(IoNormalPriorityWaiterCount), value); }

        [Offset(4UL)]
        public uint IoQoSWaiterCount { get => ReadHere<uint>(nameof(IoQoSWaiterCount)); set => WriteHere(nameof(IoQoSWaiterCount), value); }

        public KlockEntryBoostBitmap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<KlockEntryBoostBitmap>();
        }
    }
}