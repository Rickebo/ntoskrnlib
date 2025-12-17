using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_TRUSTLET_MAILBOX_KEY")]
    public sealed class _TRUSTLET_MAILBOX_KEY : DynamicStructure
    {
        public ulong[] SecretValue { get; }

        public _TRUSTLET_MAILBOX_KEY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRUSTLET_MAILBOX_KEY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRUSTLET_MAILBOX_KEY.SecretValue),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_TRUSTLET_MAILBOX_KEY>((mem, ptr) => new _TRUSTLET_MAILBOX_KEY(mem, ptr), offsets);
        }
    }
}