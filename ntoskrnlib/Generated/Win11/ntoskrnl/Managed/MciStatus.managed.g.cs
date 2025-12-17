using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCI_STATUS")]
    public sealed class MciStatus : DynamicStructure
    {
        [Offset(0UL)]
        public MciStatusBitsCommon CommonBits { get => ReadStructure<MciStatusBitsCommon>(nameof(CommonBits)); set => WriteStructure(nameof(CommonBits), value); }

        [Offset(0UL)]
        public MciStatusAmdBits AmdBits { get => ReadStructure<MciStatusAmdBits>(nameof(AmdBits)); set => WriteStructure(nameof(AmdBits), value); }

        [Offset(0UL)]
        public MciStatusIntelBits IntelBits { get => ReadStructure<MciStatusIntelBits>(nameof(IntelBits)); set => WriteStructure(nameof(IntelBits), value); }

        [Offset(0UL)]
        public ulong QuadPart { get => ReadHere<ulong>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public MciStatus(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MciStatus>();
        }
    }
}