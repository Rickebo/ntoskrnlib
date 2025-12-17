using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_KSPECIAL_REGISTERS")]
    public sealed class _KSPECIAL_REGISTERS : DynamicStructure
    {
        public ulong Cr0 { get; }
        public ulong Cr2 { get; }
        public ulong Cr3 { get; }
        public ulong Cr4 { get; }
        public ulong KernelDr0 { get; }
        public ulong KernelDr1 { get; }
        public ulong KernelDr2 { get; }
        public ulong KernelDr3 { get; }
        public ulong KernelDr6 { get; }
        public ulong KernelDr7 { get; }
        public _KDESCRIPTOR Gdtr { get; }
        public _KDESCRIPTOR Idtr { get; }
        public ushort Tr { get; }
        public ushort Ldtr { get; }
        public uint MxCsr { get; }
        public ulong DebugControl { get; }
        public ulong LastBranchToRip { get; }
        public ulong LastBranchFromRip { get; }
        public ulong LastExceptionToRip { get; }
        public ulong LastExceptionFromRip { get; }
        public ulong Cr8 { get; }
        public ulong MsrGsBase { get; }
        public ulong MsrGsSwap { get; }
        public ulong MsrStar { get; }
        public ulong MsrLStar { get; }
        public ulong MsrCStar { get; }
        public ulong MsrSyscallMask { get; }
        public ulong Xcr0 { get; }
        public ulong MsrFsBase { get; }
        public ulong SpecialPadding0 { get; }

        public _KSPECIAL_REGISTERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KSPECIAL_REGISTERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KSPECIAL_REGISTERS.Cr0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Cr2),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Cr3),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Cr4),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.KernelDr0),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.KernelDr1),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.KernelDr2),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.KernelDr3),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.KernelDr6),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.KernelDr7),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Gdtr),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Idtr),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Tr),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Ldtr),
                    new ulong[]
                    {
                        114UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MxCsr),
                    new ulong[]
                    {
                        116UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.DebugControl),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.LastBranchToRip),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.LastBranchFromRip),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.LastExceptionToRip),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.LastExceptionFromRip),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Cr8),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrGsBase),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrGsSwap),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrStar),
                    new ulong[]
                    {
                        184UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrLStar),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrCStar),
                    new ulong[]
                    {
                        200UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrSyscallMask),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.Xcr0),
                    new ulong[]
                    {
                        216UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.MsrFsBase),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_KSPECIAL_REGISTERS.SpecialPadding0),
                    new ulong[]
                    {
                        232UL
                    }
                }
            };
            Register<_KSPECIAL_REGISTERS>((mem, ptr) => new _KSPECIAL_REGISTERS(mem, ptr), offsets);
        }
    }
}