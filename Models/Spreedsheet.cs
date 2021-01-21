using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador.Models
{
    public class Spreedsheet
    {
        public Spreedsheet(String title)
        {
            Title = title;
            Dialog = new OpenFileDialog();
        }

        public string Title
        {
            get => Dialog.Title;
            set
            {
                if (value != null && Dialog!=null)
                    Dialog.Title = value;
            }
        }

        public string FileName
        {
            get => Dialog.FileName;
            set
            {
                Dialog.FileName = value;
                GetTabelaExcel();
            }
        }

        public OpenFileDialog Dialog;
        public DataTable DataTable
        {
            get;
            set;
        }

        public DataTable GetTabelaExcel()
        {
            DataTable = new DataTable();
            try
            {
                string ext = Path.GetExtension(FileName);
                string connectionString = "";
                Console.WriteLine(FileName);
                if (ext == ".xls")
                {
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + FileName + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (ext == ".xlsx")
                {
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + FileName + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                if (dtSchema != null)
                {
                    string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                    conn.Close();
                    conn.Open();
                    cmd.CommandText = "SELECT * from [" + nomePlanilha + "]";
                }

                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(DataTable);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return DataTable;
        }


        public bool OpenFile()
        {
            if (Dialog.ShowDialog() != DialogResult.OK) return false;
            return true;
        }
    }
}
