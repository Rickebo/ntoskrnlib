using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_FILE_STANDARD_INFORMATION")]
    public sealed class _FILE_STANDARD_INFORMATION : DynamicStructure
    {
        public _LARGE_INTEGER AllocationSize { get; }
        public _LARGE_INTEGER EndOfFile { get; }
        public uint NumberOfLinks { get; }
        public byte DeletePending { get; }
        public byte Directory { get; }

        public _FILE_STANDARD_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _FILE_STANDARD_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_FILE_STANDARD_INFORMATION.AllocationSize),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_FILE_STANDARD_INFORMATION.EndOfFile),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_FILE_STANDARD_INFORMATION.NumberOfLinks),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_FILE_STANDARD_INFORMATION.DeletePending),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_FILE_STANDARD_INFORMATION.Directory),
                    new ulong[]
                    {
                        21UL
                    }
                }
            };
            Register<_FILE_STANDARD_INFORMATION>((mem, ptr) => new _FILE_STANDARD_INFORMATION(mem, ptr), offsets);
        }
    }
}