using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_IO_INFO")]
    public sealed class _POP_IO_INFO : DynamicStructure
    {
        public IntPtr DumpMdl { get; }
        public uint IoStatus { get; }
        public ulong IoStartCount { get; }
        public ulong IoBytesCompleted { get; }
        public ulong IoBytesInProgress { get; }
        public ulong RequestSize { get; }
        public _LARGE_INTEGER IoLocation { get; }
        public ulong FileOffset { get; }
        public IntPtr Buffer { get; }
        public byte AsyncCapable { get; }
        public ulong BytesToRead { get; }
        public uint Pages { get; }
        public ulong HighestChecksumIndex { get; }
        public ushort PreviousChecksum { get; }

        public _POP_IO_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_IO_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_IO_INFO.DumpMdl),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.IoStatus),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.IoStartCount),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.IoBytesCompleted),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.IoBytesInProgress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.RequestSize),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.IoLocation),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.FileOffset),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.Buffer),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.AsyncCapable),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.BytesToRead),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.Pages),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.HighestChecksumIndex),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_IO_INFO.PreviousChecksum),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_POP_IO_INFO>((mem, ptr) => new _POP_IO_INFO(mem, ptr), offsets);
        }
    }
}