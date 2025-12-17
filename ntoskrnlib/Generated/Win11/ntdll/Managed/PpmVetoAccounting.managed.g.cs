using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_PPM_VETO_ACCOUNTING")]
    public sealed class PpmVetoAccounting : DynamicStructure
    {
        [Offset(0UL)]
        public int VetoPresent { get => ReadHere<int>(nameof(VetoPresent)); set => WriteHere(nameof(VetoPresent), value); }

        [Offset(8UL)]
        public ListEntry VetoListHead { get => ReadStructure<ListEntry>(nameof(VetoListHead)); set => WriteStructure(nameof(VetoListHead), value); }

        [Offset(24UL)]
        public byte CsAccountingBlocks { get => ReadHere<byte>(nameof(CsAccountingBlocks)); set => WriteHere(nameof(CsAccountingBlocks), value); }

        [Offset(25UL)]
        public byte BlocksDrips { get => ReadHere<byte>(nameof(BlocksDrips)); set => WriteHere(nameof(BlocksDrips), value); }

        [Offset(28UL)]
        public uint PreallocatedVetoCount { get => ReadHere<uint>(nameof(PreallocatedVetoCount)); set => WriteHere(nameof(PreallocatedVetoCount), value); }

        [Offset(32UL)]
        public IntPtr PreallocatedVetoList { get => ReadHere<IntPtr>(nameof(PreallocatedVetoList)); set => WriteHere(nameof(PreallocatedVetoList), value); }

        public PpmVetoAccounting(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PpmVetoAccounting>();
        }
    }
}