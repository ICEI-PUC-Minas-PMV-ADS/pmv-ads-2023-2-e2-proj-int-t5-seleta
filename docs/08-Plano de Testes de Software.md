# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
- Site publicado na Internet;
- Navegador da Internet - Chrome, Firefox, Edge, Opera e Safari;
- Conectividade de Internet para acesso às plataformas (APISs).
  
Os testes funcionais a serem realizados na aplicação são descritos a seguir.

| **Caso de Teste** 	| **CT-01 – Página inicial** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar na página inicial instruções sobre como navegar na plataforma |
| Objetivo do Teste 	| Verificar existe na página inicial dicas que facilitem a experiência do usuário no site |
| Passos 	| - Acessar a aplicação <br> - Buscar na página inicial dicas ou botões de ajuda <br> - Clicar em cima do botão e verificar se abrem instruções de uso |
|Critério de Êxito | - O usuário visitante consegue visualizar as dicas na página inicial |

 
| **Caso de Teste** 	| **CT-02 – Buscar Produtos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve permitir que o usuário visitante pesquise por produtos, resultando em todos os produtos equivalentes ao que foi pesquisado <br> RF-003 - A aplicação deve permitir que o usuário visitante pesquise produtos de acordo com tipo específico de restrição alimentar, resultando em todos os produtos próprios para o tipo de restrição pesquisado <br> RF-004 - A aplicação deve permitir que o usuário visitante busque por produtos desejados e/ou estabelecimentos de acordo com a localidade inserida no filtro de pesquisa <br> RF-012 - A aplicação deve permitir que o usuário visitante busque por produtos desejados de acordo com a categoria inserida no filtro de pesquisa|
| Objetivo do Teste 	| Verificar se o usuário visitante consegue encontrar os produtos que deseja. |
| Passos 	| - Acessar a aplicação <br> - Digitar o nome do produto na barra de pesquisa <br> - Inserir filtros de pesquisa se desejar <br> - Clicar em Pesquisar <br> - Visualizar o resultado da busca |
|Critério de Êxito | - O usuário visitante consegue buscar e visualizar o produto desejado. |



| Caso de Teste 	| **CT-03 – Criar Lista de Compras**	|
|:---:	|:---:	|
|Requisito Associado  | RF-005	- A aplicação deve permitir que o usuário visitante crie e gerencie listas de compras com produtos selecionados. <br> RF-006 - A aplicação deve solicitar nome da lista e e-email para compartilhamento sempre que o usuário visitante criar uma lista de compras |
| Objetivo do Teste 	| Verificar se o usuário visitante consegue criar lista de compras. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Buscar produtos disponíveis <br> - Selecionar os produtos que quer em uma lista <br> - Informar o email <br> - Criar uma lista |
|Critério de Êxito | - O usuário visitante consegue criar sua lista de compras. |



| Caso de Teste 	| **CT-04 – Fazer Download Lista de Compras**	|
|:---:	|:---:	|
| Requisito Associado | RF-013	- A aplicação deve oferecer a opção de realizar download da lista de compras elaborada. |
| Objetivo do Teste 	| Verificar se o usuário visitante consegue fazer download da sua lista de compras. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Buscar produtos disponíveis <br> - Selecionar os produtos que quer em uma lista <br> - Informar o email <br> - Criar uma lista <br> - Finalizar lista <br> - Pedir para fazer o download |
|Critério de Êxito | - O usuário visitante consegue fazer download da sua lista de compras. |



| Caso de Teste 	| **CT-05 – Enviar Lista de Compras por e-mail**	|
|:---:	|:---:	|
|Requisito Associado | RF-014	- A aplicação deve oferecer a opção de enviar a lista de compras elaborada direto para o e-mail do usuário visitante |
| Objetivo do Teste 	| Verificar se o usuário visitante consegue enviar sua lista de compras para o email informado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Buscar produtos disponíveis <br> - Selecionar os produtos que quer em uma lista <br> - Informar o email <br> - Criar uma lista <br> - Finalizar lista <br> - Pedir para enviar para email informado |
|Critério de Êxito | - O usuário visitante consegue receber sua lista de compras no email informado. |

| Caso de Teste 	| **CT-06 – Cadastro do usuário**	|
|:---:	|:---:	|
|Requisito Associado | RF-007	- A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta  |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na plataforma. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Clicar no botão "Cadastre-se" no final da página <br> - Inserir as informações pedidas e clicar em "Cadastrar" <br> - Verificar se o e-mail e senha cadastrados dão acesso a uma conta na plataforma |
|Critério de Êxito | - O usuário consegue se cadastrar na plataforma. |

| Caso de Teste 	| **CT-07 – Cadastro do estabelecimento**	|
|:---:	|:---:	|
|Requisito Associado | RF-007	- A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta <br> RF-008 - A aplicação deve permitir o estabelecimento especificar a sua localidade |
| Objetivo do Teste 	| Verificar se o usuário consegue criar a página de seu estabelecimento na plataforma. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Fazer login no site <br> - Selecionar a opção de cadastrar estabelecimento <br> - Inserir as informações pedidas sobre o estabelecimento e clicar no botão de Cadastrar <br> - Verificar se o estabelecimento foi criado e salvo no perfil do usuário |
|Critério de Êxito | - O usuário consegue cadastrar seu estabelecimento na plataforma. |

| Caso de Teste 	| **CT-08 – Cadastro de produtos**	|
|:---:	|:---:	|
|Requisito Associado | RF-009	- A aplicação deve permitir que o estabelecimento adicione seus produtos <br> RF-010 - A aplicação deve garantir que o estabelecimento forneça informações detalhadas sobre os produtos <br> RF-011 - A aplicação deve garantir que o estabelecimento indique claramente qual(is) restrição(ões) alimentar(es) o produto atende |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar produtos na página do seu estabelecimento. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Fazer login no site <br> - Selecionar a opção de Gerenciar estabelecimentos <br> - Clicar no estabelecimento que deseja abrir <br> - Clicar em Cadastrar produtos <br> - Inserir as informações pedidas sobre o produto e clicar no botão de Cadastrar <br> - Visualizar o produto cadastrado no perfil do estabelecimento. |
|Critério de Êxito | - O usuário consegue cadastrar os produtos no perfil do seu estabelecimento com todas as informações essenciais para o consumidor. |
