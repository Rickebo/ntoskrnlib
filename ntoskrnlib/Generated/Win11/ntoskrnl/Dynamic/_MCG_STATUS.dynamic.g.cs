using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MCG_STATUS")]
    public sealed class _MCG_STATUS : DynamicStructure
    {
        public uint RestartIpValid { get; }
        public uint ErrorIpValid { get; }
        public uint MachineCheckInProgress { get; }
        public uint LocalMceValid { get; }
        public uint Reserved1 { get; }
        public uint Reserved2 { get; }
        public ulong QuadPart { get; }

        public _MCG_STATUS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCG_STATUS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCG_STATUS.RestartIpValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_STATUS.ErrorIpValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_STATUS.MachineCheckInProgress),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_STATUS.LocalMceValid),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_STATUS.Reserved1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCG_STATUS.Reserved2),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MCG_STATUS.QuadPart),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MCG_STATUS>((mem, ptr) => new _MCG_STATUS(mem, ptr), offsets);
        }
    }
}