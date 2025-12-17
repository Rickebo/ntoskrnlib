using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MCG_CAP")]
    public sealed class McgCap : DynamicStructure
    {
        [Offset(0UL)]
        public ulong CountField { get => ReadHere<ulong>(nameof(CountField)); set => WriteHere(nameof(CountField), value); }

        [Offset(0UL)]
        public ulong ControlMsrPresent { get => ReadHere<ulong>(nameof(ControlMsrPresent)); set => WriteHere(nameof(ControlMsrPresent), value); }

        [Offset(0UL)]
        public ulong ExtendedMsrsPresent { get => ReadHere<ulong>(nameof(ExtendedMsrsPresent)); set => WriteHere(nameof(ExtendedMsrsPresent), value); }

        [Offset(0UL)]
        public ulong SignalingExtensionPresent { get => ReadHere<ulong>(nameof(SignalingExtensionPresent)); set => WriteHere(nameof(SignalingExtensionPresent), value); }

        [Offset(0UL)]
        public ulong ThresholdErrorStatusPresent { get => ReadHere<ulong>(nameof(ThresholdErrorStatusPresent)); set => WriteHere(nameof(ThresholdErrorStatusPresent), value); }

        [Offset(0UL)]
        public ulong Reserved { get => ReadHere<ulong>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public ulong ExtendedRegisterCount { get => ReadHere<ulong>(nameof(ExtendedRegisterCount)); set => WriteHere(nameof(ExtendedRegisterCount), value); }

        [Offset(0UL)]
        public ulong SoftwareErrorRecoverySupported { get => ReadHere<ulong>(nameof(SoftwareErrorRecoverySupported)); set => WriteHere(nameof(SoftwareErrorRecoverySupported), value); }

        [Offset(0UL)]
        public ulong EnhancedMachineCheckCapability { get => ReadHere<ulong>(nameof(EnhancedMachineCheckCapability)); set => WriteHere(nameof(EnhancedMachineCheckCapability), value); }

        [Offset(0UL)]
        public ulong ExtendedErrorLogging { get => ReadHere<ulong>(nameof(ExtendedErrorLogging)); set => WriteHere(nameof(ExtendedErrorLogging), value); }

        [Offset(0UL)]
        public ulong LocalMachineCheckException { get => ReadHere<ulong>(nameof(LocalMachineCheckException)); set => WriteHere(nameof(LocalMachineCheckException), value); }

        [Offset(0UL)]
        public ulong QuadPart { get => ReadHere<ulong>(nameof(QuadPart)); set => WriteHere(nameof(QuadPart), value); }

        public McgCap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<McgCap>();
        }
    }
}