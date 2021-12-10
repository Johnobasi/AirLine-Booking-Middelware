# Lead Way Project

## Prerequisites
Before you begin, ensure you have installed the following
* Install the .NET Core `SDK 5`. Download link can be found [here](https://docs.microsoft.com/en-us/dotnet/core/install/sdk?pivots=os-windows) - Choose an operating system of your choice to download SDK.
* Install the `ASP.NET Core Runtime 5`. Download link can be found [here](https://dotnet.microsoft.com/download/dotnet-core) - Choose runtime for your OS

## Install development tools. 
Visual Studio 2019 community edition or Visaul Code is the preferred IDE
* Windows: Download `Viual Studio 2019` community or `Visual Studio Code` [here](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2019)
* Mac or Linux: Download `Visual Studio Code` [here](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=button+cta&utm_content=download+vs2019) You can also use rider
* The installation guide for Visual Studio can be followed [here](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)
* The setting up of Visual Studio Code can be followed [here](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019)

## Install SQL Server
 Download and install the SQL Server 2019 Developer free specialized edition [here](https://www.microsoft.com/en-us/sql-server/sql-server-downloads);


## Setup project

1. Clone the repository
	`git clone https://github.com/Johnobasi/GreenAfrica-API`
2. Checkout branch to `master` and change directory `GreenAfrica-API`
	`git checkout master`
	`cd GreenAfrica-API`
3. Run `dotnet restore` to install package dependencies
4. Run `dotnet build` to build the application

## Setup Environment Variables
Microsoft `Secret Manager` is used to store the apps environment variables on development. The environment variables are stored in a separate location from the project tree.
1. Open the application with your preferred IDE

### Using Visual Studio 2019 Community edition (Windows & macOS)

1. Right click on the `GreenAfrica-API` project
2. Select `Manager User Secrets` from the context-menu
3. A `secret.json` will be open in the text editor of the IDE, then fill the following with your `env` variables

	```{
           "ConnectionStrings": {
                "DataDBCon": "Server=(localdb)\\MSSQLLocalDB; Database=Test_DB; Trusted_Connection=True;"
            },

            "JwtSettings": {
                "Secret": "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                "TokenLifetime": "01:00:00"
            },

            "Logging": {
                "LogLevel": {
                "Default": "Information",
                "Microsoft": "Warning",
                "Microsoft.Hosting.Lifetime": "Information"
                }
            },
            "AllowedHosts": "*"
        }
4. Note: Provide your SQL Server connection string for `DataDBCon` in the above `secret.json` file

### Using Visual Studio Code

1. Change directory into the `GreenAfrica-API` project directory
2. On the bash terminal run `dotnet user-secrets init`
3. To set a `Secret` for example to set an `env` variable for the database connection string, simply do the following
    `dotnet user-secrets set "ConnectionStrings:DataDBCon" "Server=localhost;Database=your-database-name;Trusted_Connection=True;MultipleActiveResultSets=true"`
4. You can now go ahead to set `env` variables for each secrets needed for the project.

Note: You should note that the `secret.json` file in generated and can be located in the following location
    * Windows: `%APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json`
    * Linux/macOS: `~/.microsoft/usersecrets/<user_secrets_id>/secrets.json`


You can go to this link [here](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=linux) for more information on how to setup a `Secret Manager` on your environment

## Database Migration
### Entity Framework Core tools
1.  `dotnet ef` must be installed as a global or local tool. Install `dotnet ef` as a global tool with the following command:
    `dotnet tool install --global dotnet-ef`
2. In the terminal change directory into the `GreenAfrica.DataAccess` project directory
3. Apply the migration to the database to create the schema.
    `dotnet ef database update`

Visit this link [here](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli) for more information on using `ef core tool`

## Running the application locally on your machine
Make sure all the above instructions are done completely before running the application
1. If you are using `Visual Studio 2019 community`
    * Right click on the `API` project and select `Set as Startup Project`
    * Then press the `F5` to run the application or click on the `IIS Express` run button on the standard toolbar to run the application

2. If you are using `Visual Studio Code`
    * In your terminal, change directory into src/API directory where the solution file is located and then run the following: 
        `dotnet restore`
        `dotnet run`
    * The above commands will restore missing application packages, build and then run the application
3. Either ways will make the project web APIs accessible on Swagger through this `http://localhost:5000/swagger/index.html`
