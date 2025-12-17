using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_NT_TIB64")]
    public sealed class _NT_TIB64 : DynamicStructure
    {
        public ulong ExceptionList { get; }
        public ulong StackBase { get; }
        public ulong StackLimit { get; }
        public ulong SubSystemTib { get; }
        public ulong FiberData { get; }
        public uint Version { get; }
        public ulong ArbitraryUserPointer { get; }
        public ulong Self { get; }

        public _NT_TIB64(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_TIB64()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_TIB64.ExceptionList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_TIB64.StackBase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_TIB64.StackLimit),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_TIB64.SubSystemTib),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_TIB64.FiberData),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_TIB64.Version),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_TIB64.ArbitraryUserPointer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_NT_TIB64.Self),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_NT_TIB64>((mem, ptr) => new _NT_TIB64(mem, ptr), offsets);
        }
    }
}