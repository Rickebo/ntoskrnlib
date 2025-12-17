using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_GETPAGE_FLAGS")]
    public sealed class _MI_GETPAGE_FLAGS : DynamicStructure
    {
        public uint EntireField { get; }
        public uint AtDpc { get; }
        public uint PageLockHeld { get; }
        public uint RecursingToDemote { get; }
        public uint PageAttributeOptional { get; }
        public uint PreferZero { get; }
        public uint RequireZero { get; }
        public uint ColorAlignment { get; }
        public uint SystemUse { get; }
        public uint PreserveAvailable { get; }
        public uint IgnoreAvailable { get; }
        public uint ContendForListLocks { get; }
        public uint DontDemoteLargePages { get; }
        public uint NodeMandatory { get; }
        public uint ChannelMandatory { get; }
        public uint DontDemote { get; }
        public uint DontDemote64KPages { get; }
        public uint NoStandby { get; }
        public uint NoStandbySwap { get; }
        public uint OnlyStandby { get; }
        public uint FreeZeroQueryIncludeLarge { get; }
        public uint MustBeZero { get; }

        public _MI_GETPAGE_FLAGS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_GETPAGE_FLAGS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_GETPAGE_FLAGS.EntireField),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.AtDpc),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.PageLockHeld),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.RecursingToDemote),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.PageAttributeOptional),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.PreferZero),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.RequireZero),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.ColorAlignment),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.SystemUse),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.PreserveAvailable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.IgnoreAvailable),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.ContendForListLocks),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.DontDemoteLargePages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.NodeMandatory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.ChannelMandatory),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.DontDemote),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.DontDemote64KPages),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.NoStandby),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.NoStandbySwap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.OnlyStandby),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.FreeZeroQueryIncludeLarge),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_GETPAGE_FLAGS.MustBeZero),
                    new ulong[]
                    {
                        0UL
                    }
                }
            };
            Register<_MI_GETPAGE_FLAGS>((mem, ptr) => new _MI_GETPAGE_FLAGS(mem, ptr), offsets);
        }
    }
}