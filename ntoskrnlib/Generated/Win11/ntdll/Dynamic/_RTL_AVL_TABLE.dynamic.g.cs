using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll.Dynamic
{
    [DynamicStructure("ntdll!_RTL_AVL_TABLE")]
    public sealed class _RTL_AVL_TABLE : DynamicStructure
    {
        public _RTL_BALANCED_LINKS BalancedRoot { get; }
        public IntPtr OrderedPointer { get; }
        public uint WhichOrderedElement { get; }
        public uint NumberGenericTableElements { get; }
        public uint DepthOfTree { get; }
        public IntPtr RestartKey { get; }
        public uint DeleteCount { get; }
        public IntPtr CompareRoutine { get; }
        public IntPtr AllocateRoutine { get; }
        public IntPtr FreeRoutine { get; }
        public IntPtr TableContext { get; }

        public _RTL_AVL_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_AVL_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_AVL_TABLE.BalancedRoot),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.OrderedPointer),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.WhichOrderedElement),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.NumberGenericTableElements),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.DepthOfTree),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.RestartKey),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.DeleteCount),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.CompareRoutine),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.AllocateRoutine),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.FreeRoutine),
                    new ulong[]
                    {
                        88UL
                    }
                },
                {
                    nameof(_RTL_AVL_TABLE.TableContext),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_RTL_AVL_TABLE>((mem, ptr) => new _RTL_AVL_TABLE(mem, ptr), offsets);
        }
    }
}