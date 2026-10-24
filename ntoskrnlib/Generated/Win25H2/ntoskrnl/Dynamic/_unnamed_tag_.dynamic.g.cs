using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win25H2.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!<unnamed-tag>")]
    public sealed class _unnamed_tag_ : DynamicStructure
    {
        public uint ControlFlowGuardEnabled { get; }
        public uint ControlFlowGuardExportSuppressionEnabled { get; }
        public uint ControlFlowGuardStrict { get; }
        public uint DisallowStrippedImages { get; }
        public uint ForceRelocateImages { get; }
        public uint HighEntropyASLREnabled { get; }
        public uint StackRandomizationDisabled { get; }
        public uint ExtensionPointDisable { get; }
        public uint DisableDynamicCode { get; }
        public uint DisableDynamicCodeAllowOptOut { get; }
        public uint DisableDynamicCodeAllowRemoteDowngrade { get; }
        public uint AuditDisableDynamicCode { get; }
        public uint DisallowWin32kSystemCalls { get; }
        public uint AuditDisallowWin32kSystemCalls { get; }
        public uint EnableFilteredWin32kAPIs { get; }
        public uint AuditFilteredWin32kAPIs { get; }
        public uint DisableNonSystemFonts { get; }
        public uint AuditNonSystemFontLoading { get; }
        public uint PreferSystem32Images { get; }
        public uint ProhibitRemoteImageMap { get; }
        public uint AuditProhibitRemoteImageMap { get; }
        public uint ProhibitLowILImageMap { get; }
        public uint AuditProhibitLowILImageMap { get; }
        public uint SignatureMitigationOptIn { get; }
        public uint AuditBlockNonMicrosoftBinaries { get; }
        public uint AuditBlockNonMicrosoftBinariesAllowStore { get; }
        public uint LoaderIntegrityContinuityEnabled { get; }
        public uint AuditLoaderIntegrityContinuity { get; }
        public uint EnableModuleTamperingProtection { get; }
        public uint EnableModuleTamperingProtectionNoInherit { get; }
        public uint RestrictIndirectBranchPrediction { get; }
        public uint IsolateSecurityDomain { get; }

        public _unnamed_tag_(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _unnamed_tag_()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_unnamed_tag_.ControlFlowGuardEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.ControlFlowGuardExportSuppressionEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.ControlFlowGuardStrict),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.DisallowStrippedImages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.ForceRelocateImages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.HighEntropyASLREnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.StackRandomizationDisabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.ExtensionPointDisable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.DisableDynamicCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.DisableDynamicCodeAllowOptOut),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.DisableDynamicCodeAllowRemoteDowngrade),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditDisableDynamicCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.DisallowWin32kSystemCalls),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditDisallowWin32kSystemCalls),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.EnableFilteredWin32kAPIs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditFilteredWin32kAPIs),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.DisableNonSystemFonts),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditNonSystemFontLoading),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.PreferSystem32Images),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.ProhibitRemoteImageMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditProhibitRemoteImageMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.ProhibitLowILImageMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditProhibitLowILImageMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.SignatureMitigationOptIn),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditBlockNonMicrosoftBinaries),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditBlockNonMicrosoftBinariesAllowStore),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.LoaderIntegrityContinuityEnabled),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.AuditLoaderIntegrityContinuity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.EnableModuleTamperingProtection),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.EnableModuleTamperingProtectionNoInherit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.RestrictIndirectBranchPrediction),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_unnamed_tag_.IsolateSecurityDomain),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_unnamed_tag_>((mem, ptr) => new _unnamed_tag_(mem, ptr), offsets);
        }
    }
}