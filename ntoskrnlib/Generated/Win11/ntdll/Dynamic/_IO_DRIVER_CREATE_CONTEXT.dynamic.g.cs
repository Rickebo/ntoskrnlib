using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_IO_DRIVER_CREATE_CONTEXT")]
    public sealed class _IO_DRIVER_CREATE_CONTEXT : DynamicStructure
    {
        public short Size { get; }
        public IntPtr ExtraCreateParameter { get; }
        public IntPtr DeviceObjectHint { get; }
        public IntPtr TxnParameters { get; }
        public IntPtr SiloContext { get; }

        public _IO_DRIVER_CREATE_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _IO_DRIVER_CREATE_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_IO_DRIVER_CREATE_CONTEXT.Size),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_IO_DRIVER_CREATE_CONTEXT.ExtraCreateParameter),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_IO_DRIVER_CREATE_CONTEXT.DeviceObjectHint),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_IO_DRIVER_CREATE_CONTEXT.TxnParameters),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_IO_DRIVER_CREATE_CONTEXT.SiloContext),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_IO_DRIVER_CREATE_CONTEXT>((mem, ptr) => new _IO_DRIVER_CREATE_CONTEXT(mem, ptr), offsets);
        }
    }
}