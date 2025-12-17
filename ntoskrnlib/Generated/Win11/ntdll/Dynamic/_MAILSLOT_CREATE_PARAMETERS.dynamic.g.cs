using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MAILSLOT_CREATE_PARAMETERS")]
    public sealed class _MAILSLOT_CREATE_PARAMETERS : DynamicStructure
    {
        public uint MailslotQuota { get; }
        public uint MaximumMessageSize { get; }
        public _LARGE_INTEGER ReadTimeout { get; }
        public byte TimeoutSpecified { get; }

        public _MAILSLOT_CREATE_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MAILSLOT_CREATE_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MAILSLOT_CREATE_PARAMETERS.MailslotQuota),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MAILSLOT_CREATE_PARAMETERS.MaximumMessageSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MAILSLOT_CREATE_PARAMETERS.ReadTimeout),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MAILSLOT_CREATE_PARAMETERS.TimeoutSpecified),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_MAILSLOT_CREATE_PARAMETERS>((mem, ptr) => new _MAILSLOT_CREATE_PARAMETERS(mem, ptr), offsets);
        }
    }
}