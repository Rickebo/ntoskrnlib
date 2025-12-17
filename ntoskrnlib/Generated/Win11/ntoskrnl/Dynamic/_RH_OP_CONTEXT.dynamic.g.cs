using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RH_OP_CONTEXT")]
    public sealed class _RH_OP_CONTEXT : DynamicStructure
    {
        public _LIST_ENTRY Links { get; }
        public IntPtr OplockRequestIrp { get; }
        public IntPtr OplockRequestFileObject { get; }
        public IntPtr OplockRequestProcess { get; }
        public IntPtr OplockOwnerThread { get; }
        public uint Flags { get; }
        public _LIST_ENTRY AtomicLinks { get; }
        public _OPLOCK_TELEMETRY TelemetryData { get; }
        public IntPtr AckTimeout { get; }

        public _RH_OP_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RH_OP_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RH_OP_CONTEXT.Links),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.OplockRequestIrp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.OplockRequestFileObject),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.OplockRequestProcess),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.OplockOwnerThread),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.Flags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.AtomicLinks),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.TelemetryData),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_RH_OP_CONTEXT.AckTimeout),
                    new ulong[]
                    {
                        88UL
                    }
                }
            };
            Register<_RH_OP_CONTEXT>((mem, ptr) => new _RH_OP_CONTEXT(mem, ptr), offsets);
        }
    }
}