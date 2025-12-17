using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_X86_DBGKD_CONTROL_SET")]
    public sealed class X86DbgkdControlSet : DynamicStructure
    {
        [Offset(0UL)]
        public uint TraceFlag { get => ReadHere<uint>(nameof(TraceFlag)); set => WriteHere(nameof(TraceFlag), value); }

        [Offset(4UL)]
        public uint Dr7 { get => ReadHere<uint>(nameof(Dr7)); set => WriteHere(nameof(Dr7), value); }

        [Offset(8UL)]
        public uint CurrentSymbolStart { get => ReadHere<uint>(nameof(CurrentSymbolStart)); set => WriteHere(nameof(CurrentSymbolStart), value); }

        [Offset(12UL)]
        public uint CurrentSymbolEnd { get => ReadHere<uint>(nameof(CurrentSymbolEnd)); set => WriteHere(nameof(CurrentSymbolEnd), value); }

        public X86DbgkdControlSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<X86DbgkdControlSet>();
        }
    }
}