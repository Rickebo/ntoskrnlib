using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_MCA_EXCEPTION")]
    public sealed class _MCA_EXCEPTION : DynamicStructure
    {
        public uint VersionNumber { get; }
        public uint ExceptionType { get; }
        public _LARGE_INTEGER TimeStamp { get; }
        public uint ProcessorNumber { get; }
        public uint Reserved1 { get; }
        public _unnamed_tag_ u { get; }
        public uint ExtCnt { get; }
        public uint Reserved3 { get; }
        public ulong[] ExtReg { get; }

        public _MCA_EXCEPTION(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _MCA_EXCEPTION()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_MCA_EXCEPTION.VersionNumber),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.ExceptionType),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.TimeStamp),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.ProcessorNumber),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.Reserved1),
                    new ulong[]
                    {
                        20UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.u),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.ExtCnt),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.Reserved3),
                    new ulong[]
                    {
                        60UL
                    }
                },
                {
                    nameof(_MCA_EXCEPTION.ExtReg),
                    new ulong[]
                    {
                        64UL
                    }
                }
            };
            Register<_MCA_EXCEPTION>((mem, ptr) => new _MCA_EXCEPTION(mem, ptr), offsets);
        }
    }
}