using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_DUMP_INITIALIZATION_CONTEXT")]
    public sealed class _DUMP_INITIALIZATION_CONTEXT : DynamicStructure
    {
        public uint Length { get; }
        public uint Reserved { get; }
        public IntPtr MemoryBlock { get; }
        public byte[] CommonBuffer { get; }
        public byte[] PhysicalAddress { get; }
        public IntPtr StallRoutine { get; }
        public IntPtr OpenRoutine { get; }
        public IntPtr WriteRoutine { get; }
        public IntPtr FinishRoutine { get; }
        public IntPtr AdapterObject { get; }
        public IntPtr MappedRegisterBase { get; }
        public IntPtr PortConfiguration { get; }
        public byte CrashDump { get; }
        public byte MarkMemoryOnly { get; }
        public byte HiberResume { get; }
        public byte InitDumpStackInvoked { get; }
        public uint MaximumTransferSize { get; }
        public uint CommonBufferSize { get; }
        public IntPtr TargetAddress { get; }
        public IntPtr WritePendingRoutine { get; }
        public uint PartitionStyle { get; }
        public _unnamed_tag_ DiskInfo { get; }
        public IntPtr ReadRoutine { get; }
        public IntPtr GetDriveTelemetryRoutine { get; }
        public uint LogSectionTruncateSize { get; }
        public uint[] Parameters { get; }
        public IntPtr GetTransferSizesRoutine { get; }
        public IntPtr DumpNotifyRoutine { get; }

        public _DUMP_INITIALIZATION_CONTEXT(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _DUMP_INITIALIZATION_CONTEXT()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.Length),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.Reserved),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.MemoryBlock),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.CommonBuffer),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.PhysicalAddress),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.StallRoutine),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.OpenRoutine),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.WriteRoutine),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.FinishRoutine),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.AdapterObject),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.MappedRegisterBase),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.PortConfiguration),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.CrashDump),
                    new ulong[]
                    {
                        104UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.MarkMemoryOnly),
                    new ulong[]
                    {
                        105UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.HiberResume),
                    new ulong[]
                    {
                        106UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.InitDumpStackInvoked),
                    new ulong[]
                    {
                        107UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.MaximumTransferSize),
                    new ulong[]
                    {
                        108UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.CommonBufferSize),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.TargetAddress),
                    new ulong[]
                    {
                        120UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.WritePendingRoutine),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.PartitionStyle),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.DiskInfo),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.ReadRoutine),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.GetDriveTelemetryRoutine),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.LogSectionTruncateSize),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.Parameters),
                    new ulong[]
                    {
                        180UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.GetTransferSizesRoutine),
                    new ulong[]
                    {
                        248UL
                    }
                },
                {
                    nameof(_DUMP_INITIALIZATION_CONTEXT.DumpNotifyRoutine),
                    new ulong[]
                    {
                        256UL
                    }
                }
            };
            Register<_DUMP_INITIALIZATION_CONTEXT>((mem, ptr) => new _DUMP_INITIALIZATION_CONTEXT(mem, ptr), offsets);
        }
    }
}