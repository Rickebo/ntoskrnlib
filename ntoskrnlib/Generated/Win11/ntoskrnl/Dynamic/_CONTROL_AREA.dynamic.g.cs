using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_CONTROL_AREA")]
    public sealed class _CONTROL_AREA : DynamicStructure
    {
        public IntPtr Segment { get; }
        public _LIST_ENTRY ListHead { get; }
        public IntPtr AweContext { get; }
        public ulong NumberOfSectionReferences { get; }
        public ulong NumberOfPfnReferences { get; }
        public ulong NumberOfMappedViews { get; }
        public ulong NumberOfUserReferences { get; }
        public _unnamed_tag_ u { get; }
        public _unnamed_tag_ u1 { get; }
        public _EX_FAST_REF FilePointer { get; }
        public int ControlAreaLock { get; }
        public uint ModifiedWriteCount { get; }
        public IntPtr WaitList { get; }
        public _unnamed_tag_ u2 { get; }
        public _EX_PUSH_LOCK FileObjectLock { get; }
        public ulong LockedPages { get; }
        public _unnamed_tag_ u3 { get; }

        public _CONTROL_AREA(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _CONTROL_AREA()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_CONTROL_AREA.Segment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.ListHead),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.AweContext),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.NumberOfSectionReferences),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.NumberOfPfnReferences),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.NumberOfMappedViews),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.NumberOfUserReferences),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.u),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.u1),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.FilePointer),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.ControlAreaLock),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.ModifiedWriteCount),
                    new ulong[]
                    {
                        76UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.WaitList),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.u2),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.FileObjectLock),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.LockedPages),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_CONTROL_AREA.u3),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_CONTROL_AREA>((mem, ptr) => new _CONTROL_AREA(mem, ptr), offsets);
        }
    }
}