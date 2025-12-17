using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_OBP_SYSTEM_DOS_DEVICE_STATE")]
    public sealed class _OBP_SYSTEM_DOS_DEVICE_STATE : DynamicStructure
    {
        public uint GlobalDeviceMap { get; }
        public uint[] LocalDeviceCount { get; }

        public _OBP_SYSTEM_DOS_DEVICE_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBP_SYSTEM_DOS_DEVICE_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBP_SYSTEM_DOS_DEVICE_STATE.GlobalDeviceMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBP_SYSTEM_DOS_DEVICE_STATE.LocalDeviceCount),
                    new ulong[]
                    {
                        4UL
                    }
                }
            };
            Register<_OBP_SYSTEM_DOS_DEVICE_STATE>((mem, ptr) => new _OBP_SYSTEM_DOS_DEVICE_STATE(mem, ptr), offsets);
        }
    }
}