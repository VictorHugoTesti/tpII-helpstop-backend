<h1>HelpApp</h1>
<p>Um aplicativo de gestão de atendimentos voluntários, desenvolvimento com arquitetura limpa e princípios sólidos de engenharia de software.</p>

<h2>Descrição Geral</h2>
<p>O HellpApp é um sistema para organizar atendimentos voluntários, focado em facilitar o encontro entre quem precisa de ajuda e quem pode ajudar. O projeto foi construído utilizando a plataforma .NET Core, com persistência em SQL Server e implantação na nuvem via Azure Server Apps. Toda a lógica foi projetada com base em princípios de desenvolvimento sustentável e manutenção facilitada, utilizando os conceitos do SOLID.</p>

## Funcionalidades

* Cadastro de usuários (ajudante e solicitante).
* Registro e gerenciamento de atendimentos.
* Agenda personalizda.
* Histórico e relatórios de ações.
* Login seguro com autenticação e autorização.

## Arquitetura do Projeto

* Divisão por camadas (Domain, Application, Infrastructure, Interface).
* Explição das funções de cada camada:
  - Domain: Representa as regras e a lógica de negocio do Projeto. É onde se define os modelos, entidades e operações essenciais, independente de qualquer tecnologia ou framework.
  - Application: Gerencia os casos de uso do Sistema. Ele conecta a lógica do domínio às interações externas, alem de garantir que essas regras de negócios sejam executadas corretamente.
  - Infrastructure: Trata da comunicação com sistemas externos e da persistencia de dados. Ele conecta o aplicativo ao Bando de dados, APIs externas e outros serviços.
  - Interface: É a camada de interação com o usuário. Constroi e exibe a UI e envia dados para as camadas inferiores.
* Diagrama de Fluxo das Camadas:
    - Inteface interage com a Application;
    - Application interage com o Domaion ou Infrastructure;
    - Infrastructure interage com as Operações externas e realiza a persistência do projeto;
*  Padrões utilizados (DDD, Clean Archetecture).

## Princípios SOLID Aplicados
* S - Single Responsibility Principle:
  * Cada classe deve ter uma única responsabilidade.
  * Exemplo: No HelpApp, o User Manager trata apenas da lógica de criação e atualização de usuários.  
* O - Open/Closed Principle:
  * O sistema deve estar aberti para extenção, mas fechado para modificação.
  * Utilizamos interfaces (IuserRepository, IAttendanceService) para permitir que novas implementações sejam adicionadas sem alterar o código existente
* L - Liskov Substitution Principle:
  * As subclasses devem poder substituir as superclasses sem alterar o comportamentto do sistema.
  * Serviços de notificação como EmailNotifier e SmsNotifier herdam de uma interface comum e podem ser alternados sem quebrar funcionalidades
* I - Interfaces Segregation Principle:
  * Interfaces especóficas são melhores que genéricas.
  * O HelpApp usa interfaces distintas para contextos difirentes, como ILoginService, IAgendaManager, evitando que uma classe tenha que implementar métodos que não usa.
* D - Dependency inversion Principle:
  * Os módulos de alto nivél não devem depender dos de baixo nivel, ambos devem depender de abstrações.
  * A camada de aplicação depende de interfacer e não diretamente do SQL Service ou do .NET, tornando o código desacoplado e testável.

## Tecnologias e Ferramentas:

* Linguagem: C# e React
* Banco de Dados: SQL Server
* Ambiente: Firebase
* IDE: Visual Studio Code
* ORM: Entity Framework Core
* Testes: XUnit ou NUnit
* Controle de Versão: Git + Github

## Como Rodar o projeto:

1. Clonar o Repositório:
   * Abra o terminal no VS Code
   * Digite: git clone git@github.com:VictorHugoTesti/tpII-helpstop-backend.git
2. Abrir o Visual Studio Code:
   * Abra o VS Code
   * Vá ao Menu
   * Clique em File > Open Folder e Abra a pasta
3. Configurar a String de Conexão:
  * Escontre o Arquivo appsetting.json
  * Edite as configurações da conexão do banco de dados (endereço do servidor, nome do banco de dados, usuário e senha)
4. Executar Update-Database para aplicar migrations.
  * Instale o Entity Framework CLI (Se ainda não o tiver instalado)
  * No terminal vá até o diretório da API ou do Backend
  * Digite - dotnet ef database update
5. Rodar a aplicação (F5 ou CLI):
  * Abra o terminal
  *Frontend (React):
    * Vá para o diretório Frontend (React)
    * Ditige: npm install
    * Digite: npm start
  * Backend/API:
    * Vá para o diretório (Backend ou da API)
    * Digite: dotnet run
6. Testar rotas via Postman ou Swagger
  * Postman:
    * Configure requisições para suas rotas (GET, POST, PUT, DELETE) conforme nescessário
  * Swagger:
    * Acesse o navegador na URL padrão (https://localhost:<porta>/swagger) para explorar e testar as rotas
   
## Tester Automatizados:

* Camadas que possuem Testes:
* Como executar os testes:
* Ferramentas utilizadas para realizar esses testes:
* Coberturas priorizadas pelos testes:

## Estrutura de Pastas:
![image](https://github.com/user-attachments/assets/932d48a9-660d-45b2-9304-4f0716d00d5c) <br />
![image](https://github.com/user-attachments/assets/f5dff9e1-41b5-41ed-ae05-da0aacc9d17a) <br />
![image](https://github.com/user-attachments/assets/ecb4bfb8-d8cb-4686-ad10-4722e53179e7)

## Membros do Grupo:

* Nome Completo: Victor Hugo Malipense Testi
* Função: back-end, testes, modelagem, documentação, front-end...
* Github: https://github.com/VictorHugoTesti

<h2>Licença</h2>
<p>MIT License</p>
