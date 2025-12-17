using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEA_XPF_MCA_SECTION")]
    public sealed class WheaXpfMcaSection : DynamicStructure
    {
        [Offset(0UL)]
        public uint VersionNumber { get => ReadHere<uint>(nameof(VersionNumber)); set => WriteHere(nameof(VersionNumber), value); }

        [Offset(4UL)]
        public uint CpuVendor { get => ReadHere<uint>(nameof(CpuVendor)); set => WriteHere(nameof(CpuVendor), value); }

        [Offset(8UL)]
        public LargeInteger Timestamp { get => ReadStructure<LargeInteger>(nameof(Timestamp)); set => WriteStructure(nameof(Timestamp), value); }

        [Offset(16UL)]
        public uint ProcessorNumber { get => ReadHere<uint>(nameof(ProcessorNumber)); set => WriteHere(nameof(ProcessorNumber), value); }

        [Offset(20UL)]
        public McgStatus GlobalStatus { get => ReadStructure<McgStatus>(nameof(GlobalStatus)); set => WriteStructure(nameof(GlobalStatus), value); }

        [Offset(28UL)]
        public ulong InstructionPointer { get => ReadHere<ulong>(nameof(InstructionPointer)); set => WriteHere(nameof(InstructionPointer), value); }

        [Offset(36UL)]
        public uint BankNumber { get => ReadHere<uint>(nameof(BankNumber)); set => WriteHere(nameof(BankNumber), value); }

        [Offset(40UL)]
        public MciStatus Status { get => ReadStructure<MciStatus>(nameof(Status)); set => WriteStructure(nameof(Status), value); }

        [Offset(48UL)]
        public ulong Address { get => ReadHere<ulong>(nameof(Address)); set => WriteHere(nameof(Address), value); }

        [Offset(56UL)]
        public ulong Misc { get => ReadHere<ulong>(nameof(Misc)); set => WriteHere(nameof(Misc), value); }

        [Offset(64UL)]
        public uint ExtendedRegisterCount { get => ReadHere<uint>(nameof(ExtendedRegisterCount)); set => WriteHere(nameof(ExtendedRegisterCount), value); }

        [Offset(68UL)]
        public uint ApicId { get => ReadHere<uint>(nameof(ApicId)); set => WriteHere(nameof(ApicId), value); }

        [Offset(72UL)]
        [Length(24)]
        public DynamicArray ExtendedRegisters { get => ReadStructure<DynamicArray>(nameof(ExtendedRegisters)); set => WriteStructure(nameof(ExtendedRegisters), value); }

        [Offset(72UL)]
        public WheaAmdExtendedRegisters AMDExtendedRegisters { get => ReadStructure<WheaAmdExtendedRegisters>(nameof(AMDExtendedRegisters)); set => WriteStructure(nameof(AMDExtendedRegisters), value); }

        [Offset(264UL)]
        public McgCap GlobalCapability { get => ReadStructure<McgCap>(nameof(GlobalCapability)); set => WriteStructure(nameof(GlobalCapability), value); }

        [Offset(272UL)]
        public XpfRecoveryInfo RecoveryInfo { get => ReadStructure<XpfRecoveryInfo>(nameof(RecoveryInfo)); set => WriteStructure(nameof(RecoveryInfo), value); }

        [Offset(292UL)]
        public uint ExBankCount { get => ReadHere<uint>(nameof(ExBankCount)); set => WriteHere(nameof(ExBankCount), value); }

        [Offset(296UL)]
        [Length(32)]
        public DynamicArray BankNumberEx { get => ReadStructure<DynamicArray>(nameof(BankNumberEx)); set => WriteStructure(nameof(BankNumberEx), value); }

        [Offset(424UL)]
        [Length(32)]
        public DynamicArray StatusEx { get => ReadStructure<DynamicArray>(nameof(StatusEx)); set => WriteStructure(nameof(StatusEx), value); }

        [Offset(680UL)]
        [Length(32)]
        public DynamicArray AddressEx { get => ReadStructure<DynamicArray>(nameof(AddressEx)); set => WriteStructure(nameof(AddressEx), value); }

        [Offset(936UL)]
        [Length(32)]
        public DynamicArray MiscEx { get => ReadStructure<DynamicArray>(nameof(MiscEx)); set => WriteStructure(nameof(MiscEx), value); }

        public WheaXpfMcaSection(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheaXpfMcaSection>();
        }
    }
}