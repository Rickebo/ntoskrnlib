using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE")]
    public sealed class _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE : DynamicStructure
    {
        public byte[] buffer { get; }
        public _KDPC Dpc { get; }
        public ulong nSamplesAccumulated { get; }
        public ulong nHealthTestFailures { get; }
        public IntPtr pCombinedSampleBuffer { get; }
        public ulong nRawSamples { get; }
        public uint accumulatorId { get; }
        public uint nDPCScheduleFailures { get; }
        public byte dpcInProgress { get; }

        public _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.buffer),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.Dpc),
                    new ulong[]
                    {
                        256UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.nSamplesAccumulated),
                    new ulong[]
                    {
                        320UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.nHealthTestFailures),
                    new ulong[]
                    {
                        328UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.pCombinedSampleBuffer),
                    new ulong[]
                    {
                        336UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.nRawSamples),
                    new ulong[]
                    {
                        344UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.accumulatorId),
                    new ulong[]
                    {
                        352UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.nDPCScheduleFailures),
                    new ulong[]
                    {
                        356UL
                    }
                },
                {
                    nameof(_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE.dpcInProgress),
                    new ulong[]
                    {
                        360UL
                    }
                }
            };
            Register<_SYMCRYPT_ENTROPY_ACCUMULATOR_STATE>((mem, ptr) => new _SYMCRYPT_ENTROPY_ACCUMULATOR_STATE(mem, ptr), offsets);
        }
    }
}