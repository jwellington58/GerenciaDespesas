# GerenciaDespesas
A simple dotnet project for expense management.
## Estrutura do Projeto
  - Foi usado um padrão com Models e Controllers, para haver uma maior abstração de informações.
  - Foi adotado um padrão de Repository, para abstrair os acesso aos dados. 
  - Foi adotado um padrão de Services, para prover os serviços necessários para aplicação e abstrair as regras de negócio.
## Tecnologias usadas
  - .net core 3.1 (https://dotnet.microsoft.com/download/dotnet-core/3.1)
  - sql server 17.3 (https://sqlserverbuilds.blogspot.com/2018/01/sql-server-management-studio-ssms.html)
  
## Bibliotecas usadas
  - Microsoft.EntityFrameworkCore.Design v=3.1.7
  - Microsoft.EntityFrameworkCore.SqlServer v=3.1.7
  - Microsoft.EntityFrameworkCore.SqlServer.Design v=1.1.6
  - Microsoft.EntityFrameworkCore.Tools v=3.1.7
  - Swashbuckle.AspNetCore (Swagger) v=5.5.0
  
## Documentação da API
  Para documentar a API foi usado o swagger.
  Para acessar a documentação, basta executar o projeto e acessar (host:porta/swagger/index.html)
## Configurando e Rodando o projeto (Windows)
  - Instalar o .net core 3.1 e o sql server 17.3.
  - Instalar Visual Studio 2019 OU Visual Studio Code.
  - Ir no arquivo **appsetting.json** na raiz do projeto e configurar a string de conexão de acordo com a configuração do SQL SERVER.
  - Abrir powershell ou cmd navegar até a raiz do projeto e rodar o comando: **dotnet ef database update**. Esse comando aplicará as migrations presentes no projeto e o banco de dados     será criado.
  - Depois de tudo configurado, caso esteja usando Visual Studio, apenas rodar o projeto normalmente. Caso esteja usando Visual Studio Code, ou algo do tipo, navegar até a raiz do     projeto e rodar o comando **dotnet run**.
