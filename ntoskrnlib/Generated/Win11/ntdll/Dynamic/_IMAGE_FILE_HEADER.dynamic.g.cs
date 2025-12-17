using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IMAGE_FILE_HEADER")]
    public sealed class _IMAGE_FILE_HEADER : DynamicStructure
    {
        public ushort Machine { get; }
        public ushort NumberOfSections { get; }
        public uint TimeDateStamp { get; }
        public uint PointerToSymbolTable { get; }
        public uint NumberOfSymbols { get; }
        public ushort SizeOfOptionalHeader { get; }
        public ushort Characteristics { get; }

        public _IMAGE_FILE_HEADER(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IMAGE_FILE_HEADER()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IMAGE_FILE_HEADER.Machine),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IMAGE_FILE_HEADER.NumberOfSections),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_IMAGE_FILE_HEADER.TimeDateStamp),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_IMAGE_FILE_HEADER.PointerToSymbolTable),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IMAGE_FILE_HEADER.NumberOfSymbols),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_IMAGE_FILE_HEADER.SizeOfOptionalHeader),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IMAGE_FILE_HEADER.Characteristics),
                    new ulong[]
                    {
                        18UL
                    }
                }
            };
            Register<_IMAGE_FILE_HEADER>((mem, ptr) => new _IMAGE_FILE_HEADER(mem, ptr), offsets);
        }
    }
}