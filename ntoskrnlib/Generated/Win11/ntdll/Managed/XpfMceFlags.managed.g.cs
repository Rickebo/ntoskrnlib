using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_XPF_MCE_FLAGS")]
    public sealed class XpfMceFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint MCG_CapabilityRW { get => ReadHere<uint>(nameof(MCG_CapabilityRW)); set => WriteHere(nameof(MCG_CapabilityRW), value); }

        [Offset(0UL)]
        public uint MCG_GlobalControlRW { get => ReadHere<uint>(nameof(MCG_GlobalControlRW)); set => WriteHere(nameof(MCG_GlobalControlRW), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public XpfMceFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<XpfMceFlags>();
        }
    }
}