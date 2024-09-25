once you run all the things in that file.



just do the usual adding of database in your project, DONT FORGET TO COPY CONNECTION STRING IT GIVES YOU

goto app.config in your project, and then 

<connectionStrings>
    <add name="expenseTrackie"
    connectionString="Data Source=NOTHINGS-LAPTOP\SQLEXPRESS;Initial Catalog=expenseTrackie;Integrated Security=True;"
    providerName="System.Data.SqlClient" />
</connectionStrings>


change the value of connectionString to the one you copied aghi
