using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_INFORMATION")]
    public sealed class _PEP_WORK_INFORMATION : DynamicStructure
    {
        public uint WorkType { get; }
        public _PEP_WORK_ACTIVE_COMPLETE ActiveComplete { get; }
        public _PEP_WORK_IDLE_STATE IdleState { get; }
        public _PEP_WORK_DEVICE_POWER DevicePower { get; }
        public _PEP_WORK_POWER_CONTROL PowerControl { get; }
        public _PEP_WORK_DEVICE_IDLE DeviceIdle { get; }
        public _PEP_WORK_COMPLETE_IDLE_STATE CompleteIdleState { get; }
        public _PEP_WORK_COMPLETE_PERF_STATE CompletePerfState { get; }
        public _PEP_WORK_ACPI_NOTIFY AcpiNotify { get; }
        public _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE ControlMethodComplete { get; }

        public _PEP_WORK_INFORMATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_INFORMATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_INFORMATION.WorkType),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.ActiveComplete),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.IdleState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.DevicePower),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.PowerControl),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.DeviceIdle),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.CompleteIdleState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.CompletePerfState),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.AcpiNotify),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_INFORMATION.ControlMethodComplete),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_WORK_INFORMATION>((mem, ptr) => new _PEP_WORK_INFORMATION(mem, ptr), offsets);
        }
    }
}