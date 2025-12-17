using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_AMD_MCA_IPID")]
    public sealed class _AMD_MCA_IPID : DynamicStructure
    {
        public ulong InstanceId { get; }
        public ulong HardwareId { get; }
        public ulong Reserved { get; }
        public ulong McaType { get; }
        public ulong AsUINT64 { get; }

        public _AMD_MCA_IPID(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _AMD_MCA_IPID()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_AMD_MCA_IPID.InstanceId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD_MCA_IPID.HardwareId),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD_MCA_IPID.Reserved),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD_MCA_IPID.McaType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_AMD_MCA_IPID.AsUINT64),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_AMD_MCA_IPID>((mem, ptr) => new _AMD_MCA_IPID(mem, ptr), offsets);
        }
    }
}