using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _28Nov
{
    public class ProcParams
    {
        public string Name;
        public string Value;
        public   DbType DataType;
        public ParameterDirection Direction;

        public ProcParams(string Name, string Value, DbType DataType, ParameterDirection Direction)
        {
            this.Name = Name;
            this.DataType = DataType;
            this.Value = Value;
            this.Direction = Direction;
        }

    }
}