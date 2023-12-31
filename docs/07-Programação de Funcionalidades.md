# Programação de Funcionalidades

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

A tabela a seguir mostra os artefatos desenvolvidos para cada requisito implementado.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve apresentar na página inicial instruções sobre como navegar na plataforma   | Index.cshtml / HomeController.cs  |
|RF-002| A aplicação deve permitir que o usuário visitante pesquise por produtos, resultando em todos os produtos equivalentes ao que foi pesquisado | FiltrosController.cs / Index.cshtml / Details.cshtml |
|RF-003| A aplicação deve permitir que o usuário visitante pesquise produtos de acordo com tipo específico de restrição alimentar, resultando em todos os produtos próprios para o tipo de restrição pesquisado | FiltrosController.cs / Index.cshtml / Details.cshtml |
|RF-004| A aplicação deve permitir que o usuário visitante busque por produtos desejados e/ou estabelecimentos de acordo com a localidade inserida no filtro de pesquisa | FiltrosController.cs / Index.cshtml / Details.cshtml |
|RF-005| A aplicação deve permitir que o usuário visitante gerencie sua lista de compras com produtos selecionados  | ListaDeComprasController.cs / Index.cshtml / SalvarProduto.cshtml |
|RF-006| A aplicação deve solicitar nome da lista e e-email para compartilhamento sempre que o usuário visitante criar uma lista de compras | ListaDeComprasController.cs / Index.cshtml / SalvarProduto.cshtml |
|RF-007| A aplicação deve permitir que o estabelecimento crie e gerencie os itens da sua conta | Cadastro.cshtml / Usuario.cs / UsuarioController.cs / Perfil.cshtml / Details.cshtml / Delete.cshtml | 
|RF-008| A aplicação deve permitir o estabelecimento especificar a sua localidade | EstabelecimentoController.cs / Estabelecimentos.cs / Create.cshtml / Index.cshtml / Details.cshtml / Edit.cshtml / Delete.cshtml | 
|RF-009| A aplicação deve permitir que o estabelecimento adicione e gerencie seus produtos | ProdutosController.cs / Produto.cs / Create.cshtml / Index.cshtml / Details.cshtml / Edit.cshtml / Delete.cshtml | 
|RF-010| A aplicação deve garantir que o estabelecimento forneça informações detalhadas sobre os produtos | ProdutosController.cs / Produto.cs / Create.cshtml / Details.cshtml / Edit.cshtml  | 
|RF-011| A aplicação deve garantir que o estabelecimento indique claramente qual(is) restrição(ões) alimentar(es) o produto atende | ProdutosController.cs / Produto.cs / Create.cshtml / Details.cshtml / Edit.cshtml |
|RF-012| A aplicação deve permitir que o usuário visitante busque por produtos desejados de acordo com a categoria inserida no filtro de pesquisa | FiltrosController.cs / Index.cshtml / Details.cshtml |
|RF-013| A aplicação deve oferecer a opção de realizar download da lista de compras elaborada | ListaDeComprasController.cs / Index.cshtml / site.js |
|RF-014| A aplicação deve oferecer a opção de enviar a lista de compras elaborada direto para o e-mail do usuário visitante  | Em desenvolvimento |



# Instruções de acesso

Para acessar a aplicação Seleta, sigo os passos descritos abaixo: 
- Link de acesso
  
  Para abrir a aplicação copie e cole o link a seguir na barra de endereço do seu navegador 
  
  https://seleta.azurewebsites.net/
  
- Usuário Teste
  
  Foi criado a seguinte credencial de usuário teste para possibilitar os testes e o acesso ao sistema:
  
  Email: teste@teste.com
  
  Senha: 123456

- Instruções de acesso
  
  1. Abra o navegador de sua preferência;
  2. Insira o link de acesso a aplicação Seleta;
  3. Pressione "Enter" para carregar a página, em seguida você será redirecionado para a home page da aplicação;
  


