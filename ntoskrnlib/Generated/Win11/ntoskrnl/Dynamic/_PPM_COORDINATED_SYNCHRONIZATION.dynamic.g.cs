using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PPM_COORDINATED_SYNCHRONIZATION")]
    public sealed class _PPM_COORDINATED_SYNCHRONIZATION : DynamicStructure
    {
        public int AsLong { get; }
        public uint EnterProcessor { get; }
        public uint ExitProcessor { get; }
        public uint Transition { get; }
        public uint Entered { get; }
        public uint EntryPriority { get; }

        public _PPM_COORDINATED_SYNCHRONIZATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PPM_COORDINATED_SYNCHRONIZATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PPM_COORDINATED_SYNCHRONIZATION.AsLong),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SYNCHRONIZATION.EnterProcessor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SYNCHRONIZATION.ExitProcessor),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SYNCHRONIZATION.Transition),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SYNCHRONIZATION.Entered),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PPM_COORDINATED_SYNCHRONIZATION.EntryPriority),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_PPM_COORDINATED_SYNCHRONIZATION>((mem, ptr) => new _PPM_COORDINATED_SYNCHRONIZATION(mem, ptr), offsets);
        }
    }
}