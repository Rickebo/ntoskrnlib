using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_KEXECUTE_OPTIONS")]
    public sealed class _KEXECUTE_OPTIONS : DynamicStructure
    {
        public byte ExecuteDisable { get; }
        public byte ExecuteEnable { get; }
        public byte DisableThunkEmulation { get; }
        public byte Permanent { get; }
        public byte ExecuteDispatchEnable { get; }
        public byte ImageDispatchEnable { get; }
        public byte DisableExceptionChainValidation { get; }
        public byte Spare { get; }
        public byte ExecuteOptions { get; }
        public byte ExecuteOptionsNV { get; }

        public _KEXECUTE_OPTIONS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _KEXECUTE_OPTIONS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_KEXECUTE_OPTIONS.ExecuteDisable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.ExecuteEnable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.DisableThunkEmulation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.Permanent),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.ExecuteDispatchEnable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.ImageDispatchEnable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.DisableExceptionChainValidation),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.Spare),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.ExecuteOptions),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_KEXECUTE_OPTIONS.ExecuteOptionsNV),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_KEXECUTE_OPTIONS>((mem, ptr) => new _KEXECUTE_OPTIONS(mem, ptr), offsets);
        }
    }
}