using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PROCESS_ENERGY_VALUES_EXTENSION")]
    public sealed class _PROCESS_ENERGY_VALUES_EXTENSION : DynamicStructure
    {
        public byte[] Timelines { get; }
        public _TIMELINE_BITMAP CpuTimeline { get; }
        public _TIMELINE_BITMAP DiskTimeline { get; }
        public _TIMELINE_BITMAP NetworkTimeline { get; }
        public _TIMELINE_BITMAP MBBTimeline { get; }
        public _TIMELINE_BITMAP ForegroundTimeline { get; }
        public _TIMELINE_BITMAP DesktopVisibleTimeline { get; }
        public _TIMELINE_BITMAP CompositionRenderedTimeline { get; }
        public _TIMELINE_BITMAP CompositionDirtyGeneratedTimeline { get; }
        public _TIMELINE_BITMAP CompositionDirtyPropagatedTimeline { get; }
        public _TIMELINE_BITMAP InputTimeline { get; }
        public _TIMELINE_BITMAP AudioInTimeline { get; }
        public _TIMELINE_BITMAP AudioOutTimeline { get; }
        public _TIMELINE_BITMAP DisplayRequiredTimeline { get; }
        public _TIMELINE_BITMAP KeyboardInputTimeline { get; }
        public byte[] Durations { get; }
        public _ENERGY_STATE_DURATION InputDuration { get; }
        public _ENERGY_STATE_DURATION AudioInDuration { get; }
        public _ENERGY_STATE_DURATION AudioOutDuration { get; }
        public _ENERGY_STATE_DURATION DisplayRequiredDuration { get; }
        public _ENERGY_STATE_DURATION PSMBackgroundDuration { get; }
        public uint KeyboardInput { get; }
        public uint MouseInput { get; }

        public _PROCESS_ENERGY_VALUES_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PROCESS_ENERGY_VALUES_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.Timelines),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.CpuTimeline),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.DiskTimeline),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.NetworkTimeline),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.MBBTimeline),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.ForegroundTimeline),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.DesktopVisibleTimeline),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.CompositionRenderedTimeline),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.CompositionDirtyGeneratedTimeline),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.CompositionDirtyPropagatedTimeline),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.InputTimeline),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.AudioInTimeline),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.AudioOutTimeline),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.DisplayRequiredTimeline),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.KeyboardInputTimeline),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.Durations),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.InputDuration),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.AudioInDuration),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.AudioOutDuration),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.DisplayRequiredDuration),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.PSMBackgroundDuration),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.KeyboardInput),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_PROCESS_ENERGY_VALUES_EXTENSION.MouseInput),
                    new ulong[]
                    {
                        156UL
                    }
                }
            };
            Register<_PROCESS_ENERGY_VALUES_EXTENSION>((mem, ptr) => new _PROCESS_ENERGY_VALUES_EXTENSION(mem, ptr), offsets);
        }
    }
}