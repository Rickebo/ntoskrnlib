using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IO_RESOURCE_REQUIREMENTS_LIST")]
    public sealed class _IO_RESOURCE_REQUIREMENTS_LIST : DynamicStructure
    {
        public uint ListSize { get; }
        public uint InterfaceType { get; }
        public uint BusNumber { get; }
        public uint SlotNumber { get; }
        public uint[] Reserved { get; }
        public uint AlternativeLists { get; }
        public byte[] List { get; }

        public _IO_RESOURCE_REQUIREMENTS_LIST(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_RESOURCE_REQUIREMENTS_LIST()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.ListSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.InterfaceType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.BusNumber),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.SlotNumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.Reserved),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.AlternativeLists),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_IO_RESOURCE_REQUIREMENTS_LIST.List),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_IO_RESOURCE_REQUIREMENTS_LIST>((mem, ptr) => new _IO_RESOURCE_REQUIREMENTS_LIST(mem, ptr), offsets);
        }
    }
}