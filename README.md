# Central-de-Tarefas
Central para cadastro de tarefas associadas a um contato.


![alt text](https://i.ibb.co/0Z10RHB/anotacao-Central.jpg)
![alt text](https://i.ibb.co/ZgRqBJ8/demo-Listagem.jpg)


# Ao iniciar

A conexão ao seu banco de dados é exigida. Vá na pasta principal e verifique o arquivo.

( DBtarefas/contexts/DBContext.cs )

Em "optionsbuilder.UseSqlServer()" altere as configurações necessárias para fazer o deploy em seu database.

![alt text](https://i.ibb.co/6mydrb2/configuracao-Banco.jpg)


# Deploy do banco de dados

Vá na pasta geral da aplicação (Onde ficam os arquivos e pastas gerais da estrutura)

( /DBTarefas MVC/DBTarefas/ )

entre num terminal cmd ou pelo cmd do próprio Visual Studio.

Digite: 

            dotnet ef database update

A migração começará a ser feita para o seu banco de dados.

