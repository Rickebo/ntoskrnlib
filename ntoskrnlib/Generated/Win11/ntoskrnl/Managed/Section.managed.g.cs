using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_SECTION")]
    public sealed class Section : DynamicStructure
    {
        [Offset(0UL)]
        public RtlBalancedNode SectionNode { get => ReadStructure<RtlBalancedNode>(nameof(SectionNode)); set => WriteStructure(nameof(SectionNode), value); }

        [Offset(24UL)]
        public ulong StartingVpn { get => ReadHere<ulong>(nameof(StartingVpn)); set => WriteHere(nameof(StartingVpn), value); }

        [Offset(32UL)]
        public ulong EndingVpn { get => ReadHere<ulong>(nameof(EndingVpn)); set => WriteHere(nameof(EndingVpn), value); }

        [Offset(40UL)]
        public UnnamedTag u1 { get => ReadStructure<UnnamedTag>(nameof(u1)); set => WriteStructure(nameof(u1), value); }

        [Offset(48UL)]
        public ulong SizeOfSection { get => ReadHere<ulong>(nameof(SizeOfSection)); set => WriteHere(nameof(SizeOfSection), value); }

        [Offset(56UL)]
        public UnnamedTag u { get => ReadStructure<UnnamedTag>(nameof(u)); set => WriteStructure(nameof(u), value); }

        [Offset(60UL)]
        public uint InitialPageProtection { get => ReadHere<uint>(nameof(InitialPageProtection)); set => WriteHere(nameof(InitialPageProtection), value); }

        [Offset(60UL)]
        public uint SessionId { get => ReadHere<uint>(nameof(SessionId)); set => WriteHere(nameof(SessionId), value); }

        [Offset(60UL)]
        public uint NoValidationNeeded { get => ReadHere<uint>(nameof(NoValidationNeeded)); set => WriteHere(nameof(NoValidationNeeded), value); }

        public Section(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Section>();
        }
    }
}