using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CONTEXT")]
    public sealed class _CONTEXT : DynamicStructure
    {
        public ulong P1Home { get; }
        public ulong P2Home { get; }
        public ulong P3Home { get; }
        public ulong P4Home { get; }
        public ulong P5Home { get; }
        public ulong P6Home { get; }
        public uint ContextFlags { get; }
        public uint MxCsr { get; }
        public ushort SegCs { get; }
        public ushort SegDs { get; }
        public ushort SegEs { get; }
        public ushort SegFs { get; }
        public ushort SegGs { get; }
        public ushort SegSs { get; }
        public uint EFlags { get; }
        public ulong Dr0 { get; }
        public ulong Dr1 { get; }
        public ulong Dr2 { get; }
        public ulong Dr3 { get; }
        public ulong Dr6 { get; }
        public ulong Dr7 { get; }
        public ulong Rax { get; }
        public ulong Rcx { get; }
        public ulong Rdx { get; }
        public ulong Rbx { get; }
        public ulong Rsp { get; }
        public ulong Rbp { get; }
        public ulong Rsi { get; }
        public ulong Rdi { get; }
        public ulong R8 { get; }
        public ulong R9 { get; }
        public ulong R10 { get; }
        public ulong R11 { get; }
        public ulong R12 { get; }
        public ulong R13 { get; }
        public ulong R14 { get; }
        public ulong R15 { get; }
        public ulong Rip { get; }
        public _XSAVE_FORMAT FltSave { get; }
        public byte[] Header { get; }
        public byte[] Legacy { get; }
        public _M128A Xmm0 { get; }
        public _M128A Xmm1 { get; }
        public _M128A Xmm2 { get; }
        public _M128A Xmm3 { get; }
        public _M128A Xmm4 { get; }
        public _M128A Xmm5 { get; }
        public _M128A Xmm6 { get; }
        public _M128A Xmm7 { get; }
        public _M128A Xmm8 { get; }
        public _M128A Xmm9 { get; }
        public _M128A Xmm10 { get; }
        public _M128A Xmm11 { get; }
        public _M128A Xmm12 { get; }
        public _M128A Xmm13 { get; }
        public _M128A Xmm14 { get; }
        public _M128A Xmm15 { get; }
        public byte[] VectorRegister { get; }
        public ulong VectorControl { get; }
        public ulong DebugControl { get; }
        public ulong LastBranchToRip { get; }
        public ulong LastBranchFromRip { get; }
        public ulong LastExceptionToRip { get; }
        public ulong LastExceptionFromRip { get; }

        public _CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CONTEXT.P1Home),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CONTEXT.P2Home),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CONTEXT.P3Home),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_CONTEXT.P4Home),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CONTEXT.P5Home),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CONTEXT.P6Home),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CONTEXT.ContextFlags),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CONTEXT.MxCsr),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_CONTEXT.SegCs),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CONTEXT.SegDs),
                    new ulong[]
                    {
                        58UL
                    }
                },
                {
                    nameof(_CONTEXT.SegEs),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_CONTEXT.SegFs),
                    new ulong[]
                    {
                        62UL
                    }
                },
                {
                    nameof(_CONTEXT.SegGs),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CONTEXT.SegSs),
                    new ulong[]
                    {
                        66UL
                    }
                },
                {
                    nameof(_CONTEXT.EFlags),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_CONTEXT.Dr0),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CONTEXT.Dr1),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CONTEXT.Dr2),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CONTEXT.Dr3),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_CONTEXT.Dr6),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CONTEXT.Dr7),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CONTEXT.Rax),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_CONTEXT.Rcx),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_CONTEXT.Rdx),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_CONTEXT.Rbx),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_CONTEXT.Rsp),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_CONTEXT.Rbp),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_CONTEXT.Rsi),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_CONTEXT.Rdi),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_CONTEXT.R8),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_CONTEXT.R9),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_CONTEXT.R10),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_CONTEXT.R11),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_CONTEXT.R12),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_CONTEXT.R13),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_CONTEXT.R14),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_CONTEXT.R15),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_CONTEXT.Rip),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_CONTEXT.FltSave),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_CONTEXT.Header),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_CONTEXT.Legacy),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm0),
                    new ulong[]
                    {
                        416UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm1),
                    new ulong[]
                    {
                        432UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm2),
                    new ulong[]
                    {
                        448UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm3),
                    new ulong[]
                    {
                        464UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm4),
                    new ulong[]
                    {
                        480UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm5),
                    new ulong[]
                    {
                        496UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm6),
                    new ulong[]
                    {
                        512UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm7),
                    new ulong[]
                    {
                        528UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm8),
                    new ulong[]
                    {
                        544UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm9),
                    new ulong[]
                    {
                        560UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm10),
                    new ulong[]
                    {
                        576UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm11),
                    new ulong[]
                    {
                        592UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm12),
                    new ulong[]
                    {
                        608UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm13),
                    new ulong[]
                    {
                        624UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm14),
                    new ulong[]
                    {
                        640UL
                    }
                },
                {
                    nameof(_CONTEXT.Xmm15),
                    new ulong[]
                    {
                        656UL
                    }
                },
                {
                    nameof(_CONTEXT.VectorRegister),
                    new ulong[]
                    {
                        768UL
                    }
                },
                {
                    nameof(_CONTEXT.VectorControl),
                    new ulong[]
                    {
                        1184UL
                    }
                },
                {
                    nameof(_CONTEXT.DebugControl),
                    new ulong[]
                    {
                        1192UL
                    }
                },
                {
                    nameof(_CONTEXT.LastBranchToRip),
                    new ulong[]
                    {
                        1200UL
                    }
                },
                {
                    nameof(_CONTEXT.LastBranchFromRip),
                    new ulong[]
                    {
                        1208UL
                    }
                },
                {
                    nameof(_CONTEXT.LastExceptionToRip),
                    new ulong[]
                    {
                        1216UL
                    }
                },
                {
                    nameof(_CONTEXT.LastExceptionFromRip),
                    new ulong[]
                    {
                        1224UL
                    }
                }
            };
            Register<_CONTEXT>((mem, ptr) => new _CONTEXT(mem, ptr), offsets);
        }
    }
}