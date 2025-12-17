using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AMD64_DBGKD_CONTROL_SET")]
    public sealed class AMD64DbgkdControlSet : DynamicStructure
    {
        [Offset(0UL)]
        public uint TraceFlag { get => ReadHere<uint>(nameof(TraceFlag)); set => WriteHere(nameof(TraceFlag), value); }

        [Offset(4UL)]
        public ulong Dr7 { get => ReadHere<ulong>(nameof(Dr7)); set => WriteHere(nameof(Dr7), value); }

        [Offset(12UL)]
        public ulong CurrentSymbolStart { get => ReadHere<ulong>(nameof(CurrentSymbolStart)); set => WriteHere(nameof(CurrentSymbolStart), value); }

        [Offset(20UL)]
        public ulong CurrentSymbolEnd { get => ReadHere<ulong>(nameof(CurrentSymbolEnd)); set => WriteHere(nameof(CurrentSymbolEnd), value); }

        public AMD64DbgkdControlSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AMD64DbgkdControlSet>();
        }
    }
}