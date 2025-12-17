using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KWAIT_STATUS_REGISTER")]
    public sealed class _KWAIT_STATUS_REGISTER : DynamicStructure
    {
        public byte Flags { get; }
        public byte State { get; }
        public byte Affinity { get; }
        public byte Priority { get; }
        public byte Apc { get; }
        public byte UserApc { get; }
        public byte Alert { get; }

        public _KWAIT_STATUS_REGISTER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KWAIT_STATUS_REGISTER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KWAIT_STATUS_REGISTER.Flags),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_STATUS_REGISTER.State),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_STATUS_REGISTER.Affinity),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_STATUS_REGISTER.Priority),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_STATUS_REGISTER.Apc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_STATUS_REGISTER.UserApc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KWAIT_STATUS_REGISTER.Alert),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KWAIT_STATUS_REGISTER>((mem, ptr) => new _KWAIT_STATUS_REGISTER(mem, ptr), offsets);
        }
    }
}