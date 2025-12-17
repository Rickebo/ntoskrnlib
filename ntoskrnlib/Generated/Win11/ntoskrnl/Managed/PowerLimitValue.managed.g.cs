using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POWER_LIMIT_VALUE")]
    public sealed class PowerLimitValue : DynamicStructure
    {
        [Offset(0UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(4UL)]
        public uint DomainId { get => ReadHere<uint>(nameof(DomainId)); set => WriteHere(nameof(DomainId), value); }

        [Offset(8UL)]
        public uint TargetValue { get => ReadHere<uint>(nameof(TargetValue)); set => WriteHere(nameof(TargetValue), value); }

        [Offset(12UL)]
        public uint TimeParameter { get => ReadHere<uint>(nameof(TimeParameter)); set => WriteHere(nameof(TimeParameter), value); }

        public PowerLimitValue(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PowerLimitValue>();
        }
    }
}