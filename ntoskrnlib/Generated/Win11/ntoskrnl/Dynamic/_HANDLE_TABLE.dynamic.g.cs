using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_HANDLE_TABLE")]
    public sealed class _HANDLE_TABLE : DynamicStructure
    {
        public uint NextHandleNeedingPool { get; }
        public int ExtraInfoPages { get; }
        public ulong TableCode { get; }
        public IntPtr QuotaProcess { get; }
        public _LIST_ENTRY HandleTableList { get; }
        public uint UniqueProcessId { get; }
        public uint Flags { get; }
        public byte StrictFIFO { get; }
        public byte EnableHandleExceptions { get; }
        public byte Rundown { get; }
        public byte Duplicated { get; }
        public byte RaiseUMExceptionOnInvalidHandleClose { get; }
        public _EX_PUSH_LOCK HandleContentionEvent { get; }
        public _EX_PUSH_LOCK HandleTableLock { get; }
        public byte[] FreeLists { get; }
        public byte[] ActualEntry { get; }
        public IntPtr DebugInfo { get; }

        public _HANDLE_TABLE(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _HANDLE_TABLE()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_HANDLE_TABLE.NextHandleNeedingPool),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.ExtraInfoPages),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.TableCode),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.QuotaProcess),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.HandleTableList),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.UniqueProcessId),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.Flags),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.StrictFIFO),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.EnableHandleExceptions),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.Rundown),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.Duplicated),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.RaiseUMExceptionOnInvalidHandleClose),
                    new ulong[]
                    {
                        44UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.HandleContentionEvent),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.HandleTableLock),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.FreeLists),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.ActualEntry),
                    new ulong[]
                    {
                        64UL
                    }
                },
                {
                    nameof(_HANDLE_TABLE.DebugInfo),
                    new ulong[]
                    {
                        96UL
                    }
                }
            };
            Register<_HANDLE_TABLE>((mem, ptr) => new _HANDLE_TABLE(mem, ptr), offsets);
        }
    }
}