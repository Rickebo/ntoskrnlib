using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_RECOVERY_CONTEXT_ACTION_TAKEN_ADDITIONAL_INFO")]
    public sealed class WheaRecoveryContextActionTakenAdditionalInfo : DynamicStructure
    {
        [Offset(0UL)]
        public UnnamedTag Bits { get => ReadStructure<UnnamedTag>(nameof(Bits)); set => WriteStructure(nameof(Bits), value); }

        [Offset(0UL)]
        public ulong AsULONG64 { get => ReadHere<ulong>(nameof(AsULONG64)); set => WriteHere(nameof(AsULONG64), value); }

        public WheaRecoveryContextActionTakenAdditionalInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaRecoveryContextActionTakenAdditionalInfo>();
        }
    }
}