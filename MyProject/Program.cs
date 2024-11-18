
using Npgsql;
using System;


class Program 
{
    static void Main(string[] args)
    {
        string connectionString = ("Server=localhost;Password=lamis;Database=lamisplus; User Id=postgres;Port=5432;");
		string query = "SELECT * from patient_person"
		try
		{
			using (var conn = new NpgsqlConnection(connectionString))
			{
				conn.Open();
				Console.WriteLine("Successfully Connected to EMR");

			}
		}
		catch (Exception connException)
		{

			Console.WriteLine($"A critical Error occur check Details:{connException}");
		}
    }
}


