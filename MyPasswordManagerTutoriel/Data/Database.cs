using MyPasswordManagerTutoriel.Models;
using SQLite;

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
        //connection = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

        await connection.CreateTableAsync<LoginCredential>();
    }

    public async Task<List<LoginCredential>> GetItemsAsync()
    {
        await Initialize();
        return await connection.Table<LoginCredential>().ToListAsync();
    }

    public async Task<int> SaveItemAsync(LoginCredential item)
    {
        await Initialize();

        if (item.Id != 0)
        {
            return await connection.UpdateAsync(item);
        }
        else
        {
            return await connection.InsertAsync(item);
        }
    }

    public async Task<int> DeleteItemAsync(LoginCredential item)
    {
        await Initialize();
        return await connection.DeleteAsync(item);
    }
}
