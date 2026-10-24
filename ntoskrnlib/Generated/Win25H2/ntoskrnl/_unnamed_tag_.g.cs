#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win25H2.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _unnamed_tag_
    {
        [FieldOffset(0)]
        public uint ControlFlowGuardEnabled;
        [FieldOffset(0)]
        public uint ControlFlowGuardExportSuppressionEnabled;
        [FieldOffset(0)]
        public uint ControlFlowGuardStrict;
        [FieldOffset(0)]
        public uint DisallowStrippedImages;
        [FieldOffset(0)]
        public uint ForceRelocateImages;
        [FieldOffset(0)]
        public uint HighEntropyASLREnabled;
        [FieldOffset(0)]
        public uint StackRandomizationDisabled;
        [FieldOffset(0)]
        public uint ExtensionPointDisable;
        [FieldOffset(0)]
        public uint DisableDynamicCode;
        [FieldOffset(0)]
        public uint DisableDynamicCodeAllowOptOut;
        [FieldOffset(0)]
        public uint DisableDynamicCodeAllowRemoteDowngrade;
        [FieldOffset(0)]
        public uint AuditDisableDynamicCode;
        [FieldOffset(0)]
        public uint DisallowWin32kSystemCalls;
        [FieldOffset(0)]
        public uint AuditDisallowWin32kSystemCalls;
        [FieldOffset(0)]
        public uint EnableFilteredWin32kAPIs;
        [FieldOffset(0)]
        public uint AuditFilteredWin32kAPIs;
        [FieldOffset(0)]
        public uint DisableNonSystemFonts;
        [FieldOffset(0)]
        public uint AuditNonSystemFontLoading;
        [FieldOffset(0)]
        public uint PreferSystem32Images;
        [FieldOffset(0)]
        public uint ProhibitRemoteImageMap;
        [FieldOffset(0)]
        public uint AuditProhibitRemoteImageMap;
        [FieldOffset(0)]
        public uint ProhibitLowILImageMap;
        [FieldOffset(0)]
        public uint AuditProhibitLowILImageMap;
        [FieldOffset(0)]
        public uint SignatureMitigationOptIn;
        [FieldOffset(0)]
        public uint AuditBlockNonMicrosoftBinaries;
        [FieldOffset(0)]
        public uint AuditBlockNonMicrosoftBinariesAllowStore;
        [FieldOffset(0)]
        public uint LoaderIntegrityContinuityEnabled;
        [FieldOffset(0)]
        public uint AuditLoaderIntegrityContinuity;
        [FieldOffset(0)]
        public uint EnableModuleTamperingProtection;
        [FieldOffset(0)]
        public uint EnableModuleTamperingProtectionNoInherit;
        [FieldOffset(0)]
        public uint RestrictIndirectBranchPrediction;
        [FieldOffset(0)]
        public uint IsolateSecurityDomain;
    }
}