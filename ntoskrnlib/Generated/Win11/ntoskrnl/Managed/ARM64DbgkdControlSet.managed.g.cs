using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARM64_DBGKD_CONTROL_SET")]
    public sealed class ARM64DbgkdControlSet : DynamicStructure
    {
        [Offset(0UL)]
        public uint Continue { get => ReadHere<uint>(nameof(Continue)); set => WriteHere(nameof(Continue), value); }

        [Offset(4UL)]
        public uint TraceFlag { get => ReadHere<uint>(nameof(TraceFlag)); set => WriteHere(nameof(TraceFlag), value); }

        [Offset(8UL)]
        public ulong CurrentSymbolStart { get => ReadHere<ulong>(nameof(CurrentSymbolStart)); set => WriteHere(nameof(CurrentSymbolStart), value); }

        [Offset(16UL)]
        public ulong CurrentSymbolEnd { get => ReadHere<ulong>(nameof(CurrentSymbolEnd)); set => WriteHere(nameof(CurrentSymbolEnd), value); }

        public ARM64DbgkdControlSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ARM64DbgkdControlSet>();
        }
    }
}