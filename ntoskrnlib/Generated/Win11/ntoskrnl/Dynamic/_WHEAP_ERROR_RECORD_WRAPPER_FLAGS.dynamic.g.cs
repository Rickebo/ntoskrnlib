using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_RECORD_WRAPPER_FLAGS")]
    public sealed class _WHEAP_ERROR_RECORD_WRAPPER_FLAGS : DynamicStructure
    {
        public uint Preallocated { get; }
        public uint FromPersistentStore { get; }
        public uint PlatformPfaControl { get; }
        public uint PlatformDirectedOffline { get; }
        public uint Reserved { get; }
        public uint AsULONG { get; }

        public _WHEAP_ERROR_RECORD_WRAPPER_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEAP_ERROR_RECORD_WRAPPER_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER_FLAGS.Preallocated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER_FLAGS.FromPersistentStore),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER_FLAGS.PlatformPfaControl),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER_FLAGS.PlatformDirectedOffline),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER_FLAGS.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEAP_ERROR_RECORD_WRAPPER_FLAGS.AsULONG),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEAP_ERROR_RECORD_WRAPPER_FLAGS>((mem, ptr) => new _WHEAP_ERROR_RECORD_WRAPPER_FLAGS(mem, ptr), offsets);
        }
    }
}