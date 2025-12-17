using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION")]
    public sealed class _AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION : DynamicStructure
    {
        public uint SecurityAttributeCount { get; }
        public _LIST_ENTRY SecurityAttributesList { get; }
        public uint WorkingSecurityAttributeCount { get; }
        public _LIST_ENTRY WorkingSecurityAttributesList { get; }

        public _AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION.SecurityAttributeCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION.SecurityAttributesList),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION.WorkingSecurityAttributeCount),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION.WorkingSecurityAttributesList),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION>((mem, ptr) => new _AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION(mem, ptr), offsets);
        }
    }
}