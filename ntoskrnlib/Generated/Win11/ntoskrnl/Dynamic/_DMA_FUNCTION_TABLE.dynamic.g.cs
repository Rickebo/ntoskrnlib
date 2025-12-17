using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DMA_FUNCTION_TABLE")]
    public sealed class _DMA_FUNCTION_TABLE : DynamicStructure
    {
        public IntPtr InitializeController { get; }
        public IntPtr ValidateRequestLineBinding { get; }
        public IntPtr QueryMaxFragments { get; }
        public IntPtr ProgramChannel { get; }
        public IntPtr ConfigureChannel { get; }
        public IntPtr FlushChannel { get; }
        public IntPtr HandleInterrupt { get; }
        public IntPtr ReadDmaCounter { get; }
        public IntPtr ReportCommonBuffer { get; }
        public IntPtr CancelTransfer { get; }

        public _DMA_FUNCTION_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DMA_FUNCTION_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DMA_FUNCTION_TABLE.InitializeController),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.ValidateRequestLineBinding),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.QueryMaxFragments),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.ProgramChannel),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.ConfigureChannel),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.FlushChannel),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.HandleInterrupt),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.ReadDmaCounter),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.ReportCommonBuffer),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DMA_FUNCTION_TABLE.CancelTransfer),
                    new ulong[]
                    {
                        72UL
                    }
                }
            };
            Register<_DMA_FUNCTION_TABLE>((mem, ptr) => new _DMA_FUNCTION_TABLE(mem, ptr), offsets);
        }
    }
}