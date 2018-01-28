using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sqlQuery()
        {
            return rTBQuery.Text;
        }

        private string server;
        private string port;
        private string username;
        private bool connectionStatus;
        private OdbcConnection DataBaseConnection;
        private DataSet dataSetDB = new DataSet();
        private OdbcDataAdapter adapterDB = new OdbcDataAdapter();
        private OdbcCommandBuilder commandDB;



        //Odczytywanie pliku z zapytaniem SQL 
        private string readFile(string title, string filter)
        {
            rTBConsole.Text = rTBConsole.Text + "<<Wczytywanie pliku SQL>>\n";
            string file = "";
            OpenFileDialog openInputFile = new OpenFileDialog();
            openInputFile.Title = title;
            openInputFile.Filter = filter;

            if (openInputFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(openInputFile.FileName));

                file = read.ReadToEnd();
                read.Dispose();
                rTBConsole.Text = rTBConsole.Text + "<<Wczytano plik ''" + openInputFile.FileName + "''>>\n";
                //Jeżeli długość mniejsza niż 100 to zwartość pliku zostanie wyświetlona w konsoli. 
                if (file.Length < 100)
                {
                    rTBConsole.Text = rTBConsole.Text + "<<\n" + file + "\n>>\n";
                    return file;
                }
                return file;
            }
            else
            {
                rTBConsole.Text = rTBConsole.Text + "<<Przerwano wczytywanie pliku SQL>>\n";
                return file;
            }
        }

        private void bReadSQLFile_Click(object sender, EventArgs e)
        {
            rTBQuery.Text = readFile("Wczytywanie pliku SQL", "SQL files (*.sql)|*.sql");
        }

        //Łączenie i rozłączanie z bazą danych.
        private void bDBConnection_Click(object sender, EventArgs e)
        {
            if(connectionStatus == false)
            {
                connectionStatus = initializeDBConnection(tBoxHostname.Text, tBoxConnectionPort.Text, tBoxUsername.Text, tBoxPassword.Text);
                if(connectionStatus == true)
                {
                    bDBConnection.Text = "Rozłącz z bazą.";
                }
            }
            else if(connectionStatus == true)
            {
                closeConnection();
                bDBConnection.Text = "Połącz z bazą.";
                rTBConsole.Text = rTBConsole.Text + "<<Rozłączono z bazą>>\n";

            }
        }

        //Zamykanie połączenia
        private void closeConnection()
        {
            DataBaseConnection.Close();
            connectionStatus = false;
        }

        //Rozpoczynanie połączenia
        private bool initializeDBConnection(string host, string connectionPort, string user, string pass)
        {
            server = host;
            port = connectionPort;
            username = user;
            string password = pass;

            string connectionString = "Dsn=Postgres;server=" + server + ";port=" + port + ";uid=" + user + ";sslmode=disable;pwd=" + password+";";

            DataBaseConnection = new OdbcConnection(connectionString);
            try
            {
                DataBaseConnection.Open();
                rTBConsole.Text = rTBConsole.Text + "<<Połączono z bazą danych>>\n";
                return true;
            }
            catch (OdbcException ex)
            {

                rTBConsole.Text = rTBConsole.Text + ex.Message + "\n\n";
                //rTBConsole.Text = rTBConsole.Text + ex.Message + "\n\n" + ex.StackTrace;
                return false;
            }
        }


        //Wykonywanie zapytań
        private void bDoQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectionStatus == true)
                {
                    commandDB = new OdbcCommandBuilder(adapterDB);
                    adapterDB.SelectCommand = new OdbcCommand(sqlQuery(), DataBaseConnection);
                    adapterDB.Fill(dataSetDB);
                    rTBConsole.Text = rTBConsole.Text + "<<Zapytanie: >>\n";
                    rTBConsole.Text = rTBConsole.Text + sqlQuery() + "\n";
                    rTBConsole.Text = rTBConsole.Text + "<<zostało wykonane>>\n";
                    //rTBConsole.Text = rTBConsole.Text + dataSetDB.Tables[0].Rows.Count + "\n\n";
                }
                else
                {
                    rTBConsole.Text = rTBConsole.Text + "<<Aby wykonać zapytanie połącz się z bazą danych>>\n";
                }
            }
            catch (OdbcException ex)
            {
                rTBConsole.Text = rTBConsole.Text + ex.Message + "\n\n";
                //rTBConsole.Text = rTBConsole.Text + ex.Message + "\n\n" + ex.StackTrace;
            }
            catch (InvalidOperationException)
            {
                rTBConsole.Text = rTBConsole.Text + "<<Zapytanie jest niepoprawne>>\n";
            }
        }
    }
}
