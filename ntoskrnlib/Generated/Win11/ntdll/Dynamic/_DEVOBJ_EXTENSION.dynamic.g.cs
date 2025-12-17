using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DEVOBJ_EXTENSION")]
    public sealed class _DEVOBJ_EXTENSION : DynamicStructure
    {
        public short Type { get; }
        public ushort Size { get; }
        public IntPtr DeviceObject { get; }
        public uint PowerFlags { get; }
        public IntPtr Dope { get; }
        public uint ExtensionFlags { get; }
        public IntPtr DeviceNode { get; }
        public IntPtr AttachedTo { get; }
        public int StartIoCount { get; }
        public int StartIoKey { get; }
        public uint StartIoFlags { get; }
        public IntPtr Vpb { get; }
        public IntPtr DependencyNode { get; }
        public IntPtr InterruptContext { get; }
        public int InterruptCount { get; }
        public IntPtr VerifierContext { get; }

        public _DEVOBJ_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DEVOBJ_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DEVOBJ_EXTENSION.Type),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.Size),
                    new ulong[]
                    {
                        2UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.DeviceObject),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.PowerFlags),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.Dope),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.ExtensionFlags),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.DeviceNode),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.AttachedTo),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.StartIoCount),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.StartIoKey),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.StartIoFlags),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.Vpb),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.DependencyNode),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.InterruptContext),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.InterruptCount),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DEVOBJ_EXTENSION.VerifierContext),
                    new ulong[]
                    {
                        104UL
                    }
                }
            };
            Register<_DEVOBJ_EXTENSION>((mem, ptr) => new _DEVOBJ_EXTENSION(mem, ptr), offsets);
        }
    }
}