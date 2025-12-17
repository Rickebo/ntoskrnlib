using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INVERTED_FUNCTION_TABLE_ENTRY")]
    public sealed class _INVERTED_FUNCTION_TABLE_ENTRY : DynamicStructure
    {
        public IntPtr FunctionTable { get; }
        public IntPtr DynamicTable { get; }
        public IntPtr ImageBase { get; }
        public uint SizeOfImage { get; }
        public uint SizeOfTable { get; }

        public _INVERTED_FUNCTION_TABLE_ENTRY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INVERTED_FUNCTION_TABLE_ENTRY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INVERTED_FUNCTION_TABLE_ENTRY.FunctionTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_ENTRY.DynamicTable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_ENTRY.ImageBase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_ENTRY.SizeOfImage),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_ENTRY.SizeOfTable),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_INVERTED_FUNCTION_TABLE_ENTRY>((mem, ptr) => new _INVERTED_FUNCTION_TABLE_ENTRY(mem, ptr), offsets);
        }
    }
}