using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_RECORD64")]
    public sealed class _EXCEPTION_RECORD64 : DynamicStructure
    {
        public int ExceptionCode { get; }
        public uint ExceptionFlags { get; }
        public ulong ExceptionRecord { get; }
        public ulong ExceptionAddress { get; }
        public uint NumberParameters { get; }
        public uint __unusedAlignment { get; }
        public ulong[] ExceptionInformation { get; }

        public _EXCEPTION_RECORD64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXCEPTION_RECORD64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXCEPTION_RECORD64.ExceptionCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD64.ExceptionFlags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD64.ExceptionRecord),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD64.ExceptionAddress),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD64.NumberParameters),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD64.__unusedAlignment),
                    new ulong[]
                    {
                        28UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD64.ExceptionInformation),
                    new ulong[]
                    {
                        32UL
                    }
                }
            };
            Register<_EXCEPTION_RECORD64>((mem, ptr) => new _EXCEPTION_RECORD64(mem, ptr), offsets);
        }
    }
}