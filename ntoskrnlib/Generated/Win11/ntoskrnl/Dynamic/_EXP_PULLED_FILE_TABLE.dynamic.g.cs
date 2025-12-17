using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXP_PULLED_FILE_TABLE")]
    public sealed class _EXP_PULLED_FILE_TABLE : DynamicStructure
    {
        public int NumberOfFiles { get; }
        public int TableSize { get; }
        public ulong[] Hashes { get; }

        public _EXP_PULLED_FILE_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXP_PULLED_FILE_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXP_PULLED_FILE_TABLE.NumberOfFiles),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXP_PULLED_FILE_TABLE.TableSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXP_PULLED_FILE_TABLE.Hashes),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_EXP_PULLED_FILE_TABLE>((mem, ptr) => new _EXP_PULLED_FILE_TABLE(mem, ptr), offsets);
        }
    }
}