using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ARM_DBGKD_CONTROL_SET")]
    public sealed class ArmDbgkdControlSet : DynamicStructure
    {
        [Offset(0UL)]
        public uint Continue { get => ReadHere<uint>(nameof(Continue)); set => WriteHere(nameof(Continue), value); }

        [Offset(4UL)]
        public uint CurrentSymbolStart { get => ReadHere<uint>(nameof(CurrentSymbolStart)); set => WriteHere(nameof(CurrentSymbolStart), value); }

        [Offset(8UL)]
        public uint CurrentSymbolEnd { get => ReadHere<uint>(nameof(CurrentSymbolEnd)); set => WriteHere(nameof(CurrentSymbolEnd), value); }

        public ArmDbgkdControlSet(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ArmDbgkdControlSet>();
        }
    }
}