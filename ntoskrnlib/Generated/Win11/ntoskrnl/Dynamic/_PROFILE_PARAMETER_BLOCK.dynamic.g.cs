using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROFILE_PARAMETER_BLOCK")]
    public sealed class _PROFILE_PARAMETER_BLOCK : DynamicStructure
    {
        public ushort Status { get; }
        public ushort Reserved { get; }
        public ushort DockingState { get; }
        public ushort Capabilities { get; }
        public uint DockID { get; }
        public uint SerialNumber { get; }

        public _PROFILE_PARAMETER_BLOCK(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROFILE_PARAMETER_BLOCK()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROFILE_PARAMETER_BLOCK.Status),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROFILE_PARAMETER_BLOCK.Reserved),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_PROFILE_PARAMETER_BLOCK.DockingState),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_PROFILE_PARAMETER_BLOCK.Capabilities),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_PROFILE_PARAMETER_BLOCK.DockID),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROFILE_PARAMETER_BLOCK.SerialNumber),
                    new ulong[]
                    {
                        12UL
                    }
                }
            };
            Register<_PROFILE_PARAMETER_BLOCK>((mem, ptr) => new _PROFILE_PARAMETER_BLOCK(mem, ptr), offsets);
        }
    }
}