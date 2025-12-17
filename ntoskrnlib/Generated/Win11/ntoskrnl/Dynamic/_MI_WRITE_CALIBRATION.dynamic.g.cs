using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_MI_WRITE_CALIBRATION")]
    public sealed class _MI_WRITE_CALIBRATION : DynamicStructure
    {
        public uint MaximumNumberProcessors { get; }
        public byte OptimalWriteType { get; }
        public byte CalibrationCompleted { get; }
        public byte[] CalibrationFinal { get; }
        public ulong PerProcessorNumberOfBytes { get; }
        public ulong[] PerProcessorBandwidth { get; }
        public byte[] OptimalWriteProcessors { get; }
        public IntPtr PureZeroing { get; }

        public _MI_WRITE_CALIBRATION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MI_WRITE_CALIBRATION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MI_WRITE_CALIBRATION.MaximumNumberProcessors),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.OptimalWriteType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.CalibrationCompleted),
                    new ulong[]
                    {
                        5UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.CalibrationFinal),
                    new ulong[]
                    {
                        6UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.PerProcessorNumberOfBytes),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.PerProcessorBandwidth),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.OptimalWriteProcessors),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_MI_WRITE_CALIBRATION.PureZeroing),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_MI_WRITE_CALIBRATION>((mem, ptr) => new _MI_WRITE_CALIBRATION(mem, ptr), offsets);
        }
    }
}