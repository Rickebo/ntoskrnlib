using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WNF_STATE_NAME_REGISTRATION")]
    public sealed class _WNF_STATE_NAME_REGISTRATION : DynamicStructure
    {
        public uint MaxStateSize { get; }
        public IntPtr TypeId { get; }
        public IntPtr SecurityDescriptor { get; }

        public _WNF_STATE_NAME_REGISTRATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WNF_STATE_NAME_REGISTRATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WNF_STATE_NAME_REGISTRATION.MaxStateSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WNF_STATE_NAME_REGISTRATION.TypeId),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_WNF_STATE_NAME_REGISTRATION.SecurityDescriptor),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_WNF_STATE_NAME_REGISTRATION>((mem, ptr) => new _WNF_STATE_NAME_REGISTRATION(mem, ptr), offsets);
        }
    }
}