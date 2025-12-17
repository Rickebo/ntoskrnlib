using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_POP_FX_PLUGIN")]
    public sealed class _POP_FX_PLUGIN : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public uint Version { get; }
        public ulong Flags { get; }
        public _KQUEUE WorkQueue { get; }
        public IntPtr AcceptDeviceNotification { get; }
        public IntPtr AcceptProcessorNotification { get; }
        public IntPtr AcceptAcpiNotification { get; }
        public _POP_FX_WORK_POOL PluginWorkPool { get; }

        public _POP_FX_PLUGIN(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _POP_FX_PLUGIN()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_POP_FX_PLUGIN.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.Version),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.Flags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.WorkQueue),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.AcceptDeviceNotification),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.AcceptProcessorNotification),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.AcceptAcpiNotification),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_POP_FX_PLUGIN.PluginWorkPool),
                    new ulong[]
                    {
                        120UL
                    }
                }
            };
            Register<_POP_FX_PLUGIN>((mem, ptr) => new _POP_FX_PLUGIN(mem, ptr), offsets);
        }
    }
}