using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_SYSTEM_PTE_TYPE")]
    public sealed class MiSystemPteType : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBitmapEx Bitmap { get => ReadStructure<RtlBitmapEx>(nameof(Bitmap)); set => WriteStructure(nameof(Bitmap), value); }

        [Offset(16UL)]
        public RtlBitmapEx TrackingBitmap { get => ReadStructure<RtlBitmapEx>(nameof(TrackingBitmap)); set => WriteStructure(nameof(TrackingBitmap), value); }

        [Offset(32UL)]
        public IntPtr BasePte { get => ReadHere<IntPtr>(nameof(BasePte)); set => WriteHere(nameof(BasePte), value); }

        [Offset(40UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(44UL)]
        public uint VaType { get => ReadHere<uint>(nameof(VaType)); set => WriteHere(nameof(VaType), value); }

        [Offset(48UL)]
        public uint PteFailures { get => ReadHere<uint>(nameof(PteFailures)); set => WriteHere(nameof(PteFailures), value); }

        [Offset(52UL)]
        public int SpinLock { get => ReadHere<int>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        [Offset(56UL)]
        public ulong TotalSystemPtes { get => ReadHere<ulong>(nameof(TotalSystemPtes)); set => WriteHere(nameof(TotalSystemPtes), value); }

        [Offset(64UL)]
        public ulong Hint { get => ReadHere<ulong>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        [Offset(72UL)]
        public ulong LowestBitEverAllocated { get => ReadHere<ulong>(nameof(LowestBitEverAllocated)); set => WriteHere(nameof(LowestBitEverAllocated), value); }

        [Offset(80UL)]
        public IntPtr CachedPtes { get => ReadHere<IntPtr>(nameof(CachedPtes)); set => WriteHere(nameof(CachedPtes), value); }

        [Offset(88UL)]
        public ulong TotalFreeSystemPtes { get => ReadHere<ulong>(nameof(TotalFreeSystemPtes)); set => WriteHere(nameof(TotalFreeSystemPtes), value); }

        public MiSystemPteType(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiSystemPteType>();
        }
    }
}