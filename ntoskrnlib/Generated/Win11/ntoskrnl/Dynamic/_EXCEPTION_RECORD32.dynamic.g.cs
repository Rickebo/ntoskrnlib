using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_EXCEPTION_RECORD32")]
    public sealed class _EXCEPTION_RECORD32 : DynamicStructure
    {
        public int ExceptionCode { get; }
        public uint ExceptionFlags { get; }
        public uint ExceptionRecord { get; }
        public uint ExceptionAddress { get; }
        public uint NumberParameters { get; }
        public uint[] ExceptionInformation { get; }

        public _EXCEPTION_RECORD32(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _EXCEPTION_RECORD32()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_EXCEPTION_RECORD32.ExceptionCode),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD32.ExceptionFlags),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD32.ExceptionRecord),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD32.ExceptionAddress),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD32.NumberParameters),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_EXCEPTION_RECORD32.ExceptionInformation),
                    new ulong[]
                    {
                        20UL
                    }
                }
            };
            Register<_EXCEPTION_RECORD32>((mem, ptr) => new _EXCEPTION_RECORD32(mem, ptr), offsets);
        }
    }
}