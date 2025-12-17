using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_NT_TIB")]
    public sealed class _NT_TIB : DynamicStructure
    {
        public IntPtr ExceptionList { get; }
        public IntPtr StackBase { get; }
        public IntPtr StackLimit { get; }
        public IntPtr SubSystemTib { get; }
        public IntPtr FiberData { get; }
        public uint Version { get; }
        public IntPtr ArbitraryUserPointer { get; }
        public IntPtr Self { get; }

        public _NT_TIB(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _NT_TIB()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_NT_TIB.ExceptionList),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_NT_TIB.StackBase),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_NT_TIB.StackLimit),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_NT_TIB.SubSystemTib),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_NT_TIB.FiberData),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_TIB.Version),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_NT_TIB.ArbitraryUserPointer),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_NT_TIB.Self),
                    new ulong[]
                    {
                        48UL
                    }
                }
            };
            Register<_NT_TIB>((mem, ptr) => new _NT_TIB(mem, ptr), offsets);
        }
    }
}