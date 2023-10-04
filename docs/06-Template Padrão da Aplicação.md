# Template Padrão da Aplicação

O layout padrão a ser utilizado pela aplicação tem correspondência ao projeto de Interface elaborado anteriormente.

## Paleta de Cores
 <div align="center">
<img src="img/paleta-cores.png"><br>
<b>Figura 22</b> - Paleta de Cores

## Tipografia
<div align="justify"> A fonte escolhida para a construção da interface foi a Inter, para garantir a legibilidade com um estilo moderno e uma sensação de harmonia. </div><br>

## Telas
Todas as telas apresentam um layout responsivo, tendo seu conteúdo ajustado para qualquer tamanho de tela. 
O template criado é composto pelos seguintes layouts:
- Home Page
- Tela Perfil do produto
- Tela Lista de compras
- Tela do Cadastro do usuário
- Tela da Login do usuário
- Tela Perfil do usuário
- Tela Cadastro do estabelecimento
- Tela Gerenciar estabelecimentos
- Tela Cadastro do produto
- Tela Gerenciar produtos
</div>
### Home Page
<div align="justify"> A Home Page apresenta o propósito e os valores da plataforma por meio de um carrossel. Além disso, é a tela onde o usuário visitante pode fazer sua busca pelos produtos desejados, aplicando filtros. Nesta página, também se encontra o botão para criar uma lista de compras, tendo dicas de como realizar essa ação. A Home Page também permite que usuários (donos de estabelicimentos comerciais) façam seu cadastro ou façam login para acessar sua conta. </div><br>

<div align="center">
<img src="img/Home page.png" width="50%"><br>
<b>Figura 23</b>
</div><br>
<div align="justify">
<br>RF-001 - A aplicação deve apresentar na página inicial instruções sobre como navegar na plataforma 
<br>RF-002 - A aplicação deve permitir que o usuário visitante pesquise por produtos, resultando em todos os produtos equivalentes ao que foi pesquisado
<br>RF-003 - A aplicação deve permitir que o usuário visitante pesquise produtos de acordo com tipo específico de restrição alimentar, resultando em todos os produtos próprios para o tipo de restrição pesquisado
<br>RF-004 - A aplicação deve permitir que o usuário visitante busque por produtos desejados e/ou estabelecimentos de acordo com a localidade inserida no filtro de pesquisa
<br>RF-006 - A aplicação deve solicitar nome da lista e e-email para compartilhamento sempre que o usuário visitante criar uma lista de compras 
<br>RF-012 - A aplicação deve permitir que o usuário visitante busque por produtos desejados de acordo com a categoria inserida no filtro de pesquisa
</div><br>

### Tela - Perfil do produto

<div align="justify"> Ao pesquisar os produtos desejados na página inicial, o usuário pode clicar em cima do botão "Ver detalhes" e o site será redirecionado para a página do Perfil do produto, onde se encontrarão a descrição e informações adicionais sobre o produto.
  </div><br>

   <div align="center">
<img src="img/Perfil do Produto.png" width="50%"><br>
<b>Figura 24</b> - Tela de Perfil do produto
  </div>

### Tela - Lista de compras

<div align="justify"> A Lista de compras é a tela para onde o usuário é redirecionado após o usuário inserir seu e-mail e selecionar os produtos que deseja adicionar na lista. Nesta página, o usuário pode gerenciar os produtos e escolher se prefere fazer download da lista ou enviar para um e-mail.
  </div><br>

   <div align="center">
<img src="img/Criar Lista.png" width="50%"><br>
<b>Figura 25</b> 
  </div><br>
<div align="justify">
RF-013 - A aplicação deve oferecer a opção de realizar download da lista de compras elaborada
RF-014 - A aplicação deve oferecer a opção de enviar a lista de compras elaborada direto para o e-mail do usuário visitante
RF-005 - A aplicação deve permitir que o usuário visitante gerencie sua lista de compras com produtos selecionados
</div><br>

  ### Tela - Cadastro do usuário 

<div align="justify"> Caso o usuário queira anunciar seus produtos no site, ele deverá clicar em um dos botões para ser redirecionado a página de cadastro. A tela de cadastro do usuário é utilizada para criar o acesso ao sistema. Caso já tenha cadastro, o usuário poderá ser direcionado para a tela de login também por essa tela. 
  </div><br>

<div align="center">
<img src="img/cadastro.png" width="50%"><br>
<b>Figura 26</b> 
</div><br>
<div align="justify">
RF-011 - A aplicação deve garantir que o estabelecimento indique claramente qual(is) restrição(ões) alimentar(es) o produto atende / RF-010 - A aplicação deve garantir que o estabelecimento forneça informações detalhadas sobre os produtos
</div><br>

### Tela - Login do usuário

<div align="justify"> Para os usuários que já possuem uma conta, o acesso é feito pela tela de login. Para entrar, bastar clicar no botão "Login", o site será redirecionado para a tela e o usuário deve informar o email e senha escolhida no momento do cadastro. Caso seja o primeiro acesso do usuário, ele poderá ser direcionado para a tela de cadastro também por essa tela. 
  </div><br>

<div align="center">
<img src="img/login.png" width="50%"><br>
<b>Figura 27</b> - Tela de Login/Entrar
  </div>

  ### Tela - Perfil do usuário

<div align="justify"> Tela de Perfil do usuário é o local onde o usuário poderá adicionar e gerenciar os seus estabelecimentos.
  </div><br>

<div align="center">
<img src="img/Perfil do Usuário.png" width="50%"><br>
<b>Figura 28</b>
</div><br>
<div align="justify">
RF-007 - A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta
</div><br>

### Tela - Cadastro de estabelecimento

<div align="justify"> Esta tela é onde o usuário irá colocar todas as informações pedidas para realizar o cadastro do seu estabelecimento no site.
  </div><br>

<div align="center">
<img src="img/Cadastrar estabelecimento.png" width="50%"><br>
<b>Figura 29</b> 
</div><br>
<div align="justify">
RF-008 - A aplicação deve permitir ao estabelecimento especificar a sua localidade
</div><br>

### Tela - Gerenciar estabelecimentos

<div align="justify"> Esta tela é onde o usuário poderá escolher um de seus estabelecimentos cadastrados para abrir seu perfil, editar suas as informações ou até mesmo excluir o estabelecimento da plataforma.
  </div><br>

<div align="center">
<img src="img/Gerenciar estabelecimentos.png" width="50%"><br>
<b>Figura 30</b> - Tela de Gerenciamento de estabelecimentos
  </div>

### Tela - Cadastro de produto

<div align="justify"> Ao clicar em cadastrar produto, o usuário será direcionado para essa tela, onde ele irá inserir todas as informações pedidas sobre o novo produto e, no final da página, clicará em Cadastrar para subir o produto para a plataforma.
  </div><br>

<div align="center">
<img src="img/Adicionar Produto.png" width="50%"><br>
<b>Figura 31</b> - Tela de Cadastro de produtos
  </div>

### Tela - Gereciar produtos

<div align="justify"> Ao clicar em um estabelecimento, o site será redirecionado para essa tela, onde aparecerão todos os produtos cadastrados neste estabelecimento. O usuário pode escolher cadastrar um novo produto, editar ou excluir um produto já cadastrado.
  </div><br>

<div align="center">
<img src="img/Gerenciamento de produtos.png" width="50%"><br>
<b>Figura 32</b> 
</div><br>
<div align="justify">
RF-009 - A aplicação deve permitir que o estabelecimento adicione e gerencie seus produtos
</div><br>
