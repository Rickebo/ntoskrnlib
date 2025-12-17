using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!DEBUG_MEMORY_REQUIREMENTS")]
    public sealed class DEBUG_MEMORY_REQUIREMENTS : DynamicStructure
    {
        public _LARGE_INTEGER Start { get; }
        public _LARGE_INTEGER MaxEnd { get; }
        public IntPtr VirtualAddress { get; }
        public uint Length { get; }
        public byte Cached { get; }
        public byte Aligned { get; }

        public DEBUG_MEMORY_REQUIREMENTS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static DEBUG_MEMORY_REQUIREMENTS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(DEBUG_MEMORY_REQUIREMENTS.Start),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(DEBUG_MEMORY_REQUIREMENTS.MaxEnd),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(DEBUG_MEMORY_REQUIREMENTS.VirtualAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(DEBUG_MEMORY_REQUIREMENTS.Length),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(DEBUG_MEMORY_REQUIREMENTS.Cached),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(DEBUG_MEMORY_REQUIREMENTS.Aligned),
                    new ulong[]
                    {
                        29UL
                    }
                }
            };
            Register<DEBUG_MEMORY_REQUIREMENTS>((mem, ptr) => new DEBUG_MEMORY_REQUIREMENTS(mem, ptr), offsets);
        }
    }
}