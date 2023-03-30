using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BulkCopySample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection SourceConnection = new SqlConnection
            ("Data Source=ANASTAS;Initial Catalog = Taxi_sluzba;" + "Integrated Security = True");

        private SqlConnection DestinationConnection = new SqlConnection
            ("Data Source=ANASTAS;Initial Catalog = Taxi_sluzba;" + "Integrated Security = True");

        private static DataSet SelectRows(string connectionString, string queryString)
        {
            DataSet dsX = new DataSet();
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    queryString, connection);
                adapter.Fill(dsX);
                return dsX;
            }
        }
        private void BulkCopyCustomer()
        {
            //SqlCommand GetCustomerCommand = new SqlCommand ("SELECT * FROM Vozenje", SourceConnection);

            //SourceConnection.Open();
            //SqlDataReader reader = GetCustomerCommand.ExecuteReader();

            /////////////
            string SQL_ConnectionString = "Data Source=ANASTAS;" +
            "Initial Catalog=Taxi_sluzba;" +
            "Integrated Security=True";

            string SQL_SelectStatement = "SELECT opis, Iznos " +
                                  "FROM Vozenje " +
                                  "WHERE Iznos >= " + 0.ToString();

            SqlDataAdapter adapter = new SqlDataAdapter(SQL_SelectStatement, SQL_ConnectionString);

            DataSet customers = new DataSet();
            adapter.Fill(customers, "Customers");

            //DataSet ds1 = SelectRows(connectionString, queryString);
            MessageBox.Show($"ima {customers.Tables[0].Rows.Count} redovi");

            /////////////////
            //if (reader.HasRows)
            //{
            //    int BrRedovi = 0;
            //    while (reader.Read())
            //    {
            //        BrRedovi++;
            //        var x1 = reader.GetString(7);

            //        MessageBox.Show($"{BrRedovi}       {x1} ");
            //    }
            //}

            return;
            // zapisuva
            //SqlBulkCopy BulkCopier = new SqlBulkCopy(DestinationConnection);
            //DestinationConnection.Open();

            //BulkCopier.DestinationTableName = "Vozenje";
            //BulkCopier.WriteToServer(reader);

            //reader.Close ();
            //SourceConnection.Close ();
            //DestinationConnection.Close ();
        }

        private void BulkCopyOrders()
        {
            SqlCommand GetOrdersCommand = new SqlCommand ("SELECT * FROM Orders",SourceConnection);

            SourceConnection.Open();
            SqlDataReader reader = GetOrdersCommand.ExecuteReader ();

            SqlBulkCopy BulkCopier = new SqlBulkCopy (DestinationConnection);

            DestinationConnection.Open();
            BulkCopier.DestinationTableName = "OrderHistory";
            BulkCopier.WriteToServer (reader);

            reader.Close();
            SourceConnection.Close (); 
            DestinationConnection.Close();
        }
        private void CopyCustomersButton_Click(object sender, EventArgs e)
        {
            BulkCopyCustomer();
        }

        private void CopyOrderButton_Click(object sender, EventArgs e)
        {
            BulkCopyOrders();
        }

        private void button1_Click(object sender, EventArgs e)// SELECT
        {
            double IznosOd = 0;
            double.TryParse(txtIznos.Text, out IznosOd);

            string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                          "Initial Catalog=Taxi_sluzba;" +
                                          "Integrated Security=True";

            string SQL_SelectStatement = "SELECT id, opis, Iznos, Kilometri " +
                                         "FROM Vozenje " +
                                         "WHERE Iznos >= " + IznosOd;

            adapter = new SqlDataAdapter(SQL_SelectStatement, SQL_ConnectionString);

            dsxx1 = new DataSet();
            adapter.Fill(dsxx1, "Anastas");


            MessageBox.Show($"ima {dsxx1.Tables[0].Rows.Count} redovi");

            dataGridView1.DataSource = dsxx1.Tables["Anastas"].DefaultView;

            dataGridView1.Columns["ID"].Visible = false;

            dataGridView1.Columns["opis"].Width = 100;
            dataGridView1.Columns["kilometri"].Width = 50;
            dataGridView1.Columns["iznos"].Width = 50;

            foreach (DataGridViewColumn cll in dataGridView1.Columns)
            {
                cll.SortMode = DataGridViewColumnSortMode.NotSortable; // Ne dava moznost da gi sortiras kolonite vo tabelata
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string Nazivkolona = dataGridView1.Columns[e.ColumnIndex].DataPropertyName.ToUpper();

            if (Nazivkolona == "IZNOS")
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                e.CellStyle.Format = "0.00";
            }
            else if (Nazivkolona == "KILOMETRI")
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                e.CellStyle.Format = "0.0";
            }

        }

        SqlDataAdapter adapter;
        DataSet dsxx1;
        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Are you sure to save Changes", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                DataTable AllchangedTable = dsxx1.Tables[0].GetChanges();

                DataTable UpdateRowsTable = dsxx1.Tables[0].GetChanges(DataRowState.Modified);
                DataTable DeleteRowsTable = dsxx1.Tables[0].GetChanges(DataRowState.Deleted);
                DataTable NewRowsTable = dsxx1.Tables[0].GetChanges(DataRowState.Added);

                if (AllchangedTable != null)
                {
                    MessageBox.Show($"Site Promeni vo {AllchangedTable.Rows.Count} redovi ");

                    if (UpdateRowsTable != null)
                    {
                        if (UpdateRowsTable.Rows.Count > 0)
                        {
                            foreach (DataRow xRow in UpdateRowsTable.Rows)
                            {
                                MessageBox.Show($"update  id={xRow[0]}  {xRow["opis"]}");

                                string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                                  "Initial Catalog=Taxi_sluzba;" +
                                                  "Integrated Security=True";

                                string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis='{xRow["opis"]}',kilometri={xRow["kilometri"]} WHERE id={xRow[0]}";

                                SqlConnection con = new SqlConnection(SQL_ConnectionString);
                                con.Open();

                                SqlCommand cmd = new SqlCommand(SQL_SelectStatement, con);
                                cmd.ExecuteNonQuery();
                                con.Close();

                                
                            }

                            dsxx1.Tables[0].AcceptChanges();
                        }
                    }

                    if (DeleteRowsTable != null)
                    {
                        if (DeleteRowsTable.Rows.Count > 0)
                        {
                            MessageBox.Show($"Brisani vo {DeleteRowsTable.Rows.Count} redovi ");

                            foreach (DataRow xRow in DeleteRowsTable.Rows)
                            {
                                MessageBox.Show($"deleted id={xRow[0,DataRowVersion.Original]}  opis={xRow["opis", DataRowVersion.Original]}");

                                string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                         "Initial Catalog=Taxi_sluzba;" +
                                         "Integrated Security=True";

                                string SQL_SelectStatement = $"DELETE Vozenje WHERE id={xRow[0, DataRowVersion.Original]}";


                                SqlConnection con = new SqlConnection(SQL_ConnectionString);
                                con.Open();

                                SqlCommand cmd = new SqlCommand(SQL_SelectStatement, con);
                                cmd.ExecuteNonQuery();
                                con.Close();

                            }
                            dsxx1.Tables[0].AcceptChanges();
                            //for (int i = 0; i < DeleteRowsTable.Rows.Count; i++)
                            //{
                            //    MessageBox.Show($"deleted {i}  {DeleteRowsTable.Rows[i][0, DataRowVersion.Original]}");
                            //}

                        }
                    }

                    if (NewRowsTable != null)
                    {
                        if (NewRowsTable.Rows.Count > 0)
                        {
                            MessageBox.Show($"Novi vo  {NewRowsTable.Rows.Count} redovi ");

                            foreach (DataRow xRow in NewRowsTable.Rows)
                            {
                                MessageBox.Show($"nov red    /{xRow[0]}/   opis=/{xRow["opis"]}/ kilometri=/{xRow["kilometri"]}/");


                                string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                                              "Initial Catalog=Taxi_sluzba;" +
                                                              "Integrated Security=True";


                                //string SQL_SelectStatement = "INSERT INTO Vozenje VALUES ('" + "2022-10-16 15:00:00.000" + "','" + "2022-10-16 15:00:00.000" + "',155,562,653,454,'SSS')";
                                //$"'{dtp1.Value}','{dtp2.Value}',{Vredn_1},{Vredn_2},{Vredn_3},{Vredn_4},'{textBox5.Text}'"
                                string SQL_SelectStatement = "INSERT INTO Vozenje VALUES (" +
                                                             $"'2022-10-16 15:00:00.000','2022-10-16 15:00:00.000'," +
                                                             $"{xRow["kilometri"]},{xRow["iznos"]},1,2,'{xRow["opis"]}'"
                                                             + ")";


                                SqlConnection con = new SqlConnection(SQL_ConnectionString);
                                con.Open();

                                SqlCommand cmd = new SqlCommand(SQL_SelectStatement, con);
                                cmd.ExecuteNonQuery();
                                con.Close();

                                
                            }
                            dsxx1.Tables[0].AcceptChanges();
                        }
                    }

                }


            }
        }
        private void button2_Click(object sender, EventArgs e) //INSERT
        {
            int Vredn_1 = 0;
            int.TryParse(textBox1.Text, out Vredn_1);
            double Vredn_2 = 0;
            double.TryParse(textBox2.Text, out Vredn_2);
            int Vredn_3 = 0;
            int.TryParse(textBox3.Text, out Vredn_3);
            int Vredn_4 = 0;
            int.TryParse(textBox4.Text, out Vredn_4);

            if (Vredn_1 <= 0)
            {
                MessageBox.Show($"Vnesi kaj vredn.1");
                textBox1.Focus();
                return;
            }

            string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                          "Initial Catalog=Taxi_sluzba;" +
                                          "Integrated Security=True";


            //string SQL_SelectStatement = "INSERT INTO Vozenje VALUES ('" + "2022-10-16 15:00:00.000" + "','" + "2022-10-16 15:00:00.000" + "',155,562,653,454,'SSS')";

            string SQL_SelectStatement = "INSERT INTO Vozenje VALUES (" + 
                                         $"'{dtp1.Value}','{dtp2.Value}',{Vredn_1},{Vredn_2},{Vredn_3},{Vredn_4},'{textBox5.Text}'" 
                                         + ")";


            SqlConnection con = new SqlConnection(SQL_ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(SQL_SelectStatement, con);
            cmd.ExecuteNonQuery();
            con.Close();

            button2.Text = "Done!";

            MessageBox.Show("Inserted sucessfully");
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "";


        }
        private void button3_Click(object sender, EventArgs e) //UPDATE
        {
            int xID = 0;
            int.TryParse(textBox6.Text, out xID);
            if (xID <= 0)
            {
                MessageBox.Show($"Vnesi ID");
                textBox6.Focus();
                return;
            }

            int xKilometri = 0;
            int.TryParse(textBox8.Text, out xKilometri);

            string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                          "Initial Catalog=Taxi_sluzba;" +
                                          "Integrated Security=True";

            //"2022-10-16 15:00:00.000"
            //string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis='{textBox7.Text}' WHERE id='20'";
            //string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis={textBox7.Text} WHERE id={xID}";
            //string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis={textBox7.Text},kilometri={xKilometri} WHERE id={xID}";
            string SQL_SelectStatement = "UPDATE Vozenje SET " + $"Data_od='{dtp_3.Value.ToString("yyyy-MM-dd HH:mm:ss")}',opis='{textBox7.Text}',kilometri={xKilometri} WHERE id={xID}";

            SqlConnection con = new SqlConnection(SQL_ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(SQL_SelectStatement, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Update sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int xID = 0;
            int.TryParse(textBox9.Text, out xID);
            if (xID <= 0)
            {
                MessageBox.Show($"Vnesi ID");
                textBox9.Focus();
                return;
            }

            int xKilometri = 0;
            int.TryParse(textBox8.Text, out xKilometri);

            string SQL_ConnectionString = "Data Source=ANASTAS;" +
                                          "Initial Catalog=Taxi_sluzba;" +
                                          "Integrated Security=True";

            //"2022-10-16 15:00:00.000"
            //string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis='{textBox7.Text}' WHERE id='20'";
            //string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis={textBox7.Text} WHERE id={xID}";
            //string SQL_SelectStatement = "UPDATE Vozenje SET " + $"opis={textBox7.Text},kilometri={xKilometri} WHERE id={xID}";
            string SQL_SelectStatement = $"DELETE Vozenje WHERE id={xID}"; 
                

            SqlConnection con = new SqlConnection(SQL_ConnectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(SQL_SelectStatement, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted sucessfully");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataTable changedTable = dsxx1.Tables[0].GetChanges();
            if (changedTable != null)
            {
                MessageBox.Show($"Ima Promeni vo  {changedTable.Rows.Count}");

                //e.Cancel = true;
                return;
            }
        }

        private void dtp_3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
