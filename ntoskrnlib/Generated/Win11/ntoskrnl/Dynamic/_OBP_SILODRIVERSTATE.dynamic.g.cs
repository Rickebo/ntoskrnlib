using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_OBP_SILODRIVERSTATE")]
    public sealed class _OBP_SILODRIVERSTATE : DynamicStructure
    {
        public _EX_FAST_REF SystemDeviceMap { get; }
        public _OBP_SYSTEM_DOS_DEVICE_STATE SystemDosDeviceState { get; }
        public _EX_PUSH_LOCK DeviceMapLock { get; }
        public _OBJECT_NAMESPACE_LOOKUPTABLE PrivateNamespaceLookupTable { get; }

        public _OBP_SILODRIVERSTATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _OBP_SILODRIVERSTATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_OBP_SILODRIVERSTATE.SystemDeviceMap),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_OBP_SILODRIVERSTATE.SystemDosDeviceState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_OBP_SILODRIVERSTATE.DeviceMapLock),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_OBP_SILODRIVERSTATE.PrivateNamespaceLookupTable),
                    new ulong[]
                    {
                        128UL
                    }
                }
            };
            Register<_OBP_SILODRIVERSTATE>((mem, ptr) => new _OBP_SILODRIVERSTATE(mem, ptr), offsets);
        }
    }
}