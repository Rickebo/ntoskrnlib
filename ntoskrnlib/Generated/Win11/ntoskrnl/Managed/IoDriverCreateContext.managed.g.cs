using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_DRIVER_CREATE_CONTEXT")]
    public sealed class IoDriverCreateContext : DynamicStructure
    {
        [Offset(0UL)]
        public short Size { get => ReadHere<short>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(8UL)]
        public IntPtr ExtraCreateParameter { get => ReadHere<IntPtr>(nameof(ExtraCreateParameter)); set => WriteHere(nameof(ExtraCreateParameter), value); }

        [Offset(16UL)]
        public IntPtr DeviceObjectHint { get => ReadHere<IntPtr>(nameof(DeviceObjectHint)); set => WriteHere(nameof(DeviceObjectHint), value); }

        [Offset(24UL)]
        public IntPtr TxnParameters { get => ReadHere<IntPtr>(nameof(TxnParameters)); set => WriteHere(nameof(TxnParameters), value); }

        [Offset(32UL)]
        public IntPtr SiloContext { get => ReadHere<IntPtr>(nameof(SiloContext)); set => WriteHere(nameof(SiloContext), value); }

        public IoDriverCreateContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoDriverCreateContext>();
        }
    }
}