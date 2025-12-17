using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DIAGNOSTIC_CONTEXT")]
    public sealed class _DIAGNOSTIC_CONTEXT : DynamicStructure
    {
        public uint CallerType { get; }
        public IntPtr Process { get; }
        public _UNICODE_STRING ProcessImageName { get; }
        public uint ProcessId { get; }
        public uint SessionId { get; }
        public uint ServiceTag { get; }
        public IntPtr DeviceObject { get; }
        public ulong ReasonSize { get; }

        public _DIAGNOSTIC_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DIAGNOSTIC_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DIAGNOSTIC_CONTEXT.CallerType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.Process),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.ProcessImageName),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.ProcessId),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.SessionId),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.ServiceTag),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DIAGNOSTIC_CONTEXT.ReasonSize),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_DIAGNOSTIC_CONTEXT>((mem, ptr) => new _DIAGNOSTIC_CONTEXT(mem, ptr), offsets);
        }
    }
}