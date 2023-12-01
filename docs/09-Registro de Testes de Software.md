# Registro de Testes de Software


Registro das evidências dos testes feitos na aplicação pela equipe, baseado em um plano de testes pré-definido. Foi utilizada uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos.

(obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso)

| Testes 	| CT-01 – Página inicial	|
|:---:	|:---:	|
|	Vídeo 	| [![CT01](https://img.youtube.com/vi/fRXAynvNqBM/0.jpg)](https://youtu.be/fRXAynvNqBM)|
|  	|  	|

| Testes 	| CT-02 – Buscar Produtos	|
|:---:	|:---:	|
|	Vídeo 	| [![CT02](https://img.youtube.com/vi/QmDmZIZff7k/0.jpg)](https://youtu.be/QmDmZIZff7k)|
|  	|  	|

| Testes 	| CT-03 – Criar Lista de Compras	|
|:---:	|:---:	|
|	Vídeo 	| [![CT03](https://img.youtube.com/vi/ZvuHq91xTjw/0.jpg)](https://youtu.be/ZvuHq91xTjw)|
|  	|  	|

| Testes 	| CT-04 – Fazer Download Lista de Compras	|
|:---:	|:---:	|
|	Vídeo 	| [![CT04](https://img.youtube.com/vi/e7NaAXRcSbs/0.jpg)](https://youtu.be/e7NaAXRcSbs)|
|  	|  	|

| Testes 	| CT-05 – Enviar Lista de Compras por e-mail |
|:---:	|:---:	|
|	Vídeo 	| Funcionalidade de enviar lista por email ainda não foi completamente desenvolvida, dessa forma não houve testes.|
|  	|  	|

| Testes 	| CT-06 – Cadastro do usuário	|
|:---:	|:---:	|
|	Vídeo 	| [![CT06](https://img.youtube.com/vi/Ip64HgVzUE0/0.jpg)](https://youtu.be/Ip64HgVzUE0?si=vOgABg3nBaLbCuU_)|
|  	|  	|

| Testes 	| CT-07 – Cadastro do estabelecimento	|
|:---:	|:---:	|
|	Vídeo 	| [![CT07](https://img.youtube.com/vi/K17GJHHMWbc/0.jpg)](https://youtu.be/K17GJHHMWbc)  |
|  	|  	|

| Testes 	| CT-08 – Cadastro do produto	|
|:---:	|:---:	|
|	Vídeo 	| [![CT07](https://img.youtube.com/vi/2WMw-HRKBG8/0.jpg)](https://youtu.be/2WMw-HRKBG8) |
|  	|  	|


## Relatório de Testes de Software

| 1 	| Página inicial	|
|:---:	|:---:	|
|	Requisito	| RF-001 - A aplicação deve apresentar na página inicial instruções sobre como navegar na plataforma |
| Observação | Na página inicial, a aplicação apresenta algumas instruções de uso para auxiliar os usuários. Na seção de categorias, assim como na barra de pesquisa, existe um ícone de interrogação que, ao passar o mouse em cima, abre-se um card com dicas de uso. Além disso, após a barra de pesquisa, há também instruções sobre como criar uma lista de compras. Dessa forma, o Seleta atende ao requisito apresentar na página inicial instruções de navegação. |
|  	|  	|

| 2	| Buscar Produtos	|
|:---:	|:---:	|
|	Requisito	| RF-002 - A aplicação deve permitir que o usuário visitante pesquise por produtos, resultando em todos os produtos equivalentes ao que foi pesquisado.<br>RF-003 - A aplicação deve permitir que o usuário visitante pesquise produtos de acordo com tipo específico de restrição alimentar, resultando em todos os produtos próprios para o tipo de restrição pesquisado.<br>RF-004 - A aplicação deve permitir que o usuário visitante busque por produtos desejados e/ou estabelecimentos de acordo com a localidade inserida no filtro de pesquisa.<br>RF-012 - A aplicação deve permitir que o usuário visitante busque por produtos desejados de acordo com a categoria inserida no filtro de pesquisa |
| Observação | Na página inicial, a aplicação apresenta na barra de navegação um botão de Pesquisar produtos. Ao clicar nesse botão, o usuário será direcionado para a barra de pesquisa. Na barra de pesquisa, o usuário pode clicar direto em pesquisar, sendo redirecionado para uma página com todos os produtos cadastrados no site. Ele também pode digitar o nome do produto desejado, a restrição alimentar associada ao produto ou o endereço que quer encontrar o produto para que tenha uma busca mais específica. Além disso, existe uma seção de categorias dos alimentos acima da barra de pesquisa, ao clicar na categoria desejada, o usuário será redirecionado para os produtos daquela categoria cadastrados no site. O Seleta atende parcialmente este requisito, pois, ao fazer uma busca por restrição alimentar ou endereço, não retorna os produtos referentes ao que é pesquisado. |
|  	|  	|

| 3  | Criar Lista de Compras	|
|:---:	|:---:	|
|	Requisito	| RF-005 - A aplicação deve permitir que o usuário visitante crie e gerencie listas de compras com produtos selecionados.<br>RF-006 - A aplicação deve solicitar nome da lista e e-email para compartilhamento sempre que o usuário visitante criar uma lista de compras |
| Observação | Na página inicial, a aplicação apresenta o botão de Criar lista de compras na barra de navegação. Ao clicar no botão, o site é redirecionado para a seção de Criar lista de compras, onde o usuário deve colocar seu e-mail, afim de fornecer identificação para a lista. Após ser criada, o usuário irá gerenciar sua lista de compras, podendo tanto clicar em Adicionar produtos à lista, para que ele seja redirecionado para a barra de pesquisa de produtos, assim como ele poderá excluir produtos adicionados. Dessa forma, o Seleta atende ao requisito cadastrar usuário. |
|  	|  	|

| 4 	| Fazer Download Lista de Compras		|
|:---:	|:---:	|
|	Requisito	| RF-013 - A aplicação deve oferecer a opção de realizar download da lista de compras elaborada. |
| Observação | Após a finalização da criação e gerenciamento da lista de compras, o usuário tem a opção de fazer dowload da lista. Ao clicar no botão download no canto superior, um pdf será gerado com os produtos que foram adicionados na lista de compras. O Seleta atende parcialmente este requisito, pois o pdf da lista é gerado, porém, ao abri-lo, ele aparece cortado, sem mostrar todos os produtos da lista.  |
|  	|  	|

| 5 	| Enviar Lista de Compras por e-mail 	|
|:---:	|:---:	|
|	Requisito	| RF-014 - A aplicação deve oferecer a opção de enviar a lista de compras elaborada direto para o e-mail do usuário visitante |
| Observação | Funcionalidade ainda não foi completamente desenvolvida, dessa forma não houve testes. |
|  	|  	|

| 6 	| Cadastrar usuário 	|
|:---:	|:---:	|
|	Requisito	| RF-007 - A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta |
| Observação | Na página inicial, a aplicação apresenta o botão de login na barra de navegação. Ao clicar no botão, o visitante é redirecionado para a página de login, onde irá encontrar o botão de cadastro para criar uma conta na plataforma. Após o preenchimento de informações cadastrais e clicar em "Cadastrar", o usuário será redirecionado de volta para página de login, onde colocará o e-mail e senha escolhida para entrar em seu perfil no site. Ao estar logado no seu perfil, o usuário poderá gerenciar os itens e informações da sua conta. Dessa forma, o Seleta atende ao requisito cadastrar usuário.|
|  	|  	|

| 7 	| Cadastrar estabelecimento	|
|:---:	|:---:	|
|	Requisito	| RF-007 - A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta <br> RF-008 - A aplicação deve permitir o estabelecimento especificar a sua localidade |
| Observação | Após realizar o login na plataforma, o usuário poderá cadastrar seu estabelecimento. Ele irá clicar no botão para realizar cadastro, preencherá as informações pedidas e, no final, clicará em salvar. Com isso, o estabelecimento e suas informações ficarão salvas no perfil do usuário e ele poderá partir para o cadastro dos produtos deste estabelecimento. Dessa forma, o Seleta atende ao requisito cadastrar estabelecimento. |
|  	|  	|

| 8 	| Cadastrar produto	|
|:---:	|:---:	|
|	Requisito	| RF-009 - A aplicação deve permitir que o estabelecimento adicione e gerencie seus produtos |
| Observação | Após realizar o login na plataforma, o usuário terá acesso a relação de todos os estabelecimentos cadastrados e deverá clicar no botão produto. Ele irá clicar em cadastrar novo produto, preencherá as informações pedidas e, no final, clicará em salvar. Com isso, o produto e suas informações ficarão salvas no perfil do estabelecimento, podendo gerenciar esses produtos cadastrados. Dessa forma, o Seleta atende ao requisito cadastrar produto. |
|  	|  	|
<br>

## Pontos de Correção
  
-

