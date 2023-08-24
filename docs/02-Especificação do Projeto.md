# Especificações do Projeto

<div align="justify"> A definição do problema e dos principais pontos a serem discutidos neste projeto foram baseados em informações obtidas em entrevistas com usuários conduzidas pela equipe de trabalho. Os detalhes levantados ao longo desse processo foram consolidados na forma de personas e histórias de usuários. 
  </div>

## Personas

Para ajudar no entendimento do problema e melhor identificar as necessidades dos usuários, foram levantadas as personas a seguir.

**Quadro 1 – Entrevista com a primeira persona** 

|<img src="img/ricardo.jpg" width="160" height="160">  | **Ricardo** <br> 50 anos|
|:---------------------------------------:|:-------------------------------:|
|**Profissão** | Engenheiro |
|**Restrição** | Diabetes |
|**Motivação** | Busca alimentos com baixo teor de açúcar e carboidratos para manter o controle da glicemia. |
|**Comportamento** | Valoriza informações nutricionais claras nos produtos. Gosta de planejar as refeições com antecedência e busca por lanches saudáveis. |
|**Desafio** | Encontrar alimentos que tenham baixo teor de açúcar e carboidratos, com informações nutricionais claras. |

**Fonte:** Elaborado pelos autores. 


**Quadro 2 – Entrevista com a segunda persona** 

|<img src="img/eduardo.jpg" width="160" height="160">  | **Eduardo** <br> 21 anos|
|:---------------------------------------:|:-------------------------------:|
|**Profissão** | Estudante |
|**Restrição** | Doença celíaca |
|**Motivação** | Busca por alimentos sem glúten para evitar reações alérgicas e problemas de saúde. |
|**Comportamento** | Interessado em receitas caseiras e produtos específicos para celíacos. Gosta de experimentar novos sabores. |
|**Desafio** | Encontrar estabelecimentos que vendam alimentos sem glúten e que estejam cientes das precauções necessárias para evitar contaminação cruzada. |

**Fonte:** Elaborado pelos autores. 


**Quadro 3 – Entrevista com a terceira persona** 

|<img src="img/amanda.jpg" width="160" height="160">  | **Amanda** <br> 30 anos|
|:---------------------------------------:|:-------------------------------:|
|**Profissão** | Educadora física |
|**Restrição** | Intolerância à lactose |
|**Motivação** | Procura produtos sem lactose para manter uma dieta saudável e evitar desconfortos gastrointestinais. |
|**Comportamento** | Gosta de produtos naturais e orgânicos. Frequenta restaurantes e cafeterias que oferecem opções sem lactose. |
|**Desafio** | Encontrar estabelecimentos que ofereçam uma variedade de opções de alimentos sem lactose. |

**Fonte:** Elaborado pelos autores. 

**Quadro 4 – Entrevista com a quarta persona** 

|<img src="img/adriana.jpg" width="160" height="160">  | **Adriana** <br> 45 anos|
|:---------------------------------------:|:-------------------------------:|
|**Profissão** | Empreendedora |
|**Background** | Tem um estabelecimento especializado na venda de produtos alimentares para pessoas com restrições alimentares. |
|**Motivação** | Comprometida em oferecer soluções nutritivas e saborosas para indivíduos com diferentes restrições e necessidades alimentares. |
|**Comportamento** | É ativa nas redes sociais, compartilhando dicas de alimentação saudável e informações sobre os produtos que vende. |
|**Desafio** | Aumentar o número de consumidores de seus produtos. |

**Fonte:** Elaborado pelos autores. 

**Quadro 5 – Entrevista com a quarta persona** 

|<img src="" width="160" height="160">  | **André** <br> 29 anos|
|:---------------------------------------:|:-------------------------------:|
|**Profissão** | Estudante |
|**Background** | André é um homem de 29 anos, que devido a causas congênitas nasceu com deficiência visual. Os seus pais sempre o protegeram ao máximo, mas quando se tornou adulto, André entrou na faculdade , se apaixonou pela tecnologia e viu nela uma aliada para lidar com as limitações impostas pela sociedade.|
|**Motivação** | André é pessoa com deficiência visual, tem a intenção de levar uma vida independente. Deseja facilitar sua rotina diária e explorar novas receitas, adaptadas a sua restrição alimentar. Sua motivação envolve principalmente superar as barreiras de acessibilidade na busca por alimentos para pessoas alérgicas à proteína do leite.|
|**Comportamento** | Utiliza o leitor de tela NVDA para navegar nas páginas Web, não é ativo nas redes sociais, mas utiliza a internet para realizar estudos da faculdade e em busca de informações sobre os alimentos, antes de comprá-los.|
|**Desafio** | Encontrar informações centralizadas e precisas sobre onde encontrar os produtos para sua restrição alimentar. Além de encontrar as informações, um dos maiores desafios é a navegação pelos sites, que não são adaptadas aos leitores de telas.|

**Fonte:** Elaborado pelos autores. 

## Histórias de Usuários

A partir do entendimento das personas identificadas para o projeto, foram estabelecidas as seguintes histórias de usuário.

**Quadro 6 – História de usuários** 

|EU COMO... <br /> `PERSONA`| QUERO/PRECISO ... <br /> `FUNCIONALIDADE` |PARA ... <br /> `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ricardo  | Encontrar alimentos com informações nutricionais claras em seus rótulos         | Ingerir apenas alimentos com baixo teor de açucar e carboidratos               |
|Eduardo      | Encontrar estabelecimentos que vendam produtos específicos para celíacos              | Preparar refeições caseiras sem correr o risco de ingerir glúten |
|Amanda     | Encontrar estabelecimentos que ofereçam produtos e alimentos para intolerantes a lactose             | Evitar desconfortos gastrointestinais |
|Adriana      | De uma plataforma que divulgue onde encontrar produtos para pessoas com restrições alimentares            | Aumentar o número de consumidores em seu estabelecimento  |



**Fonte:** Elaborado pelos autores. 

## Requisitos

O escopo do projeto é definido por meio de requisitos funcionais e não funcionais, a fim de descrever todas as funcionalidades que o usuário poderá encontrar, como também os aspectos gerais que precisam ser apresentados pela ferramenta. 

### Requisitos Funcionais

Na tabela a seguir estão listados os requisitos funcionais do projeto, bem como a prioridade de entrega de cada item. 

**Quadro 7 – Requisitos funcionais** 

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário pesquise produtos  | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais


A tabela a seguir especifica os requisitos não funcionais que devem ser atendidos pelo projeto. 

**Quadro 8 – Requisitos não funcionais** 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móveis | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

## Restrições

As questões que restringem a execução desse projeto e que refletem as obrigações para o desenvolvimento do trabalho, são apresentadas na tabela a seguir.

|**ID**| **Restrição**                                             |
|--|-------------------------------------------------------|
| RE-01 | O projeto deve ser entregue no final do semestre letivo, sendo 04/12/2023 a data limite. |
| RE-02 | O sistema deve estar acessível na web.       |
| RE-03 | A equipe desenvolvedora deve ser composta apenas pelos alunos que fazem parte do projeto.       |
| RE-04 | O projeto deve conter um módulo de back-end e um módulo de front-end. |
| RE-05 | O sistema deve estar em conformidade com a Lei Geral de Proteção de Dados (LGPD). |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
