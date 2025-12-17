using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MMSUPPORT_FLAGS")]
    public sealed class _MMSUPPORT_FLAGS : DynamicStructure
    {
        public byte WorkingSetType { get; }
        public byte Reserved0 { get; }
        public byte MaximumWorkingSetHard { get; }
        public byte MinimumWorkingSetHard { get; }
        public byte Reserved1 { get; }
        public byte TrimmerState { get; }
        public byte LinearAddressProtected { get; }
        public byte PageStealers { get; }
        public ushort u1 { get; }
        public byte MemoryPriority { get; }
        public byte WsleDeleted { get; }
        public byte SvmEnabled { get; }
        public byte ForceAge { get; }
        public byte ForceTrim { get; }
        public byte CommitReleaseState { get; }
        public byte Reserved2 { get; }
        public byte u2 { get; }
        public uint EntireFlags { get; }

        public _MMSUPPORT_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MMSUPPORT_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MMSUPPORT_FLAGS.WorkingSetType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.Reserved0),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.MaximumWorkingSetHard),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.MinimumWorkingSetHard),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.Reserved1),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.TrimmerState),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.LinearAddressProtected),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.PageStealers),
                    new ulong[]
                    {
                        1UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.u1),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.MemoryPriority),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.WsleDeleted),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.SvmEnabled),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.ForceAge),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.ForceTrim),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.CommitReleaseState),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.Reserved2),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.u2),
                    new ulong[]
                    {
                        3UL
                    }
                },
                {
                    nameof(_MMSUPPORT_FLAGS.EntireFlags),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MMSUPPORT_FLAGS>((mem, ptr) => new _MMSUPPORT_FLAGS(mem, ptr), offsets);
        }
    }
}