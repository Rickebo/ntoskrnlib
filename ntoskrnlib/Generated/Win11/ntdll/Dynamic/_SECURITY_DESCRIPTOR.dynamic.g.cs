using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SECURITY_DESCRIPTOR")]
    public sealed class _SECURITY_DESCRIPTOR : DynamicStructure
    {
        public byte Revision { get; }
        public byte Sbz1 { get; }
        public ushort Control { get; }
        public IntPtr Owner { get; }
        public IntPtr Group { get; }
        public IntPtr Sacl { get; }
        public IntPtr Dacl { get; }

        public _SECURITY_DESCRIPTOR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECURITY_DESCRIPTOR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECURITY_DESCRIPTOR.Revision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR.Sbz1),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR.Control),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR.Owner),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR.Group),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR.Sacl),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR.Dacl),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_SECURITY_DESCRIPTOR>((mem, ptr) => new _SECURITY_DESCRIPTOR(mem, ptr), offsets);
        }
    }
}