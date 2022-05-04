using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace CinemaProjectUSP
{
    class Functions
    {
        OleDbConnection connect;
        OleDbCommand command;

        private void ConnectionTo() {
            connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Visual Studio Projects\CinemaProjectUSP\CinemaProjectUSP1.accdb");
            command = connect.CreateCommand();
            command.Connection = connect;
        }

        public Functions() {
            ConnectionTo();
        }


    }
}
