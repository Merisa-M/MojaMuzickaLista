# MojaMuzickaLista

First of all, you need to do the few things listed below before you can properly start the application.

- After you cloned the project, open the folder "MojaMuzickaLista", open the MojaMuzickaLista.sln, and in Package Manager Console type "update-database" to seed data into a database. After that, start the project with (F5, ctrl+F5). That project is API and on the startup, it will be Swagger with all implemented endpoints ready for testing and use.
- After you started the Web API project open the folder "angMuzickaLista", and if you are using Visual Studio Code, use Git Bash Here and type "code ." to open the Visual Studio code with all project's files so you can test the Angular app.
- Open Terminal and use the command below for installing workspace npm dependencies:
```
npm install
```

After the installation of all required npm dependency packages, in the same Terminal type command below:

```
ng serve
```
It will provide URL: http://localhost:4200/ 
Copy that URL and paste it into a new tab in Browser.

Happy code review :)

