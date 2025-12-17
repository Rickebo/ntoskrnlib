using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_MCE_DESCRIPTOR")]
    public sealed class WheaXpfMceDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(3UL)]
        public byte NumberOfBanks { get => ReadHere<byte>(nameof(NumberOfBanks)); set => WriteHere(nameof(NumberOfBanks), value); }

        [Offset(4UL)]
        public XpfMceFlags Flags { get => ReadStructure<XpfMceFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(8UL)]
        public ulong MCG_Capability { get => ReadHere<ulong>(nameof(MCG_Capability)); set => WriteHere(nameof(MCG_Capability), value); }

        [Offset(16UL)]
        public ulong MCG_GlobalControl { get => ReadHere<ulong>(nameof(MCG_GlobalControl)); set => WriteHere(nameof(MCG_GlobalControl), value); }

        [Offset(24UL)]
        [Length(32)]
        public DynamicArray Banks { get => ReadStructure<DynamicArray>(nameof(Banks)); set => WriteStructure(nameof(Banks), value); }

        public WheaXpfMceDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaXpfMceDescriptor>();
        }
    }
}