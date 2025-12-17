using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WHEA_XPF_MC_BANK_DESCRIPTOR")]
    public sealed class WheaXpfMcBankDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public byte BankNumber { get => ReadHere<byte>(nameof(BankNumber)); set => WriteHere(nameof(BankNumber), value); }

        [Offset(1UL)]
        public byte ClearOnInitialization { get => ReadHere<byte>(nameof(ClearOnInitialization)); set => WriteHere(nameof(ClearOnInitialization), value); }

        [Offset(2UL)]
        public byte StatusDataFormat { get => ReadHere<byte>(nameof(StatusDataFormat)); set => WriteHere(nameof(StatusDataFormat), value); }

        [Offset(3UL)]
        public XpfMcBankFlags Flags { get => ReadStructure<XpfMcBankFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(4UL)]
        public uint ControlMsr { get => ReadHere<uint>(nameof(ControlMsr)); set => WriteHere(nameof(ControlMsr), value); }

        [Offset(8UL)]
        public uint StatusMsr { get => ReadHere<uint>(nameof(StatusMsr)); set => WriteHere(nameof(StatusMsr), value); }

        [Offset(12UL)]
        public uint AddressMsr { get => ReadHere<uint>(nameof(AddressMsr)); set => WriteHere(nameof(AddressMsr), value); }

        [Offset(16UL)]
        public uint MiscMsr { get => ReadHere<uint>(nameof(MiscMsr)); set => WriteHere(nameof(MiscMsr), value); }

        [Offset(20UL)]
        public ulong ControlData { get => ReadHere<ulong>(nameof(ControlData)); set => WriteHere(nameof(ControlData), value); }

        public WheaXpfMcBankDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaXpfMcBankDescriptor>();
        }
    }
}