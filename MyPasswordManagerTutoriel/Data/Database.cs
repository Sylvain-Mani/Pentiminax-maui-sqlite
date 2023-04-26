using MyPasswordManagerTutoriel.Models;
using SQLite;
using System.Threading.Tasks;

namespace MyPasswordManagerTutoriel.Data;

public class Database
{
    private SQLiteAsyncConnection connection;

    public Database()
    {

    }

    private async Task Initialize() 
    {
        if (connection is not null)
            return;

        connection = new(Constants.DatabasePath);

        await connection.CreateTableAsync<LoginCredential>();
    }

    public async Task<List<LoginCredential>> GetItemsAsync()
    {
        await Initialize();
        return await connection.Table<LoginCredential>().ToListAsync();
    }
}
