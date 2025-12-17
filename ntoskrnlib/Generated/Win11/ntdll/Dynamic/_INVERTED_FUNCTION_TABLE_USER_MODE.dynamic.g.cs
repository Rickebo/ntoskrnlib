using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_INVERTED_FUNCTION_TABLE_USER_MODE")]
    public sealed class _INVERTED_FUNCTION_TABLE_USER_MODE : DynamicStructure
    {
        public uint CurrentSize { get; }
        public uint MaximumSize { get; }
        public uint Epoch { get; }
        public byte Overflow { get; }
        public byte[] TableEntry { get; }

        public _INVERTED_FUNCTION_TABLE_USER_MODE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INVERTED_FUNCTION_TABLE_USER_MODE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INVERTED_FUNCTION_TABLE_USER_MODE.CurrentSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_USER_MODE.MaximumSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_USER_MODE.Epoch),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_USER_MODE.Overflow),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_INVERTED_FUNCTION_TABLE_USER_MODE.TableEntry),
                    new ulong[]
                    {
                        16UL
                    }
                }
            };
            Register<_INVERTED_FUNCTION_TABLE_USER_MODE>((mem, ptr) => new _INVERTED_FUNCTION_TABLE_USER_MODE(mem, ptr), offsets);
        }
    }
}