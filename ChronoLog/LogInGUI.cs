using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ChronoLog {
    public partial class LogInGUI : Form {

        DatabaseConnection conn = new DatabaseConnection();
        ProgramData progdata = new ProgramData();

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader rd;
        
        public LogInGUI() {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e) {

            progdata.UsageTimeStart = DateTime.Now;

            string usageTimeStartFormatted = progdata.UsageTimeStart.ToString("HH:mm");

            cn = conn.GetConnection();
            cn.Open();

            cmd = new SqlCommand("insert into ChronoLogDataTable values ('" + usageTimeStartFormatted + "')", cn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
        }

    }
}
