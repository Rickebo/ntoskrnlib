using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_LOADER_PARAMETER_CI_EXTENSION")]
    public sealed class _LOADER_PARAMETER_CI_EXTENSION : DynamicStructure
    {
        public uint CodeIntegrityOptions { get; }
        public uint UpgradeInProgress { get; }
        public uint IsWinPE { get; }
        public uint CustomKernelSignersAllowed { get; }
        public uint StateSeparationEnabled { get; }
        public uint Reserved { get; }
        public _LARGE_INTEGER WhqlEnforcementDate { get; }
        public uint RevocationListOffset { get; }
        public uint RevocationListSize { get; }
        public uint CodeIntegrityPolicyOffset { get; }
        public uint CodeIntegrityPolicySize { get; }
        public uint CodeIntegrityPolicyHashOffset { get; }
        public uint CodeIntegrityPolicyHashSize { get; }
        public uint CodeIntegrityPolicyOriginalHashOffset { get; }
        public uint CodeIntegrityPolicyOriginalHashSize { get; }
        public int WeakCryptoPolicyLoadStatus { get; }
        public uint WeakCryptoPolicyOffset { get; }
        public uint WeakCryptoPolicySize { get; }
        public uint SecureBootPolicyOffset { get; }
        public uint SecureBootPolicySize { get; }
        public uint CurrentBootId { get; }
        public _LARGE_INTEGER RevocationListCreationTimeLCUType { get; }
        public _LARGE_INTEGER RevocationListCreationTimeLCUAntidoteType { get; }
        public _LARGE_INTEGER RevocationListCreationTimeUpdateType { get; }
        public _LARGE_INTEGER RevocationListCreationTimeUpdateAntidoteType { get; }
        public uint CurrentRevocationListType { get; }
        public uint Reserved2 { get; }
        public byte[] SerializedData { get; }

        public _LOADER_PARAMETER_CI_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _LOADER_PARAMETER_CI_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityOptions),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.UpgradeInProgress),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.IsWinPE),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CustomKernelSignersAllowed),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.StateSeparationEnabled),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.WhqlEnforcementDate),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.RevocationListOffset),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.RevocationListSize),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityPolicyOffset),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityPolicySize),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityPolicyHashOffset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityPolicyHashSize),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityPolicyOriginalHashOffset),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CodeIntegrityPolicyOriginalHashSize),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.WeakCryptoPolicyLoadStatus),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.WeakCryptoPolicyOffset),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.WeakCryptoPolicySize),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.SecureBootPolicyOffset),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.SecureBootPolicySize),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CurrentBootId),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.RevocationListCreationTimeLCUType),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.RevocationListCreationTimeLCUAntidoteType),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.RevocationListCreationTimeUpdateType),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.RevocationListCreationTimeUpdateAntidoteType),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.CurrentRevocationListType),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.Reserved2),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_LOADER_PARAMETER_CI_EXTENSION.SerializedData),
                    new ulong[]
                    {
                        112UL
                    }
                }
            };
            Register<_LOADER_PARAMETER_CI_EXTENSION>((mem, ptr) => new _LOADER_PARAMETER_CI_EXTENSION(mem, ptr), offsets);
        }
    }
}