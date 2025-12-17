using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_X64_FLAGS")]
    public sealed class FaultInformationX64Flags : DynamicStructure
    {
        [Offset(0UL)]
        public uint FaultAddressValid { get => ReadHere<uint>(nameof(FaultAddressValid)); set => WriteHere(nameof(FaultAddressValid), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public FaultInformationX64Flags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FaultInformationX64Flags>();
        }
    }
}