namespace placeholder;

using MySql.Data.MySqlClient;

public class Database
{
    private const string Cs = "Server=127.0.0.1;Port=3306;Database=garage;Uid=root;Pwd=;";
    public MySqlConnection Connect() => new MySqlConnection(Cs);
}