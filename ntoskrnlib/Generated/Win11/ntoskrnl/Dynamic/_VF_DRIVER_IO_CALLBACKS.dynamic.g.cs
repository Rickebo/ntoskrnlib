using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_VF_DRIVER_IO_CALLBACKS")]
    public sealed class _VF_DRIVER_IO_CALLBACKS : DynamicStructure
    {
        public IntPtr DriverInit { get; }
        public IntPtr DriverStartIo { get; }
        public IntPtr DriverUnload { get; }
        public IntPtr AddDevice { get; }
        public byte[] MajorFunction { get; }

        public _VF_DRIVER_IO_CALLBACKS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _VF_DRIVER_IO_CALLBACKS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_VF_DRIVER_IO_CALLBACKS.DriverInit),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_VF_DRIVER_IO_CALLBACKS.DriverStartIo),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_VF_DRIVER_IO_CALLBACKS.DriverUnload),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_VF_DRIVER_IO_CALLBACKS.AddDevice),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_VF_DRIVER_IO_CALLBACKS.MajorFunction),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_VF_DRIVER_IO_CALLBACKS>((mem, ptr) => new _VF_DRIVER_IO_CALLBACKS(mem, ptr), offsets);
        }
    }
}