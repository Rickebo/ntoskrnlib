using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_ACPI_NOTIFY")]
    public sealed class _PEP_WORK_ACPI_NOTIFY : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public uint NotifyCode { get; }

        public _PEP_WORK_ACPI_NOTIFY(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_ACPI_NOTIFY()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_ACPI_NOTIFY.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACPI_NOTIFY.NotifyCode),
                    new ulong[]
                    {
                        8UL
                    }
                }
            };
            Register<_PEP_WORK_ACPI_NOTIFY>((mem, ptr) => new _PEP_WORK_ACPI_NOTIFY(mem, ptr), offsets);
        }
    }
}