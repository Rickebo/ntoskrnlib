using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TOKEN_ACCESS_INFORMATION")]
    public sealed class _TOKEN_ACCESS_INFORMATION : DynamicStructure
    {
        public IntPtr SidHash { get; }
        public IntPtr RestrictedSidHash { get; }
        public IntPtr Privileges { get; }
        public _LUID AuthenticationId { get; }
        public uint TokenType { get; }
        public uint ImpersonationLevel { get; }
        public _TOKEN_MANDATORY_POLICY MandatoryPolicy { get; }
        public uint Flags { get; }
        public uint AppContainerNumber { get; }
        public IntPtr PackageSid { get; }
        public IntPtr CapabilitiesHash { get; }
        public IntPtr TrustLevelSid { get; }
        public IntPtr SecurityAttributes { get; }

        public _TOKEN_ACCESS_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TOKEN_ACCESS_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.SidHash),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.RestrictedSidHash),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.Privileges),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.AuthenticationId),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.TokenType),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.ImpersonationLevel),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.MandatoryPolicy),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.Flags),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.AppContainerNumber),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.PackageSid),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.CapabilitiesHash),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.TrustLevelSid),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_TOKEN_ACCESS_INFORMATION.SecurityAttributes),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_TOKEN_ACCESS_INFORMATION>((mem, ptr) => new _TOKEN_ACCESS_INFORMATION(mem, ptr), offsets);
        }
    }
}