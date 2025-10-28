# DotNetTrainingBatch2.MiddlewareApp

```
dotnet ef dbcontext scaffold "Server=.;Database=Batch2.Middleware;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o AppDbContextModels -c AppDbContext -f
```

```
CREATE TABLE Tbl_User (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(100) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(150),
    Email NVARCHAR(150) UNIQUE
);


INSERT INTO Tbl_User (UserName, Password, FullName, Email)
VALUES 
('admin', 'P@ssw0rd123', 'System Administrator', 'admin@example.com'),
('jdoe', 'Welcome123!', 'John Doe', 'jdoe@example.com'),
('asmith', 'SecureMe456$', 'Alice Smith', 'asmith@example.com'),
('bchan', 'MyPass789#', 'Benjamin Chan', 'bchan@example.com'),
('nwin', 'Nanda@2025', 'Nanda Win', 'nwin@example.com');
```