using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HANDLE_TRACE_DEBUG_INFO")]
    public sealed class _HANDLE_TRACE_DEBUG_INFO : DynamicStructure
    {
        public int RefCount { get; }
        public uint TableSize { get; }
        public uint BitMaskFlags { get; }
        public _FAST_MUTEX CloseCompactionLock { get; }
        public uint CurrentStackIndex { get; }
        public byte[] TraceDb { get; }

        public _HANDLE_TRACE_DEBUG_INFO(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_TRACE_DEBUG_INFO()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_TRACE_DEBUG_INFO.RefCount),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DEBUG_INFO.TableSize),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DEBUG_INFO.BitMaskFlags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DEBUG_INFO.CloseCompactionLock),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DEBUG_INFO.CurrentStackIndex),
                    new ulong[]
                    {
                        72UL
                    }
                },
                {
                    nameof(_HANDLE_TRACE_DEBUG_INFO.TraceDb),
                    new ulong[]
                    {
                        80UL
                    }
                }
            };
            Register<_HANDLE_TRACE_DEBUG_INFO>((mem, ptr) => new _HANDLE_TRACE_DEBUG_INFO(mem, ptr), offsets);
        }
    }
}