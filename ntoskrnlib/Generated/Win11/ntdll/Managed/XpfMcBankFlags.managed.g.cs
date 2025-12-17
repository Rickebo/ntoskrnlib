using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_XPF_MC_BANK_FLAGS")]
    public sealed class XpfMcBankFlags : DynamicStructure
    {
        [Offset(0UL)]
        public byte ClearOnInitializationRW { get => ReadHere<byte>(nameof(ClearOnInitializationRW)); set => WriteHere(nameof(ClearOnInitializationRW), value); }

        [Offset(0UL)]
        public byte ControlDataRW { get => ReadHere<byte>(nameof(ControlDataRW)); set => WriteHere(nameof(ControlDataRW), value); }

        [Offset(0UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public byte AsUCHAR { get => ReadHere<byte>(nameof(AsUCHAR)); set => WriteHere(nameof(AsUCHAR), value); }

        public XpfMcBankFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XpfMcBankFlags>();
        }
    }
}