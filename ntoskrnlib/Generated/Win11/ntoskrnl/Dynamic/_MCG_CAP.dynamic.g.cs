using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCG_CAP")]
    public sealed class _MCG_CAP : DynamicStructure
    {
        public ulong CountField { get; }
        public ulong ControlMsrPresent { get; }
        public ulong ExtendedMsrsPresent { get; }
        public ulong SignalingExtensionPresent { get; }
        public ulong ThresholdErrorStatusPresent { get; }
        public ulong Reserved { get; }
        public ulong ExtendedRegisterCount { get; }
        public ulong SoftwareErrorRecoverySupported { get; }
        public ulong EnhancedMachineCheckCapability { get; }
        public ulong ExtendedErrorLogging { get; }
        public ulong LocalMachineCheckException { get; }
        public ulong QuadPart { get; }

        public _MCG_CAP(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCG_CAP()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCG_CAP.CountField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.ControlMsrPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.ExtendedMsrsPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.SignalingExtensionPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.ThresholdErrorStatusPresent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.ExtendedRegisterCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.SoftwareErrorRecoverySupported),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.EnhancedMachineCheckCapability),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.ExtendedErrorLogging),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.LocalMachineCheckException),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_CAP.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCG_CAP>((mem, ptr) => new _MCG_CAP(mem, ptr), offsets);
        }
    }
}