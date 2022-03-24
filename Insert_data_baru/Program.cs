using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_data_baru
{
    class Program 
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        private void InsertData()
        {
            SqlConnection con = null;
        try
            {
                con = new SqlConnection("data soruce=DESKTOP-CCBP8LR; database=ProdiTI;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Mahasiswa_Coba (NIM, Nama, Alamat, Jenis_Kelamin) values('2019010099','Ronald','Yogyakarta', 'L')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }   catch(Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data. " + e);
                Console.ReadKey();
            }   finally
            {
                con.Close();
            }
        }  

        }
    }

