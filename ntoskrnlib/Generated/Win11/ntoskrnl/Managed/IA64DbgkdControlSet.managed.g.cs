using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_IA64_DBGKD_CONTROL_SET")]
    public sealed class IA64DbgkdControlSet : DynamicStructure
    {
        [Offset(0UL)]
        public uint Continue { get => ReadHere<uint>(nameof(Continue)); set => WriteHere(nameof(Continue), value); }

        [Offset(4UL)]
        public ulong CurrentSymbolStart { get => ReadHere<ulong>(nameof(CurrentSymbolStart)); set => WriteHere(nameof(CurrentSymbolStart), value); }

        [Offset(12UL)]
        public ulong CurrentSymbolEnd { get => ReadHere<ulong>(nameof(CurrentSymbolEnd)); set => WriteHere(nameof(CurrentSymbolEnd), value); }

        public IA64DbgkdControlSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IA64DbgkdControlSet>();
        }
    }
}