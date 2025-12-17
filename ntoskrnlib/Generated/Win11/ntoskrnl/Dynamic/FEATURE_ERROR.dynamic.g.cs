using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!FEATURE_ERROR")]
    public sealed class FEATURE_ERROR : DynamicStructure
    {
        public int hr { get; }
        public ushort lineNumber { get; }
        public IntPtr file { get; }
        public IntPtr process { get; }
        public IntPtr modulePath { get; }
        public uint callerReturnAddressOffset { get; }
        public IntPtr callerModule { get; }
        public IntPtr message { get; }
        public ushort originLineNumber { get; }
        public IntPtr originFile { get; }
        public IntPtr originModule { get; }
        public uint originCallerReturnAddressOffset { get; }
        public IntPtr originCallerModule { get; }
        public IntPtr originName { get; }

        public FEATURE_ERROR(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static FEATURE_ERROR()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(FEATURE_ERROR.hr),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.lineNumber),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.file),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.process),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.modulePath),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.callerReturnAddressOffset),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.callerModule),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.message),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.originLineNumber),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.originFile),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.originModule),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.originCallerReturnAddressOffset),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.originCallerModule),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(FEATURE_ERROR.originName),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<FEATURE_ERROR>((mem, ptr) => new FEATURE_ERROR(mem, ptr), offsets);
        }
    }
}