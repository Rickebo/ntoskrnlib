using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_EXCEPTION_RECORD")]
    public sealed class _EXCEPTION_RECORD : DynamicStructure
    {
        public int ExceptionCode { get; }
        public uint ExceptionFlags { get; }
        public IntPtr ExceptionRecord { get; }
        public IntPtr ExceptionAddress { get; }
        public uint NumberParameters { get; }
        public ulong[] ExceptionInformation { get; }

        public _EXCEPTION_RECORD(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXCEPTION_RECORD()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXCEPTION_RECORD.ExceptionCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD.ExceptionFlags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD.ExceptionRecord),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD.ExceptionAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD.NumberParameters),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD.ExceptionInformation),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_EXCEPTION_RECORD>((mem, ptr) => new _EXCEPTION_RECORD(mem, ptr), offsets);
        }
    }
}