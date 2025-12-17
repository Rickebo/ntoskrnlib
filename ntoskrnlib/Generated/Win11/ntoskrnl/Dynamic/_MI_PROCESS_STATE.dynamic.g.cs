using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_PROCESS_STATE")]
    public sealed class _MI_PROCESS_STATE : DynamicStructure
    {
        public IntPtr SystemDllBase { get; }
        public uint ColorSeed { get; }
        public int RotatingUniprocessorNumber { get; }
        public _LARGE_INTEGER CriticalSectionTimeout { get; }
        public _LIST_ENTRY ProcessList { get; }
        public byte[] SharedUserDataPte { get; }
        public IntPtr HypervisorSharedVa { get; }
        public ulong VadSecureCookie { get; }
        public IntPtr NativeCfgBitmapPreferredAddress { get; }
        public IntPtr EcBitmapPreferredAddress { get; }

        public _MI_PROCESS_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_PROCESS_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_PROCESS_STATE.SystemDllBase),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.ColorSeed),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.RotatingUniprocessorNumber),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.CriticalSectionTimeout),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.ProcessList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.SharedUserDataPte),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.HypervisorSharedVa),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.VadSecureCookie),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.NativeCfgBitmapPreferredAddress),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_MI_PROCESS_STATE.EcBitmapPreferredAddress),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_MI_PROCESS_STATE>((mem, ptr) => new _MI_PROCESS_STATE(mem, ptr), offsets);
        }
    }
}