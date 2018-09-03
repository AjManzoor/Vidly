namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDataToMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES (Name, Genre, ReleasedDate, DateAdded, Stock) Values ('Shrek', 'Comedy', '19920808', '20180827', 5)");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleasedDate, DateAdded, Stock) Values ('Xmen', 'Action', '20020708', '20180827', 9)");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleasedDate, DateAdded, Stock) Values ('Simpsons Movie', 'Animation', '20080812', '20180827', 12)");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleasedDate, DateAdded, Stock) Values ('Seven', 'Thriller', '20001030', '20180827', 20)");
            Sql("INSERT INTO MOVIES (Name, Genre, ReleasedDate, DateAdded, Stock) Values ('Matrix', 'Sci-Fi', '20081003', '20180827', 12)");

        }

        public override void Down()
        {
        }
    }
}
