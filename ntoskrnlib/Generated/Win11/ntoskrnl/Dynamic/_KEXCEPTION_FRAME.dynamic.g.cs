using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KEXCEPTION_FRAME")]
    public sealed class _KEXCEPTION_FRAME : DynamicStructure
    {
        public ulong P1Home { get; }
        public ulong P2Home { get; }
        public ulong P3Home { get; }
        public ulong P4Home { get; }
        public ulong P5 { get; }
        public ulong Spare1 { get; }
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
        public ulong TrapFrame { get; }
        public ulong OutputBuffer { get; }
        public ulong OutputLength { get; }
        public ulong Spare2 { get; }
        public ulong MxCsr { get; }
        public ulong Rbp { get; }
        public ulong Rbx { get; }
        public ulong Rdi { get; }
        public ulong Rsi { get; }
        public ulong R12 { get; }
        public ulong R13 { get; }
        public ulong R14 { get; }
        public ulong R15 { get; }
        public ulong Return { get; }

        public _KEXCEPTION_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KEXCEPTION_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KEXCEPTION_FRAME.P1Home),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.P2Home),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.P3Home),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.P4Home),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.P5),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Spare1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm6),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm7),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm8),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm9),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm10),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm11),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm12),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm13),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm14),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Xmm15),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.TrapFrame),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.OutputBuffer),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.OutputLength),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Spare2),
                    new ulong[]
                    {
                        232UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.MxCsr),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Rbp),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Rbx),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Rdi),
                    new ulong[]
                    {
                        264UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Rsi),
                    new ulong[]
                    {
                        272UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.R12),
                    new ulong[]
                    {
                        280UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.R13),
                    new ulong[]
                    {
                        288UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.R14),
                    new ulong[]
                    {
                        296UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.R15),
                    new ulong[]
                    {
                        304UL
                    }
                },
                {
                    nameof(_KEXCEPTION_FRAME.Return),
                    new ulong[]
                    {
                        312UL
                    }
                }
            };
            Register<_KEXCEPTION_FRAME>((mem, ptr) => new _KEXCEPTION_FRAME(mem, ptr), offsets);
        }
    }
}