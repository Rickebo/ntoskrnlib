using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_NAMED_PIPE_CREATE_PARAMETERS")]
    public sealed class _NAMED_PIPE_CREATE_PARAMETERS : DynamicStructure
    {
        public uint NamedPipeType { get; }
        public uint ReadMode { get; }
        public uint CompletionMode { get; }
        public uint MaximumInstances { get; }
        public uint InboundQuota { get; }
        public uint OutboundQuota { get; }
        public _LARGE_INTEGER DefaultTimeout { get; }
        public byte TimeoutSpecified { get; }

        public _NAMED_PIPE_CREATE_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NAMED_PIPE_CREATE_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.NamedPipeType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.ReadMode),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.CompletionMode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.MaximumInstances),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.InboundQuota),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.OutboundQuota),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.DefaultTimeout),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NAMED_PIPE_CREATE_PARAMETERS.TimeoutSpecified),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_NAMED_PIPE_CREATE_PARAMETERS>((mem, ptr) => new _NAMED_PIPE_CREATE_PARAMETERS(mem, ptr), offsets);
        }
    }
}