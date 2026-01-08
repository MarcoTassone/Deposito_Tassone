// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
using MySql.Data.MySqlClient;

class Program
{
  public static void Main(string[] args)
  {
    string connStr = "server=localhost;user=root;password=TwIcEoNcE01!;database=rubrica_db";
    bool continua = true;
    int scelta;

    while (continua)
    {
      Console.WriteLine("1 - Inserisci un nuovo contatto");
      Console.WriteLine("2 - Visualizza tutti i contatti");
      Console.WriteLine($"3 - Elimina un contatto per nome");
      Console.WriteLine($"4 - Esci");

      scelta = Convert.ToInt32(Console.ReadLine());

      switch (scelta)
      {
        case 1:
          InsertDB(connStr);
          break;
        case 2:
          VisualizeDB(connStr);
          break;
        case 3:
          DeleteContact(connStr);
          break;
        case 4:
          Console.WriteLine($"Arrivederci!");
          continua = false;
          break;
      }
    }
  }
  private static void InsertDB(string connStr)
  {
    using (MySqlConnection conn = new MySqlConnection(connStr))
    {
      conn.Open();
      Console.WriteLine($"Insersci il nome del nuovo contatto.");
      string? nome = Console.ReadLine();
      Console.WriteLine($"Inserisci il numero di telefono del nuovo contatto.");
      int numeroTel = Convert.ToInt32(Console.ReadLine());

      string query = $"INSERT INTO contatti (nome, telefono) VALUES (@nome, @telefono);";
      MySqlCommand cmd = new MySqlCommand(query, conn);

      cmd.Parameters.AddWithValue("@nome", nome);
      cmd.Parameters.AddWithValue("@telefono", numeroTel);

      cmd.ExecuteNonQuery();

      string verificaQuery = $"SELECT * FROM contatti ORDER BY id DESC LIMIT 1;";
      MySqlCommand verifica = new MySqlCommand(verificaQuery, conn);
      MySqlDataReader reader = verifica.ExecuteReader();

      if (reader.Read())
      {
        Console.WriteLine($"Ultimo record inserito - ID: {reader["id"]}, Nome: {reader["nome"]}, Telefono: {reader["telefono"]}");
      }

      reader.Close();
      Console.WriteLine($"Contatto inserito con successo.");
    }
  }

  private static void VisualizeDB(string connStr)
  {
    using (MySqlConnection conn = new MySqlConnection(connStr))
    {
      try
      {
        conn.Open();
        string query = $"SELECT * FROM contatti;";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
          Console.WriteLine($"ID: {reader["id"]}, Nome: {reader["nome"]}, Telefono: {reader["telefono"]}");
        }

        reader.Close();
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Errore: {ex.Message}");
      }
    }
  }

  private static void DeleteContact(string connStr)
  {
    using (MySqlConnection conn = new MySqlConnection(connStr))
    {
      try
      {
        conn.Open();
        Console.WriteLine($"Inserisci il nome del contatto da eliminare.");
        string? nome = Console.ReadLine();
        string query = $"DELETE FROM contatti WHERE Nome = '{nome}';";
        MySqlCommand cmd = new MySqlCommand(query, conn);
        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine($"Contatto eliminato con successo. Righe eliminate: {rowsAffected}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Errore: {ex.Message}");
      }
    }
  }
}
