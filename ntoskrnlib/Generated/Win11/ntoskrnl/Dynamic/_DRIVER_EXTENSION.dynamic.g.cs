using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DRIVER_EXTENSION")]
    public sealed class _DRIVER_EXTENSION : DynamicStructure
    {
        public IntPtr DriverObject { get; }
        public IntPtr AddDevice { get; }
        public uint Count { get; }
        public _UNICODE_STRING ServiceKeyName { get; }

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
                }
            };
            Register<_DRIVER_EXTENSION>((mem, ptr) => new _DRIVER_EXTENSION(mem, ptr), offsets);
        }
    }
}