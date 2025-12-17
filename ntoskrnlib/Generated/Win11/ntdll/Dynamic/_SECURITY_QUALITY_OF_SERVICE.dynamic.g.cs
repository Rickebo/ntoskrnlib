using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SECURITY_QUALITY_OF_SERVICE")]
    public sealed class _SECURITY_QUALITY_OF_SERVICE : DynamicStructure
    {
        public uint Length { get; }
        public uint ImpersonationLevel { get; }
        public byte ContextTrackingMode { get; }
        public byte EffectiveOnly { get; }

        public _SECURITY_QUALITY_OF_SERVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SECURITY_QUALITY_OF_SERVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SECURITY_QUALITY_OF_SERVICE.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SECURITY_QUALITY_OF_SERVICE.ImpersonationLevel),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_SECURITY_QUALITY_OF_SERVICE.ContextTrackingMode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_SECURITY_QUALITY_OF_SERVICE.EffectiveOnly),
                    new ulong[]
                    {
                        9UL
                    }
                }
            };
            Register<_SECURITY_QUALITY_OF_SERVICE>((mem, ptr) => new _SECURITY_QUALITY_OF_SERVICE(mem, ptr), offsets);
        }
    }
}