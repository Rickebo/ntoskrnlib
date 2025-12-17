using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_ULTRA_VA_CONTEXT")]
    public sealed class MiUltraVaContext : DynamicStructure
    {
        [Offset(0UL)]
        public int Lock { get => ReadHere<int>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(8UL)]
        public IntPtr ZeroMapping { get => ReadHere<IntPtr>(nameof(ZeroMapping)); set => WriteHere(nameof(ZeroMapping), value); }

        [Offset(16UL)]
        public ulong AllocationHintBit { get => ReadHere<ulong>(nameof(AllocationHintBit)); set => WriteHere(nameof(AllocationHintBit), value); }

        [Offset(24UL)]
        [Length(2)]
        public DynamicArray Bitmap { get => ReadStructure<DynamicArray>(nameof(Bitmap)); set => WriteStructure(nameof(Bitmap), value); }

        [Offset(56UL)]
        public uint ConcurrencyMaximum { get => ReadHere<uint>(nameof(ConcurrencyMaximum)); set => WriteHere(nameof(ConcurrencyMaximum), value); }

        [Offset(60UL)]
        public int ConcurrencyCount { get => ReadHere<int>(nameof(ConcurrencyCount)); set => WriteHere(nameof(ConcurrencyCount), value); }

        public MiUltraVaContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiUltraVaContext>();
        }
    }
}