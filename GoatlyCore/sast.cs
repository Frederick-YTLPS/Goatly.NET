string username = "admin";
string password = "Admin123"; // Sensitive
string usernamePassword  = "user=admin&password=Admin123"; // Sensitive
string url = "scheme://user:Admin123@domain.com"; // Sensitive

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
  optionsBuilder.UseSqlServer("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password="); // Noncompliant
}
