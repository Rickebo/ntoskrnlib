using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_INTERRUPT_FUNCTION_TABLE")]
    public sealed class _INTERRUPT_FUNCTION_TABLE : DynamicStructure
    {
        public IntPtr InitializeLocalUnit { get; }
        public IntPtr InitializeIoUnit { get; }
        public IntPtr SetPriority { get; }
        public IntPtr GetLocalUnitError { get; }
        public IntPtr ClearLocalUnitError { get; }
        public IntPtr GetLogicalId { get; }
        public IntPtr SetLogicalId { get; }
        public IntPtr AcceptAndGetSource { get; }
        public IntPtr EndOfInterrupt { get; }
        public IntPtr FastEndOfInterrupt { get; }
        public IntPtr SetLineState { get; }
        public IntPtr RequestInterrupt { get; }
        public IntPtr StartProcessor { get; }
        public IntPtr GenerateMessage { get; }
        public IntPtr ConvertId { get; }
        public IntPtr SaveLocalInterrupts { get; }
        public IntPtr ReplayLocalInterrupts { get; }
        public IntPtr DeinitializeLocalUnit { get; }
        public IntPtr DeinitializeIoUnit { get; }
        public IntPtr QueryAndGetSource { get; }
        public IntPtr DeactivateInterrupt { get; }
        public IntPtr DirectedEndOfInterrupt { get; }
        public IntPtr QueryLocalUnitInfo { get; }
        public IntPtr QueryPendingState { get; }
        public IntPtr CaptureGlobalCrashdumpState { get; }
        public IntPtr CaptureProcessorCrashdumpState { get; }

        public _INTERRUPT_FUNCTION_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _INTERRUPT_FUNCTION_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.InitializeLocalUnit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.InitializeIoUnit),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.SetPriority),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.GetLocalUnitError),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.ClearLocalUnitError),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.GetLogicalId),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.SetLogicalId),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.AcceptAndGetSource),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.EndOfInterrupt),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.FastEndOfInterrupt),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.SetLineState),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.RequestInterrupt),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.StartProcessor),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.GenerateMessage),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.ConvertId),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.SaveLocalInterrupts),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.ReplayLocalInterrupts),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.DeinitializeLocalUnit),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.DeinitializeIoUnit),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.QueryAndGetSource),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.DeactivateInterrupt),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.DirectedEndOfInterrupt),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.QueryLocalUnitInfo),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.QueryPendingState),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.CaptureGlobalCrashdumpState),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_INTERRUPT_FUNCTION_TABLE.CaptureProcessorCrashdumpState),
                    new ulong[]
                    {
                        200UL
                    }
                }
            };
            Register<_INTERRUPT_FUNCTION_TABLE>((mem, ptr) => new _INTERRUPT_FUNCTION_TABLE(mem, ptr), offsets);
        }
    }
}