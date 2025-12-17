using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE")]
    public sealed class _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE : DynamicStructure
    {
        public IntPtr DeviceHandle { get; }
        public uint CompletionFlags { get; }
        public int MethodStatus { get; }
        public IntPtr CompletionContext { get; }
        public ulong OutputArgumentSize { get; }
        public IntPtr OutputArguments { get; }

        public _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE.DeviceHandle),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE.CompletionFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE.MethodStatus),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE.CompletionContext),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE.OutputArgumentSize),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE.OutputArguments),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE>((mem, ptr) => new _PEP_WORK_ACPI_EVALUATE_CONTROL_METHOD_COMPLETE(mem, ptr), offsets);
        }
    }
}