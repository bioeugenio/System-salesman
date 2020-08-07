using Hiq.Dxs.SystemSalesman.DataAccess.Context;
using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new ApplicationContext();
            database.Database.EnsureDeleted();
            database.Database.EnsureCreated();
        }
    }
}
