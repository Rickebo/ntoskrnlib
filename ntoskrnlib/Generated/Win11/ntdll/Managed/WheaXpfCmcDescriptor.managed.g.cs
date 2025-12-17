using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_XPF_CMC_DESCRIPTOR")]
    public sealed class WheaXpfCmcDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Type { get => ReadHere<ushort>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(2UL)]
        public byte Enabled { get => ReadHere<byte>(nameof(Enabled)); set => WriteHere(nameof(Enabled), value); }

        [Offset(3UL)]
        public byte NumberOfBanks { get => ReadHere<byte>(nameof(NumberOfBanks)); set => WriteHere(nameof(NumberOfBanks), value); }

        [Offset(4UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public WheaNotificationDescriptor Notify { get => ReadStructure<WheaNotificationDescriptor>(nameof(Notify)); set => WriteStructure(nameof(Notify), value); }

        [Offset(36UL)]
        [Length(32)]
        public DynamicArray Banks { get => ReadStructure<DynamicArray>(nameof(Banks)); set => WriteStructure(nameof(Banks), value); }

        public WheaXpfCmcDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaXpfCmcDescriptor>();
        }
    }
}