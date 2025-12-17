using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAULT_INFORMATION_ARM64_FLAGS")]
    public sealed class FaultInformationARM64Flags : DynamicStructure
    {
        [Offset(0UL)]
        public uint WriteNotRead { get => ReadHere<uint>(nameof(WriteNotRead)); set => WriteHere(nameof(WriteNotRead), value); }

        [Offset(0UL)]
        public uint InstructionNotData { get => ReadHere<uint>(nameof(InstructionNotData)); set => WriteHere(nameof(InstructionNotData), value); }

        [Offset(0UL)]
        public uint Privileged { get => ReadHere<uint>(nameof(Privileged)); set => WriteHere(nameof(Privileged), value); }

        [Offset(0UL)]
        public uint FaultAddressValid { get => ReadHere<uint>(nameof(FaultAddressValid)); set => WriteHere(nameof(FaultAddressValid), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public FaultInformationARM64Flags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FaultInformationARM64Flags>();
        }
    }
}