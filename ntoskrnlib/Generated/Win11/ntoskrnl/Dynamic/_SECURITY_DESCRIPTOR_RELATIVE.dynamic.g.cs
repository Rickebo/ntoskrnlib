using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_SECURITY_DESCRIPTOR_RELATIVE")]
    public sealed class _SECURITY_DESCRIPTOR_RELATIVE : DynamicStructure
    {
        public byte Revision { get; }
        public byte Sbz1 { get; }
        public ushort Control { get; }
        public uint Owner { get; }
        public uint Group { get; }
        public uint Sacl { get; }
        public uint Dacl { get; }

        public _SECURITY_DESCRIPTOR_RELATIVE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECURITY_DESCRIPTOR_RELATIVE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Revision),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Sbz1),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Control),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Owner),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Group),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Sacl),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_SECURITY_DESCRIPTOR_RELATIVE.Dacl),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_SECURITY_DESCRIPTOR_RELATIVE>((mem, ptr) => new _SECURITY_DESCRIPTOR_RELATIVE(mem, ptr), offsets);
        }
    }
}