using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_X86_KTRAP_FRAME")]
    public sealed class _X86_KTRAP_FRAME : DynamicStructure
    {
        public uint DbgEbp { get; }
        public uint DbgEip { get; }
        public uint DbgArgMark { get; }
        public uint DbgArgPointer { get; }
        public uint TempSegCs { get; }
        public uint TempEsp { get; }
        public uint Dr0 { get; }
        public uint Dr1 { get; }
        public uint Dr2 { get; }
        public uint Dr3 { get; }
        public uint Dr6 { get; }
        public uint Dr7 { get; }
        public uint SegGs { get; }
        public uint SegEs { get; }
        public uint SegDs { get; }
        public uint Edx { get; }
        public uint Ecx { get; }
        public uint Eax { get; }
        public byte PreviousPreviousMode { get; }
        public byte EntropyQueueDpc { get; }
        public byte[] Reserved { get; }
        public uint ExceptionList { get; }
        public uint SegFs { get; }
        public uint Edi { get; }
        public uint Esi { get; }
        public uint Ebx { get; }
        public uint Ebp { get; }
        public uint ErrCode { get; }
        public uint Eip { get; }
        public uint SegCs { get; }
        public uint EFlags { get; }
        public uint HardwareEsp { get; }
        public uint HardwareSegSs { get; }
        public uint V86Es { get; }
        public uint V86Ds { get; }
        public uint V86Fs { get; }
        public uint V86Gs { get; }

        public _X86_KTRAP_FRAME(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _X86_KTRAP_FRAME()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_X86_KTRAP_FRAME.DbgEbp),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.DbgEip),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.DbgArgMark),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.DbgArgPointer),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.TempSegCs),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.TempEsp),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Dr0),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Dr1),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Dr2),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Dr3),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Dr6),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Dr7),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.SegGs),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.SegEs),
                    new ulong[]
                    {
                        52UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.SegDs),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Edx),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Ecx),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Eax),
                    new ulong[]
                    {
                        68UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.PreviousPreviousMode),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.EntropyQueueDpc),
                    new ulong[]
                    {
                        73UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Reserved),
                    new ulong[]
                    {
                        74UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.ExceptionList),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.SegFs),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Edi),
                    new ulong[]
                    {
                        84UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Esi),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Ebx),
                    new ulong[]
                    {
                        92UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Ebp),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.ErrCode),
                    new ulong[]
                    {
                        100UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.Eip),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.SegCs),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.EFlags),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.HardwareEsp),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.HardwareSegSs),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.V86Es),
                    new ulong[]
                    {
                        124UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.V86Ds),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.V86Fs),
                    new ulong[]
                    {
                        132UL
                    }
                },
                {
                    nameof(_X86_KTRAP_FRAME.V86Gs),
                    new ulong[]
                    {
                        136UL
                    }
                }
            };
            Register<_X86_KTRAP_FRAME>((mem, ptr) => new _X86_KTRAP_FRAME(mem, ptr), offsets);
        }
    }
}