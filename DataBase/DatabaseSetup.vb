Imports System.Data.SQLite
Imports System.IO

Public Module DatabaseSetup

    Private ReadOnly DbFileName As String =
        Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
          "ExpenseTrackie",
          "expenseTrackie.db")


    Public ReadOnly Property ConnectionString As String
        Get
            ' Make sure this path matches whatever you used in InitializeDatabase:
            Dim folder = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "ExpenseTrackie")
            Dim dbFile = Path.Combine(folder, "expenseTrackie.db")
            Return $"Data Source={dbFile};Version=3;"
        End Get
    End Property



    Public Sub InitializeDatabase()
        Dim folder = Path.GetDirectoryName(DbFileName)
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If

        Dim needsSchema As Boolean = Not File.Exists(DbFileName)
        If needsSchema Then
            SQLiteConnection.CreateFile(DbFileName)
        End If

        Using conn As New SQLiteConnection($"Data Source={DbFileName};Version=3;")
            conn.Open()

            If needsSchema Then
                Dim tbl = "
                CREATE TABLE userInfo(
                  id   INTEGER PRIMARY KEY AUTOINCREMENT,
                  username TEXT UNIQUE NOT NULL,
                  password TEXT NOT NULL,
                  number   TEXT UNIQUE NOT NULL,
                  dateJoined TEXT NOT NULL,
                  enabled  INTEGER NOT NULL DEFAULT 1,
                  profilePicturePath TEXT,
                  dailyLimit REAL NOT NULL DEFAULT 5000
                );"
                ExecuteNonQuery(conn, tbl)

                tbl = "
                CREATE TABLE userAttributes(
                  id INTEGER PRIMARY KEY,
                  dailyLimit REAL NOT NULL DEFAULT 5000,
                  FOREIGN KEY(id) REFERENCES userInfo(id) ON DELETE CASCADE
                );"
                ExecuteNonQuery(conn, tbl)

                tbl = "
                CREATE TABLE verification(
                  id INTEGER PRIMARY KEY,
                  FOREIGN KEY(id) REFERENCES userInfo(id) ON DELETE CASCADE
                );"
                ExecuteNonQuery(conn, tbl)

                tbl = "
                CREATE TABLE category(
                  catId INTEGER PRIMARY KEY AUTOINCREMENT,
                  catName TEXT NOT NULL,
                  description TEXT NOT NULL,
                  color TEXT NOT NULL,
                  userId INTEGER NOT NULL,
                  enabled INTEGER NOT NULL DEFAULT 1,
                  FOREIGN KEY(userId) REFERENCES userInfo(id) ON DELETE CASCADE
                );"
                ExecuteNonQuery(conn, tbl)

                tbl = "
                CREATE TABLE expense(
                  eId INTEGER PRIMARY KEY AUTOINCREMENT,
                  userId INTEGER NOT NULL,
                  catId  INTEGER NOT NULL,
                  amount REAL    NOT NULL,
                  remarks TEXT   NOT NULL,
                  dateAdded TEXT NOT NULL,
                  timeAdded TEXT NOT NULL,
                  enabled INTEGER NOT NULL DEFAULT 1,
                  FOREIGN KEY(userId) REFERENCES userInfo(id),
                  FOREIGN KEY(catId)  REFERENCES category(catId) ON DELETE CASCADE
                );"
                ExecuteNonQuery(conn, tbl)

                ' Indexes
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_category_userId ON category(userId);")
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_category_enabled ON category(enabled);")
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_expense_userId ON expense(userId);")
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_expense_dateAdded ON expense(dateAdded);")
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_expense_user_date ON expense(userId,dateAdded);")
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_expense_catId ON expense(catId);")
                ExecuteNonQuery(conn, "CREATE INDEX IF NOT EXISTS idx_expense_enabled ON expense(enabled);")
            End If

            conn.Close()
        End Using
    End Sub


    Private Sub ExecuteNonQuery(conn As SQLiteConnection, sql As String)
        Using cmd = New SQLiteCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module
