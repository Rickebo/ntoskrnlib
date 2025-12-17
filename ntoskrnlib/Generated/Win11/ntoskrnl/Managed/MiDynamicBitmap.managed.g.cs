using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MI_DYNAMIC_BITMAP")]
    public sealed class MiDynamicBitmap : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBitmapEx Bitmap { get => ReadStructure<RtlBitmapEx>(nameof(Bitmap)); set => WriteStructure(nameof(Bitmap), value); }

        [Offset(16UL)]
        public ulong MaximumSize { get => ReadHere<ulong>(nameof(MaximumSize)); set => WriteHere(nameof(MaximumSize), value); }

        [Offset(24UL)]
        public ulong Hint { get => ReadHere<ulong>(nameof(Hint)); set => WriteHere(nameof(Hint), value); }

        [Offset(32UL)]
        public IntPtr BaseVa { get => ReadHere<IntPtr>(nameof(BaseVa)); set => WriteHere(nameof(BaseVa), value); }

        [Offset(40UL)]
        public ulong SizeTopDown { get => ReadHere<ulong>(nameof(SizeTopDown)); set => WriteHere(nameof(SizeTopDown), value); }

        [Offset(48UL)]
        public ulong HintTopDown { get => ReadHere<ulong>(nameof(HintTopDown)); set => WriteHere(nameof(HintTopDown), value); }

        [Offset(56UL)]
        public IntPtr BaseVaTopDown { get => ReadHere<IntPtr>(nameof(BaseVaTopDown)); set => WriteHere(nameof(BaseVaTopDown), value); }

        [Offset(64UL)]
        public int SpinLock { get => ReadHere<int>(nameof(SpinLock)); set => WriteHere(nameof(SpinLock), value); }

        public MiDynamicBitmap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MiDynamicBitmap>();
        }
    }
}