using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION")]
    public sealed class FaultInformation : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public byte IsStage1 { get => ReadHere<byte>(nameof(IsStage1)); set => WriteHere(nameof(IsStage1), value); }

        [Offset(8UL)]
        public FaultInformationARM64 Arm64 { get => ReadStructure<FaultInformationARM64>(nameof(Arm64)); set => WriteStructure(nameof(Arm64), value); }

        [Offset(8UL)]
        public FaultInformationX64 X64 { get => ReadStructure<FaultInformationX64>(nameof(X64)); set => WriteStructure(nameof(X64), value); }

        public FaultInformation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FaultInformation>();
        }
    }
}