using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Data
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        private string DbPathName { get; set; } = "MudBlazor.db";
        public bool VerboseSQL { get; set; } = true;
        

        public void DeleteDatabase()
        {
            this.Database.EnsureDeleted();
        }
        public void ResetDatabase()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.ChangeTracker.Clear();
        }
        private void LogToDebug(string logMessage)
        {
            if (VerboseSQL)
            {
                Debug.WriteLine(logMessage);
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IEnumerable<string> cats = ["DbLoggerCategory.Database.Command.Name"];

            optionsBuilder
                .UseSqlite($"Data Source={DbPathName}")
                .EnableSensitiveDataLogging()
                .LogTo(LogToDebug,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information,
                    DbContextLoggerOptions.None
                    );
        }

        public SQLiteContext()
        {
            //var path = Path.Combine(FileSystem.AppDataDirectory, "products.json");
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DbPathName = Path.Join(path, DbPathName);
            LogToDebug($"SQLite DbPath: {DbPathName}");
            LogToDebug($"SQLite ContextId: {this.ContextId}");
            if (!File.Exists(DbPathName))
            {
                LogToDebug($"Creating Database: {DbPathName}");
                this.Database.EnsureCreated();
            }
        }


    }

}
