using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DEVICE_DSM_DEFINITION")]
    public sealed class _DEVICE_DSM_DEFINITION : DynamicStructure
    {
        public uint Action { get; }
        public byte SingleRange { get; }
        public uint ParameterBlockAlignment { get; }
        public uint ParameterBlockLength { get; }
        public byte HasOutput { get; }
        public uint OutputBlockAlignment { get; }
        public uint OutputBlockLength { get; }

        public _DEVICE_DSM_DEFINITION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVICE_DSM_DEFINITION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVICE_DSM_DEFINITION.Action),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVICE_DSM_DEFINITION.SingleRange),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DEVICE_DSM_DEFINITION.ParameterBlockAlignment),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVICE_DSM_DEFINITION.ParameterBlockLength),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_DEVICE_DSM_DEFINITION.HasOutput),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVICE_DSM_DEFINITION.OutputBlockAlignment),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_DEVICE_DSM_DEFINITION.OutputBlockLength),
                    new ulong[]
                    {
                        24UL
                    }
                }
            };
            Register<_DEVICE_DSM_DEFINITION>((mem, ptr) => new _DEVICE_DSM_DEFINITION(mem, ptr), offsets);
        }
    }
}