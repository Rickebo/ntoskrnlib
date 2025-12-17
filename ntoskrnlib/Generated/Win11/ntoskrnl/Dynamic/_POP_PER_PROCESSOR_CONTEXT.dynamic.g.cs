using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_PER_PROCESSOR_CONTEXT")]
    public sealed class _POP_PER_PROCESSOR_CONTEXT : DynamicStructure
    {
        public IntPtr UncompressedData { get; }
        public IntPtr MappingVa { get; }
        public IntPtr XpressEncodeWorkspace { get; }
        public IntPtr CompressedDataBuffer { get; }
        public ulong CopyTicks { get; }
        public ulong CompressTicks { get; }
        public ulong BytesCopied { get; }
        public ulong PagesProcessed { get; }
        public ulong DecompressTicks { get; }
        public ulong ResumeCopyTicks { get; }
        public ulong SharedBufferTicks { get; }
        public ulong[] BlockCountByMethod { get; }
        public ulong[] DecompressTicksByMethod { get; }
        public ulong[] DecompressSizeByMethod { get; }
        public uint CompressCount { get; }
        public uint HuffCompressCount { get; }

        public _POP_PER_PROCESSOR_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_PER_PROCESSOR_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.UncompressedData),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.MappingVa),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.XpressEncodeWorkspace),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.CompressedDataBuffer),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.CopyTicks),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.CompressTicks),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.BytesCopied),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.PagesProcessed),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.DecompressTicks),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.ResumeCopyTicks),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.SharedBufferTicks),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.BlockCountByMethod),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.DecompressTicksByMethod),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.DecompressSizeByMethod),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.CompressCount),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_POP_PER_PROCESSOR_CONTEXT.HuffCompressCount),
                    new ulong[]
                    {
                        164UL
                    }
                }
            };
            Register<_POP_PER_PROCESSOR_CONTEXT>((mem, ptr) => new _POP_PER_PROCESSOR_CONTEXT(mem, ptr), offsets);
        }
    }
}