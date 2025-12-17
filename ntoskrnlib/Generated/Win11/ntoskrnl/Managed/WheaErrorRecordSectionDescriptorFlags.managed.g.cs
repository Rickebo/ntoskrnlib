using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_RECORD_SECTION_DESCRIPTOR_FLAGS")]
    public sealed class WheaErrorRecordSectionDescriptorFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Primary { get => ReadHere<uint>(nameof(Primary)); set => WriteHere(nameof(Primary), value); }

        [Offset(0UL)]
        public uint ContainmentWarning { get => ReadHere<uint>(nameof(ContainmentWarning)); set => WriteHere(nameof(ContainmentWarning), value); }

        [Offset(0UL)]
        public uint Reset { get => ReadHere<uint>(nameof(Reset)); set => WriteHere(nameof(Reset), value); }

        [Offset(0UL)]
        public uint ThresholdExceeded { get => ReadHere<uint>(nameof(ThresholdExceeded)); set => WriteHere(nameof(ThresholdExceeded), value); }

        [Offset(0UL)]
        public uint ResourceNotAvailable { get => ReadHere<uint>(nameof(ResourceNotAvailable)); set => WriteHere(nameof(ResourceNotAvailable), value); }

        [Offset(0UL)]
        public uint LatentError { get => ReadHere<uint>(nameof(LatentError)); set => WriteHere(nameof(LatentError), value); }

        [Offset(0UL)]
        public uint Propagated { get => ReadHere<uint>(nameof(Propagated)); set => WriteHere(nameof(Propagated), value); }

        [Offset(0UL)]
        public uint FruTextByPlugin { get => ReadHere<uint>(nameof(FruTextByPlugin)); set => WriteHere(nameof(FruTextByPlugin), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public WheaErrorRecordSectionDescriptorFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaErrorRecordSectionDescriptorFlags>();
        }
    }
}