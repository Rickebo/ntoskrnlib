using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MDL")]
    public sealed class _MDL : DynamicStructure
    {
        public IntPtr Next { get; }
        public short Size { get; }
        public short MdlFlags { get; }
        public ushort AllocationProcessorNumber { get; }
        public ushort Reserved { get; }
        public IntPtr Process { get; }
        public IntPtr MappedSystemVa { get; }
        public IntPtr StartVa { get; }
        public uint ByteCount { get; }
        public uint ByteOffset { get; }

        public _MDL(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MDL()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MDL.Next),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MDL.Size),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MDL.MdlFlags),
                    new ulong[]
                    {
                        10UL
                    }
                },
                {
                    nameof(_MDL.AllocationProcessorNumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MDL.Reserved),
                    new ulong[]
                    {
                        14UL
                    }
                },
                {
                    nameof(_MDL.Process),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MDL.MappedSystemVa),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MDL.StartVa),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MDL.ByteCount),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MDL.ByteOffset),
                    new ulong[]
                    {
                        44UL
                    }
                }
            };
            Register<_MDL>((mem, ptr) => new _MDL(mem, ptr), offsets);
        }
    }
}