using System;
using SQLite;

namespace MAUILite.Utils
{
	public class Util
	{
        private const string DBFileName = "Producto.db";

        public const SQLiteOpenFlags Flags =
           SQLiteOpenFlags.ReadWrite |
           SQLiteOpenFlags.Create |
           SQLiteOpenFlags.SharedCache;

        public static string DataBasePath
        {
            get
            {
                return Path.Combine(FileSystem.AppDataDirectory, DBFileName);
            }
        }
    }
}

