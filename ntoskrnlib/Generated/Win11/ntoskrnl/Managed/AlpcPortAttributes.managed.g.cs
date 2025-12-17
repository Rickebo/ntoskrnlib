using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ALPC_PORT_ATTRIBUTES")]
    public sealed class AlpcPortAttributes : DynamicStructure
    {
        [Offset(0UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(4UL)]
        public SecurityQualityOfService SecurityQos { get => ReadStructure<SecurityQualityOfService>(nameof(SecurityQos)); set => WriteStructure(nameof(SecurityQos), value); }

        [Offset(16UL)]
        public ulong MaxMessageLength { get => ReadHere<ulong>(nameof(MaxMessageLength)); set => WriteHere(nameof(MaxMessageLength), value); }

        [Offset(24UL)]
        public ulong MemoryBandwidth { get => ReadHere<ulong>(nameof(MemoryBandwidth)); set => WriteHere(nameof(MemoryBandwidth), value); }

        [Offset(32UL)]
        public ulong MaxPoolUsage { get => ReadHere<ulong>(nameof(MaxPoolUsage)); set => WriteHere(nameof(MaxPoolUsage), value); }

        [Offset(40UL)]
        public ulong MaxSectionSize { get => ReadHere<ulong>(nameof(MaxSectionSize)); set => WriteHere(nameof(MaxSectionSize), value); }

        [Offset(48UL)]
        public ulong MaxViewSize { get => ReadHere<ulong>(nameof(MaxViewSize)); set => WriteHere(nameof(MaxViewSize), value); }

        [Offset(56UL)]
        public ulong MaxTotalSectionSize { get => ReadHere<ulong>(nameof(MaxTotalSectionSize)); set => WriteHere(nameof(MaxTotalSectionSize), value); }

        [Offset(64UL)]
        public uint DupObjectTypes { get => ReadHere<uint>(nameof(DupObjectTypes)); set => WriteHere(nameof(DupObjectTypes), value); }

        [Offset(68UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        public AlpcPortAttributes(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<AlpcPortAttributes>();
        }
    }
}