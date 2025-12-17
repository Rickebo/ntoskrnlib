using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_PPM_PROFILE")]
    public sealed class _POP_PPM_PROFILE : DynamicStructure
    {
        public IntPtr Name { get; }
        public byte Id { get; }
        public _GUID Guid { get; }
        public uint Flags { get; }
        public byte Priority { get; }
        public byte[] Settings { get; }
        public ulong StartTime { get; }
        public ulong Count { get; }
        public ulong MaxDuration { get; }
        public ulong MinDuration { get; }
        public ulong TotalDuration { get; }

        public _POP_PPM_PROFILE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_PPM_PROFILE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_PPM_PROFILE.Name),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.Id),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.Guid),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.Flags),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.Priority),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.Settings),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.StartTime),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.Count),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.MaxDuration),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.MinDuration),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_POP_PPM_PROFILE.TotalDuration),
                    new ulong[]
                    {
                        1048UL
                    }
                }
            };
            Register<_POP_PPM_PROFILE>((mem, ptr) => new _POP_PPM_PROFILE(mem, ptr), offsets);
        }
    }
}