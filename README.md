# ContosoUniversity

See the [live demo](http://contosouniversitydk.azurewebsites.net/Home/UnderConstruction?site=Departments)

Microsoft tutorial series for the Contoso University sample application. 

https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

This is a great tutorial on ASP.NET MVC using EF 6 Code First that is very clear to follow and has lots of explanations!!!

Notes:

1. When [deploying to Azure](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/migrations-and-deployment-with-the-entity-framework-in-an-asp-net-mvc-application#deploy-to-azure) my web app initially didn't work because i didn't click on the Configure link prior to clicking the Publish button. On the setting tab I had to check `Execute Code First Migrations` and setup the connection string for `SchoolContext`

1. Had to modify .gitignore so that .pubxml files are ignored (since mine contained an unencrypted connection string)
