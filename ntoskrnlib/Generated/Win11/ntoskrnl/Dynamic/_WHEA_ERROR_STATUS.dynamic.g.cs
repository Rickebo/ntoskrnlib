using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_WHEA_ERROR_STATUS")]
    public sealed class _WHEA_ERROR_STATUS : DynamicStructure
    {
        public ulong ErrorStatus { get; }
        public ulong Reserved1 { get; }
        public ulong ErrorType { get; }
        public ulong Address { get; }
        public ulong Control { get; }
        public ulong Data { get; }
        public ulong Responder { get; }
        public ulong Requester { get; }
        public ulong FirstError { get; }
        public ulong Overflow { get; }
        public ulong Reserved2 { get; }

        public _WHEA_ERROR_STATUS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _WHEA_ERROR_STATUS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_WHEA_ERROR_STATUS.ErrorStatus),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.ErrorType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Address),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Control),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Data),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Responder),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Requester),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.FirstError),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Overflow),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_WHEA_ERROR_STATUS.Reserved2),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_WHEA_ERROR_STATUS>((mem, ptr) => new _WHEA_ERROR_STATUS(mem, ptr), offsets);
        }
    }
}