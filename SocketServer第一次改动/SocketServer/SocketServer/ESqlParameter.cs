using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Data;


namespace SocketServer
{
    [Serializable]
    class ESqlParameter
    {
        public ESqlParameter(SqlParameter sPara)
        {
            this.paraName = sPara.ParameterName;
            this.paraLen = sPara.Size;
            this.paraVal = sPara.Value;
            this.sqlDbType = sPara.SqlDbType;
        }

        public SqlParameter ToSqlParameter()
        {
            SqlParameter para = new SqlParameter(this.paraName, this.sqlDbType, this.paraLen);
            para.Value = this.paraVal;

            return para;
        }

        #region ParaName
        private string paraName = "";
        public string ParaName
        {
            get
            {
                return this.paraName;
            }
            set
            {
                this.paraName = value;
            }
        }
        #endregion

        #region ParaLen
        private int paraLen = 0;
        public int ParaLen
        {
            get
            {
                return this.paraLen;
            }
            set
            {
                this.paraLen = value;
            }
        }
        #endregion

        #region ParaVal
        private object paraVal = null;
        public object ParaVal
        {
            get
            {
                return this.paraVal;
            }
            set
            {
                this.paraVal = value;
            }
        }
        #endregion

        #region SqlDbType
        private SqlDbType sqlDbType = SqlDbType.NVarChar;
        public SqlDbType SqlDbType
        {
            get
            {
                return this.sqlDbType;
            }
            set
            {
                this.sqlDbType = value;
            }
        }
        #endregion
    }
}
