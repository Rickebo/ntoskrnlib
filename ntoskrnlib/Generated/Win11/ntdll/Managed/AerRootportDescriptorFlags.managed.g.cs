using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_AER_ROOTPORT_DESCRIPTOR_FLAGS")]
    public sealed class AerRootportDescriptorFlags : DynamicStructure
    {
        [Offset(0UL)]
        public ushort UncorrectableErrorMaskRW { get => ReadHere<ushort>(nameof(UncorrectableErrorMaskRW)); set => WriteHere(nameof(UncorrectableErrorMaskRW), value); }

        [Offset(0UL)]
        public ushort UncorrectableErrorSeverityRW { get => ReadHere<ushort>(nameof(UncorrectableErrorSeverityRW)); set => WriteHere(nameof(UncorrectableErrorSeverityRW), value); }

        [Offset(0UL)]
        public ushort CorrectableErrorMaskRW { get => ReadHere<ushort>(nameof(CorrectableErrorMaskRW)); set => WriteHere(nameof(CorrectableErrorMaskRW), value); }

        [Offset(0UL)]
        public ushort AdvancedCapsAndControlRW { get => ReadHere<ushort>(nameof(AdvancedCapsAndControlRW)); set => WriteHere(nameof(AdvancedCapsAndControlRW), value); }

        [Offset(0UL)]
        public ushort RootErrorCommandRW { get => ReadHere<ushort>(nameof(RootErrorCommandRW)); set => WriteHere(nameof(RootErrorCommandRW), value); }

        [Offset(0UL)]
        public ushort Reserved { get => ReadHere<ushort>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ushort AsUSHORT { get => ReadHere<ushort>(nameof(AsUSHORT)); set => WriteHere(nameof(AsUSHORT), value); }

        public AerRootportDescriptorFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AerRootportDescriptorFlags>();
        }
    }
}