using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IO_STATUS_BLOCK")]
    public sealed class IoStatusBlock : DynamicStructure
    {
        [Offset(0UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(0UL)]
        public IntPtr Pointer { get => ReadHere<IntPtr>(nameof(Pointer)); set => WriteHere(nameof(Pointer), value); }

        [Offset(8UL)]
        public ulong Information { get => ReadHere<ulong>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        public IoStatusBlock(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoStatusBlock>();
        }
    }
}