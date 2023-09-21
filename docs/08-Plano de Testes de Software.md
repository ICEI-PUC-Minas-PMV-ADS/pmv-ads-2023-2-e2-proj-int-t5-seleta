# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
- Site publicado na Internet.
- Navegador da Internet - Chrome, Firefox, Edge, Opera e Safari.
- Conectividade de Internet para acesso às plataformas (APISs).
  
Os testes funcionais a serem realizados na aplicação são descritos a seguir.

| **Caso de Teste** 	| **CT-01 – Página inicial** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar na página inicial instruções sobre como navegar na plataforma |
| Objetivo do Teste 	| Verificar existe na página inicial dicas que facilitem a experiência do usuário no site |
| Passos 	| - Acessar a aplicação <br> - Buscar na página inicial um botão de ajuda <br> - Clicar em cima do botão e verificar se abrem instruções de uso |
|Critério de Êxito | - O usuário visitante consegue visualizar as dicas na página inicial |

 
| **Caso de Teste** 	| **CT-02 – Buscar Produtos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir que o usuário visitante pesquise por produtos, resultando em todos os produtos equivalentes ao que foi pesquisado <br> RF-003 - A aplicação deve permitir que o usuário visitante pesquise produtos de acordo com tipo específico de restrição alimentar, resultando em todos os produtos próprios para o tipo de restrição pesquisado <br> RF-004 - A aplicação deve permitir que o usuário visitante busque por produtos desejados e/ou estabelecimentos de acordo com a localidade inserida no filtro de pesquisa <br> RF-012 - A aplicação deve permitir que o usuário visitante busque por produtos desejados de acordo com a categoria inserida no filtro de pesquisa|
| Objetivo do Teste 	| Verificar se o usuário visitante consegue encontrar os produtos que deseja. |
| Passos 	| - Acessar a aplicação <br> - Digitar o nome do produto na barra de pesquisa <br> - Inserir filtros de pesquisa se desejar <br> - Clicar em Pesquisar <br> - Visualizar o resultado da busca |
|Critério de Êxito | - O usuário visitante consegue buscar e visualizar o produto desejado. |



| Caso de Teste 	| **CT-03 – Criar Lista de Produtos**	|
|:---:	|:---:	|
|Requisito Associado  | RF-005	- A aplicação deve permitir que o usuário visitante crie e gerencie listas de compras com produtos selecionados. <br> RF-006 - A aplicação deve solicitar nome da lista e e-email para compartilhamento sempre que o usuário visitante criar uma lista de compras |
| Objetivo do Teste 	| Verificar se o usuário visitante consegue criar lista de produtos. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Buscar produtos disponíveis <br> - Selecionar os produtos que quer em uma lista <br> - Informar o email <br> - Criar uma lista |
|Critério de Êxito | - O usuário visitante consegue criar sua lista de produtos. |



| Caso de Teste 	| **CT-04 – Fazer Download Lista de Produtos**	|
|:---:	|:---:	|
| Requisito Associado | RF-013	- A aplicação deve oferecer a opção de realizar download da lista de compras elaborada. |
| Objetivo do Teste 	| Verificar se o usuário visitante consegue fazer download da sua lista de produtos. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Buscar produtos disponíveis <br> - Selecionar os produtos que quer em uma lista <br> - Informar o email <br> - Criar uma lista <br> - Finalizar lista <br> - Pedir para fazer o download |
|Critério de Êxito | - O usuário visitante consegue fazer download da sua lista de produtos. |



| Caso de Teste 	| **CT-05 – Enviar Lista de Produtos por e-mail**	|
|:---:	|:---:	|
|Requisito Associado | RF-014	- A aplicação deve oferecer a opção de enviar a lista de compras elaborada direto para o e-mail do usuário visitante |
| Objetivo do Teste 	| Verificar se o usuário visitante consegue enviar sua lista de produtos para o email informado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Buscar produtos disponíveis <br> - Selecionar os produtos que quer em uma lista <br> - Informar o email <br> - Criar uma lista <br> - Finalizar lista <br> - Pedir para enviar para email informado |
|Critério de Êxito | - O usuário visitante consegue receber sua lista de produtos no email informado. |

| Caso de Teste 	| **CT-06 – Cadastro e gerenciamento do estabelecimento**	|
|:---:	|:---:	|
|Requisito Associado | RF-007	- A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta <br> RF-008 - A aplicação deve permitir o estabelecimento especificar a sua localidade |
| Objetivo do Teste 	| Verificar se o usuário consegue criar e editar a página de seu estabelecimento na plataforma. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Fazer login no site <br> - Selecionar a opção de cadastrar estabelecimento <br> - Inserir as informações pedidas sobre o estabelecimento e clicar no botão de Cadastrar <br> - Verificar se o estabelecimento foi criado e salvo no perfil do usuário <br> - Clicar no botão de editar estabelecimento e verificar se abrirá novamente a página de cadastro para que o usuário possa alterar informações se necessário <br> - Por fim, clicar em Cadastrar novamente |
|Critério de Êxito | - O usuário consegue cadastrar e gerenciar seu estabelecimento na plataforma. |
 

