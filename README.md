<h1 align="center">Gestão de festas infantis</h1>

> Trabalho avaliativo da Academia do Programador <br>
> Feito por Paola Oliveira, Isaque Oliveira e Gustavo Rafaeli <br>
> Finalizado no dia 14/06/2023 <br>

## Descrição
Aplicação feita para Rafaela que possui um negócio de festas infantis e precisava ter um maior gerenciamento dos aluguéis efetuados a clientes. Rafaela passou algumas especificações de execusão, dentre elas:
a possiblidade de oferecer o desconto de 10% para clientes antigos e a necessidade do pagamento de 40% do valor ao fechar o negócio.

## Funcionalidades
A aplicação permite cadastrar determinadas informações para cada tela, além de fornecer um CRUD para a administração dos dados.

### Tela Cliente

- Nome, telefone e o tipo de cliente sendo "Antigo" ou "Novo"
- "Nome" e "telefone" são campos obrigatórios 
- Se não marcar o "tipo" de cliente, a aplicação terá como padrão o "Novo"

<img alt="imagem-cliente" width="85%" src="https://media.discordapp.net/attachments/1096481399994851330/1118944957982584852/image.png?width=983&height=632" />
<br>

### Tela Item

- Adiciona o nome e o preço do item 
- Ambos são campos obrigatórios

<img alt="imagem-item" width="85%" src="https://media.discordapp.net/attachments/1096481399994851330/1118945485810577518/image.png?width=977&height=632" />
<br>

### Tela Tema

- Possibilita inserir nome do tema e os seus devidos itens 
- Ambos campos obrigatórios

<img alt="imagem-tema" width="85%" src="https://media.discordapp.net/attachments/1096481399994851330/1118945784591810731/image.png?width=982&height=632" />
<br>

### Tela Aluguel

- É dependente das telas Cliente e Tema para adicionar esses dados de maneira mais específica
- Adiciona Data, hora inicial e hora final para medidas de tempo
- Permite adicionar Cep, nome e número da rua para se ter a localização
- Faz o calculo do valor total a ser pago, o desconto e a porcentagem já paga
- Caso a porcentagem paga seja de 100%, o campo "Fechamento" irá registrar a data do pagamento final

<img alt="imagem-aluguel" width="85%" src="https://media.discordapp.net/attachments/1096481399994851330/1118945273406816336/image.png?width=980&height=632" />
<br>

## Tecnologias e ferramentas
- C#
- Visual Studio
- <a alt="flaticon-link" target="_blank" href="https://www.flaticon.com/">flaticon</a>
