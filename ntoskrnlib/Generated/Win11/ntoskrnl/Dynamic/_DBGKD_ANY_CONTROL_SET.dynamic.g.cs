using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DBGKD_ANY_CONTROL_SET")]
    public sealed class _DBGKD_ANY_CONTROL_SET : DynamicStructure
    {
        public _X86_DBGKD_CONTROL_SET X86ControlSet { get; }
        public uint AlphaControlSet { get; }
        public _IA64_DBGKD_CONTROL_SET IA64ControlSet { get; }
        public _AMD64_DBGKD_CONTROL_SET Amd64ControlSet { get; }
        public _ARM_DBGKD_CONTROL_SET ArmControlSet { get; }
        public _ARM64_DBGKD_CONTROL_SET Arm64ControlSet { get; }
        public _ARMCE_DBGKD_CONTROL_SET ArmCeControlSet { get; }
        public _PPC_DBGKD_CONTROL_SET PpcControlSet { get; }

        public _DBGKD_ANY_CONTROL_SET(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DBGKD_ANY_CONTROL_SET()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.X86ControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.AlphaControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.IA64ControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.Amd64ControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.ArmControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.Arm64ControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.ArmCeControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DBGKD_ANY_CONTROL_SET.PpcControlSet),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_DBGKD_ANY_CONTROL_SET>((mem, ptr) => new _DBGKD_ANY_CONTROL_SET(mem, ptr), offsets);
        }
    }
}