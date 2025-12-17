using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_NT_IORING_OP_RESERVED")]
    public sealed class NtIoringOpReserved : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Argument1 { get => ReadHere<ulong>(nameof(Argument1)); set => WriteHere(nameof(Argument1), value); }

        [Offset(8UL)]
        public ulong Argument2 { get => ReadHere<ulong>(nameof(Argument2)); set => WriteHere(nameof(Argument2), value); }

        [Offset(16UL)]
        public ulong Argument3 { get => ReadHere<ulong>(nameof(Argument3)); set => WriteHere(nameof(Argument3), value); }

        [Offset(24UL)]
        public ulong Argument4 { get => ReadHere<ulong>(nameof(Argument4)); set => WriteHere(nameof(Argument4), value); }

        [Offset(32UL)]
        public ulong Argument5 { get => ReadHere<ulong>(nameof(Argument5)); set => WriteHere(nameof(Argument5), value); }

        [Offset(40UL)]
        public ulong Argument6 { get => ReadHere<ulong>(nameof(Argument6)); set => WriteHere(nameof(Argument6), value); }

        public NtIoringOpReserved(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<NtIoringOpReserved>();
        }
    }
}