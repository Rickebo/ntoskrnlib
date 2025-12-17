using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_TRIAGE_POP_FX_DEVICE")]
    public sealed class _TRIAGE_POP_FX_DEVICE : DynamicStructure
    {
        public _LIST_ENTRY Link { get; }
        public IntPtr Irp { get; }
        public IntPtr IrpData { get; }
        public int Status { get; }
        public int PowerReqCall { get; }
        public int PowerNotReqCall { get; }
        public IntPtr DeviceNode { get; }

        public _TRIAGE_POP_FX_DEVICE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _TRIAGE_POP_FX_DEVICE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.Link),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.Irp),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.IrpData),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.Status),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.PowerReqCall),
                    new ulong[]
                    {
                        36UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.PowerNotReqCall),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_TRIAGE_POP_FX_DEVICE.DeviceNode),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_TRIAGE_POP_FX_DEVICE>((mem, ptr) => new _TRIAGE_POP_FX_DEVICE(mem, ptr), offsets);
        }
    }
}