using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_PACKET_FLAGS")]
    public sealed class _WHEA_ERROR_PACKET_FLAGS : DynamicStructure
    {
        public uint PreviousError { get; }
        public uint CriticalEvent { get; }
        public uint HypervisorError { get; }
        public uint Simulated { get; }
        public uint PlatformPfaControl { get; }
        public uint PlatformDirectedOffline { get; }
        public uint AddressTranslationRequired { get; }
        public uint AddressTranslationCompleted { get; }
        public uint RecoveryOptional { get; }
        public uint Reserved2 { get; }
        public uint AsULONG { get; }

        public _WHEA_ERROR_PACKET_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_PACKET_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.PreviousError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.CriticalEvent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.HypervisorError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.Simulated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.PlatformPfaControl),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.PlatformDirectedOffline),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.AddressTranslationRequired),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.AddressTranslationCompleted),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.RecoveryOptional),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.Reserved2),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_PACKET_FLAGS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_ERROR_PACKET_FLAGS>((mem, ptr) => new _WHEA_ERROR_PACKET_FLAGS(mem, ptr), offsets);
        }
    }
}