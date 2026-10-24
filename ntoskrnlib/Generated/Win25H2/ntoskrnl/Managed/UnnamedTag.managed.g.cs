using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win25H2.ntoskrnl
{
    [DynamicStructure("ntoskrnl!<unnamed-tag>")]
    public sealed class UnnamedTag : DynamicStructure
    {
        [Offset(0UL)]
        public uint ControlFlowGuardEnabled { get => ReadHere<uint>(nameof(ControlFlowGuardEnabled)); set => WriteHere(nameof(ControlFlowGuardEnabled), value); }

        [Offset(0UL)]
        public uint ControlFlowGuardExportSuppressionEnabled { get => ReadHere<uint>(nameof(ControlFlowGuardExportSuppressionEnabled)); set => WriteHere(nameof(ControlFlowGuardExportSuppressionEnabled), value); }

        [Offset(0UL)]
        public uint ControlFlowGuardStrict { get => ReadHere<uint>(nameof(ControlFlowGuardStrict)); set => WriteHere(nameof(ControlFlowGuardStrict), value); }

        [Offset(0UL)]
        public uint DisallowStrippedImages { get => ReadHere<uint>(nameof(DisallowStrippedImages)); set => WriteHere(nameof(DisallowStrippedImages), value); }

        [Offset(0UL)]
        public uint ForceRelocateImages { get => ReadHere<uint>(nameof(ForceRelocateImages)); set => WriteHere(nameof(ForceRelocateImages), value); }

        [Offset(0UL)]
        public uint HighEntropyASLREnabled { get => ReadHere<uint>(nameof(HighEntropyASLREnabled)); set => WriteHere(nameof(HighEntropyASLREnabled), value); }

        [Offset(0UL)]
        public uint StackRandomizationDisabled { get => ReadHere<uint>(nameof(StackRandomizationDisabled)); set => WriteHere(nameof(StackRandomizationDisabled), value); }

        [Offset(0UL)]
        public uint ExtensionPointDisable { get => ReadHere<uint>(nameof(ExtensionPointDisable)); set => WriteHere(nameof(ExtensionPointDisable), value); }

        [Offset(0UL)]
        public uint DisableDynamicCode { get => ReadHere<uint>(nameof(DisableDynamicCode)); set => WriteHere(nameof(DisableDynamicCode), value); }

        [Offset(0UL)]
        public uint DisableDynamicCodeAllowOptOut { get => ReadHere<uint>(nameof(DisableDynamicCodeAllowOptOut)); set => WriteHere(nameof(DisableDynamicCodeAllowOptOut), value); }

        [Offset(0UL)]
        public uint DisableDynamicCodeAllowRemoteDowngrade { get => ReadHere<uint>(nameof(DisableDynamicCodeAllowRemoteDowngrade)); set => WriteHere(nameof(DisableDynamicCodeAllowRemoteDowngrade), value); }

        [Offset(0UL)]
        public uint AuditDisableDynamicCode { get => ReadHere<uint>(nameof(AuditDisableDynamicCode)); set => WriteHere(nameof(AuditDisableDynamicCode), value); }

        [Offset(0UL)]
        public uint DisallowWin32kSystemCalls { get => ReadHere<uint>(nameof(DisallowWin32kSystemCalls)); set => WriteHere(nameof(DisallowWin32kSystemCalls), value); }

        [Offset(0UL)]
        public uint AuditDisallowWin32kSystemCalls { get => ReadHere<uint>(nameof(AuditDisallowWin32kSystemCalls)); set => WriteHere(nameof(AuditDisallowWin32kSystemCalls), value); }

        [Offset(0UL)]
        public uint EnableFilteredWin32kAPIs { get => ReadHere<uint>(nameof(EnableFilteredWin32kAPIs)); set => WriteHere(nameof(EnableFilteredWin32kAPIs), value); }

        [Offset(0UL)]
        public uint AuditFilteredWin32kAPIs { get => ReadHere<uint>(nameof(AuditFilteredWin32kAPIs)); set => WriteHere(nameof(AuditFilteredWin32kAPIs), value); }

        [Offset(0UL)]
        public uint DisableNonSystemFonts { get => ReadHere<uint>(nameof(DisableNonSystemFonts)); set => WriteHere(nameof(DisableNonSystemFonts), value); }

        [Offset(0UL)]
        public uint AuditNonSystemFontLoading { get => ReadHere<uint>(nameof(AuditNonSystemFontLoading)); set => WriteHere(nameof(AuditNonSystemFontLoading), value); }

        [Offset(0UL)]
        public uint PreferSystem32Images { get => ReadHere<uint>(nameof(PreferSystem32Images)); set => WriteHere(nameof(PreferSystem32Images), value); }

        [Offset(0UL)]
        public uint ProhibitRemoteImageMap { get => ReadHere<uint>(nameof(ProhibitRemoteImageMap)); set => WriteHere(nameof(ProhibitRemoteImageMap), value); }

        [Offset(0UL)]
        public uint AuditProhibitRemoteImageMap { get => ReadHere<uint>(nameof(AuditProhibitRemoteImageMap)); set => WriteHere(nameof(AuditProhibitRemoteImageMap), value); }

        [Offset(0UL)]
        public uint ProhibitLowILImageMap { get => ReadHere<uint>(nameof(ProhibitLowILImageMap)); set => WriteHere(nameof(ProhibitLowILImageMap), value); }

        [Offset(0UL)]
        public uint AuditProhibitLowILImageMap { get => ReadHere<uint>(nameof(AuditProhibitLowILImageMap)); set => WriteHere(nameof(AuditProhibitLowILImageMap), value); }

        [Offset(0UL)]
        public uint SignatureMitigationOptIn { get => ReadHere<uint>(nameof(SignatureMitigationOptIn)); set => WriteHere(nameof(SignatureMitigationOptIn), value); }

        [Offset(0UL)]
        public uint AuditBlockNonMicrosoftBinaries { get => ReadHere<uint>(nameof(AuditBlockNonMicrosoftBinaries)); set => WriteHere(nameof(AuditBlockNonMicrosoftBinaries), value); }

        [Offset(0UL)]
        public uint AuditBlockNonMicrosoftBinariesAllowStore { get => ReadHere<uint>(nameof(AuditBlockNonMicrosoftBinariesAllowStore)); set => WriteHere(nameof(AuditBlockNonMicrosoftBinariesAllowStore), value); }

        [Offset(0UL)]
        public uint LoaderIntegrityContinuityEnabled { get => ReadHere<uint>(nameof(LoaderIntegrityContinuityEnabled)); set => WriteHere(nameof(LoaderIntegrityContinuityEnabled), value); }

        [Offset(0UL)]
        public uint AuditLoaderIntegrityContinuity { get => ReadHere<uint>(nameof(AuditLoaderIntegrityContinuity)); set => WriteHere(nameof(AuditLoaderIntegrityContinuity), value); }

        [Offset(0UL)]
        public uint EnableModuleTamperingProtection { get => ReadHere<uint>(nameof(EnableModuleTamperingProtection)); set => WriteHere(nameof(EnableModuleTamperingProtection), value); }

        [Offset(0UL)]
        public uint EnableModuleTamperingProtectionNoInherit { get => ReadHere<uint>(nameof(EnableModuleTamperingProtectionNoInherit)); set => WriteHere(nameof(EnableModuleTamperingProtectionNoInherit), value); }

        [Offset(0UL)]
        public uint RestrictIndirectBranchPrediction { get => ReadHere<uint>(nameof(RestrictIndirectBranchPrediction)); set => WriteHere(nameof(RestrictIndirectBranchPrediction), value); }

        [Offset(0UL)]
        public uint IsolateSecurityDomain { get => ReadHere<uint>(nameof(IsolateSecurityDomain)); set => WriteHere(nameof(IsolateSecurityDomain), value); }

        public UnnamedTag(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<UnnamedTag>();
        }
    }
}