using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KTRAP_FRAME")]
    public sealed class _KTRAP_FRAME : DynamicStructure
    {
        public ulong P1Home { get; }
        public ulong P2Home { get; }
        public ulong P3Home { get; }
        public ulong P4Home { get; }
        public ulong P5 { get; }
        public sbyte PreviousMode { get; }
        public byte InterruptRetpolineState { get; }
        public byte PreviousIrql { get; }
        public byte FaultIndicator { get; }
        public byte NmiMsrIbrs { get; }
        public byte ExceptionActive { get; }
        public uint MxCsr { get; }
        public ulong Rax { get; }
        public ulong Rcx { get; }
        public ulong Rdx { get; }
        public ulong R8 { get; }
        public ulong R9 { get; }
        public ulong R10 { get; }
        public ulong R11 { get; }
        public ulong GsBase { get; }
        public ulong GsSwap { get; }
        public _M128A Xmm0 { get; }
        public _M128A Xmm1 { get; }
        public _M128A Xmm2 { get; }
        public _M128A Xmm3 { get; }
        public _M128A Xmm4 { get; }
        public _M128A Xmm5 { get; }
        public ulong FaultAddress { get; }
        public ulong ContextRecord { get; }
        public ulong Dr0 { get; }
        public ulong Dr1 { get; }
        public ulong Dr2 { get; }
        public ulong Dr3 { get; }
        public ulong Dr6 { get; }
        public ulong Dr7 { get; }
        public ulong ShadowStackFrame { get; }
        public ulong[] Spare { get; }
        public ulong DebugControl { get; }
        public ulong LastBranchToRip { get; }
        public ulong LastBranchFromRip { get; }
        public ulong LastExceptionToRip { get; }
        public ulong LastExceptionFromRip { get; }
        public ushort SegDs { get; }
        public ushort SegEs { get; }
        public ushort SegFs { get; }
        public ushort SegGs { get; }
        public ulong TrapFrame { get; }
        public uint NmiPreviousSpecCtrl { get; }
        public uint NmiPreviousSpecCtrlPad { get; }
        public ulong Rbx { get; }
        public ulong Rdi { get; }
        public ulong Rsi { get; }
        public ulong Rbp { get; }
        public ulong ErrorCode { get; }
        public ulong ExceptionFrame { get; }
        public ulong Rip { get; }
        public ushort SegCs { get; }
        public byte Fill0 { get; }
        public byte Logging { get; }
        public ushort[] Fill1 { get; }
        public uint EFlags { get; }
        public uint Fill2 { get; }
        public ulong Rsp { get; }
        public ushort SegSs { get; }
        public ushort Fill3 { get; }
        public uint Fill4 { get; }

        public _KTRAP_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KTRAP_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KTRAP_FRAME.P1Home),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.P2Home),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.P3Home),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.P4Home),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.P5),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.PreviousMode),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.InterruptRetpolineState),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.PreviousIrql),
                    new ulong[]
                    {
                        41UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.FaultIndicator),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.NmiMsrIbrs),
                    new ulong[]
                    {
                        42UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.ExceptionActive),
                    new ulong[]
                    {
                        43UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.MxCsr),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rax),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rcx),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rdx),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.R8),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.R9),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.R10),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.R11),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.GsBase),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.GsSwap),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Xmm0),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Xmm1),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Xmm2),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Xmm3),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Xmm4),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Xmm5),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.FaultAddress),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.ContextRecord),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Dr0),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Dr1),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Dr2),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Dr3),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Dr6),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Dr7),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.ShadowStackFrame),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Spare),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.DebugControl),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.LastBranchToRip),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.LastBranchFromRip),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.LastExceptionToRip),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.LastExceptionFromRip),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.SegDs),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.SegEs),
                    new ulong[]
                    {
                        306UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.SegFs),
                    new ulong[]
                    {
                        308UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.SegGs),
                    new ulong[]
                    {
                        310UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.TrapFrame),
                    new ulong[]
                    {
                        312UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.NmiPreviousSpecCtrl),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.NmiPreviousSpecCtrlPad),
                    new ulong[]
                    {
                        324UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rbx),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rdi),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rsi),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rbp),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.ErrorCode),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.ExceptionFrame),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rip),
                    new ulong[]
                    {
                        360UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.SegCs),
                    new ulong[]
                    {
                        368UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Fill0),
                    new ulong[]
                    {
                        370UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Logging),
                    new ulong[]
                    {
                        371UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Fill1),
                    new ulong[]
                    {
                        372UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.EFlags),
                    new ulong[]
                    {
                        376UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Fill2),
                    new ulong[]
                    {
                        380UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Rsp),
                    new ulong[]
                    {
                        384UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.SegSs),
                    new ulong[]
                    {
                        392UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Fill3),
                    new ulong[]
                    {
                        394UL
                    }
                },
                {
                    nameof(_KTRAP_FRAME.Fill4),
                    new ulong[]
                    {
                        396UL
                    }
                }
            };
            Register<_KTRAP_FRAME>((mem, ptr) => new _KTRAP_FRAME(mem, ptr), offsets);
        }
    }
}