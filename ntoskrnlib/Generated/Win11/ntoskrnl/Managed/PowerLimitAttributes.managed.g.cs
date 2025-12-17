using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POWER_LIMIT_ATTRIBUTES")]
    public sealed class PowerLimitAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint DomainId { get => ReadHere<uint>(nameof(DomainId)); set => WriteHere(nameof(DomainId), value); }

        [Offset(8UL)]
        public uint MaxValue { get => ReadHere<uint>(nameof(MaxValue)); set => WriteHere(nameof(MaxValue), value); }

        [Offset(12UL)]
        public uint MinValue { get => ReadHere<uint>(nameof(MinValue)); set => WriteHere(nameof(MinValue), value); }

        [Offset(16UL)]
        public uint MinTimeParameter { get => ReadHere<uint>(nameof(MinTimeParameter)); set => WriteHere(nameof(MinTimeParameter), value); }

        [Offset(20UL)]
        public uint MaxTimeParameter { get => ReadHere<uint>(nameof(MaxTimeParameter)); set => WriteHere(nameof(MaxTimeParameter), value); }

        [Offset(24UL)]
        public uint DefaultACValue { get => ReadHere<uint>(nameof(DefaultACValue)); set => WriteHere(nameof(DefaultACValue), value); }

        [Offset(28UL)]
        public uint DefaultDCValue { get => ReadHere<uint>(nameof(DefaultDCValue)); set => WriteHere(nameof(DefaultDCValue), value); }

        [Offset(32UL)]
        public UnnamedTag Flags { get => ReadStructure<UnnamedTag>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        public PowerLimitAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PowerLimitAttributes>();
        }
    }
}