# BlissRecruitmentAPI
This project was done for recruitment purposes. This web API BlissRecruitmentAPI implements the specification present in the url https://blissrecruitmentapi.docs.apiary.io/.

This web API will run over a url like http://[host][port]/api as a base address.

## Getting Started

### Requirements
* Visual Studio 2017
* SQL Server
* .Net Framework 4.7.1

### Step-by-step for setup, compile and run the application
1. Clone repository
2. Open Visual Studio with Administrator privileges
3. Open solution. It will open 2 projects
4. Restore NuGet Packages building the solution or on the "Solution Explorer" -> right-click on "References" -> "Manage NuGet Packages..." -> "Restore"
5. In the project BlissRecruitmentAPI, go to web.config file and configure the correct connection string for your SQL Server instance in the connection string named QuestionChoicesContext
6. In the same web.config file, configure the SMTP settings in appSettings
6. Open Package Manager Console "View" -> "Other Windows" -> Package Manager Console
7. Execute command Update-Database
8. F5 or Ctrl+F5 to Start with our without Debugger

### When publishing the application...
1. Choose your desired publish method according to the desired host you will use
2. In the project BlissRecruitmentAPI, go to web.config file and configure the correct connection string for your SQL Server instance in the connection string named QuestionChoicesContext
3. Also in the web.config file, configure the SMTP settings in appSettings

#### NOTE: Because it is a demo web API, when configuring an smtp server like gmail or hotmail, you will need additional steps to allow this application to send email for security purposes. This steps depends on your stmp mail distributor

### Swagger
The BlissRecruitmentAPI is integrated with swagger, to access swagger, use the base API url followed by /swagger (example: http://localhost/api/swagger)

### BlissRecruitmentAPICaller
This API is also delivered with a windows forms project named BlissRecruitmentAPICaller that consumes the endpoints of the API, to run this project, build the project and run it or, after building the project, run the generated file BlissRecruitmentAPICaller.exe
