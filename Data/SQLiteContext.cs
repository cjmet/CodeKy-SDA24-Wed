using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Data
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public string DbPathName { get; private set; } = "MudBlazor.db";
        public bool VerboseSQL { get; set; } = true;
        

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
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            DbPathName = Path.Join(path, DbPathName);
            LogToDebug($"SQLite DbPath: {DbPathName}");
            LogToDebug($"SQLite ContextId: {this.ContextId}");
            this.Database.EnsureCreated();  // this isn't the best way to do this, but it works for now.
        }


    }

}
