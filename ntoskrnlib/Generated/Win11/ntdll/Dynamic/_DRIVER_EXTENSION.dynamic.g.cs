using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_DRIVER_EXTENSION")]
    public sealed class _DRIVER_EXTENSION : DynamicStructure
    {
        public IntPtr DriverObject { get; }
        public IntPtr AddDevice { get; }
        public uint Count { get; }
        public _UNICODE_STRING ServiceKeyName { get; }
        public IntPtr ClientDriverExtension { get; }
        public IntPtr FsFilterCallbacks { get; }
        public IntPtr KseCallbacks { get; }
        public IntPtr DvCallbacks { get; }
        public IntPtr VerifierContext { get; }
        public IntPtr DriverProxyExtension { get; }

        public _DRIVER_EXTENSION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DRIVER_EXTENSION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DRIVER_EXTENSION.DriverObject),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.AddDevice),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.Count),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.ServiceKeyName),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.ClientDriverExtension),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.FsFilterCallbacks),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.KseCallbacks),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.DvCallbacks),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.VerifierContext),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DRIVER_EXTENSION.DriverProxyExtension),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_DRIVER_EXTENSION>((mem, ptr) => new _DRIVER_EXTENSION(mem, ptr), offsets);
        }
    }
}