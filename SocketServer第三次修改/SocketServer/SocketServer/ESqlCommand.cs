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
    class ESqlCommand
    {
        private ESqlParameter[] esParas;
        private string cmdText;
        private CommandType cmdType;
        public ESqlCommand(SqlCommand command)
        {
            this.cmdText = command.CommandText;
            this.cmdType = command.CommandType;

            this.esParas = new ESqlParameter[command.Parameters.Count];
            int index = 0;
            foreach (SqlParameter para in command.Parameters)
            {
                this.esParas[index] = new ESqlParameter(para);
                index++;
            }
        }

        public SqlCommand ToSqlCommand(string connStr)
        {
            SqlCommand command = new SqlCommand(this.cmdText, new SqlConnection(connStr), null);

            for (int i = 0; i < this.esParas.Length; i++)
            {
                command.Parameters.Add(this.esParas[i].ToSqlParameter());
            }

            command.CommandType = this.cmdType;
            return command;
        }
    }
}
