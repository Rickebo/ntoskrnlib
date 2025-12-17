using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSECTION_FLAGS")]
    public sealed class _MMSECTION_FLAGS : DynamicStructure
    {
        public uint BeingDeleted { get; }
        public uint BeingCreated { get; }
        public uint BeingPurged { get; }
        public uint NoModifiedWriting { get; }
        public uint FailAllIo { get; }
        public uint Image { get; }
        public uint Based { get; }
        public uint File { get; }
        public uint SectionOfInterest { get; }
        public uint PrefetchCreated { get; }
        public uint PhysicalMemory { get; }
        public uint ImageControlAreaOnRemovableMedia { get; }
        public uint Reserve { get; }
        public uint Commit { get; }
        public uint NoChange { get; }
        public uint WasPurged { get; }
        public uint UserReference { get; }
        public uint GlobalMemory { get; }
        public uint DeleteOnClose { get; }
        public uint FilePointerNull { get; }
        public uint PreferredNode { get; }
        public uint GlobalOnlyPerSession { get; }
        public uint ControlAreaOnUnusedList { get; }
        public uint SystemVaAllocated { get; }
        public uint NotBeingUsed { get; }
        public uint PageSize64K { get; }

        public _MMSECTION_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSECTION_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSECTION_FLAGS.BeingDeleted),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.BeingCreated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.BeingPurged),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.NoModifiedWriting),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.FailAllIo),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.Image),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.Based),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.File),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.SectionOfInterest),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.PrefetchCreated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.PhysicalMemory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.ImageControlAreaOnRemovableMedia),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.Reserve),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.Commit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.NoChange),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.WasPurged),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.UserReference),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.GlobalMemory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.DeleteOnClose),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.FilePointerNull),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.PreferredNode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.GlobalOnlyPerSession),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.ControlAreaOnUnusedList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.SystemVaAllocated),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.NotBeingUsed),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSECTION_FLAGS.PageSize64K),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMSECTION_FLAGS>((mem, ptr) => new _MMSECTION_FLAGS(mem, ptr), offsets);
        }
    }
}