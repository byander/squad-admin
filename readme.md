# Descrição

Aplicatvo criado em C# para facilitar a administração do jogo, como envio de regras, aviso aos usuários e votação de mapas.

## Download

O download da aplicação (arquivo compactatdo) pode ser feito [aqui](https://github.com/byander/squad-admin/releases/download/v1.0/SquadAdmin.zip), ou ir em releases.

## Execução

O aplicativo só pode ser executado no sistema operacional Windows. Não precisa instalar, basta fazer o download, descompactar e executar o aruqivo `SquadAdmin.exe`.  

* Importante: O aplicativo carrega os dados de uma planilha no formato Excel (.xlsx), localizado do diretório 'Data'. Esta planilha não pode ser movida e/ou renomeada, e os nomes das planilhas do arquivo não podem ser alteradas e/ou excluídas.  Porém, pode ser adicionado novas linhas, quando necessário, edição e/ou adição de uma nova regra, mapa ou layer.

## Atualização do dados da planilha

Quando for necessário atualizar os dados da planilha, basta editar conforme desejado. Para carregar as novas atualizações, será necessário fechar e abrir a aplicação.  
Exemplo de atualizações:

* Regras: atualizar a planilha "regra";
* Novos Layers: atualizar a planilha "layers". Importante, os nomes das colunas não devem ser alteradas;
* Avisos: Se quiser enviar alguma mensagem personalizada no broadcast com certa recorrência, basta adicionar na planilha "avisos".

## Breve descrição das telas

Todas as telas tem um campo chamado "Comando", o qual será mostrado ao usuário para confirmação do mesmo.  
Com exceção da tela "Rcon", o texto apresentado é copiado para a Área de Transferência do Windows, ou seja, basta abrir o console no jogo e colar o conteúdo.

### Regras

---

Enviar informações de regras aos usuários através do Broadcast e/ou um aviso para um usuário específico através do ID Steam.  
É possível filtrar por uma palavra chave para encontrar rapidamente uma regra. Basta clicar sobre uma regra específica.

![Regras](https://github.com/byander/squad-admin/blob/master/Figuras/regras.JPG?raw=true)

### Mapas

---

Enviar aos jogadores se querem sugestão de mapa, enviar as mapas propostos, bem como o modo de jogo. Basta selecionar (máximo 3) os mapas e clicar em "Iniciar votemap."
Para enviar o mapa vencedor, basta selecionar o mapa (apenas 1) e clicar em "Iniciar votemap."
Se marcar apenas um mapa e um modo de jogo e posteriormente clicar no botão "Sugerir modo de jogo", será anunciado o mapa e modo vencedor.

![Mapas](https://github.com/byander/squad-admin/blob/master/Figuras/mapas.JPG?raw=true)

### Map Layers

---

Enviar comando para configurar o próximo layer, bastando clicar em qualquer local da linha desejada. Além disso, é possível filtrar o mapa para buscar mais rapidamente.

![Layers](https://github.com/byander/squad-admin/blob/master/Figuras/layers.JPG?raw=true)

### Comandos

---

Lista os comandos mais comuns para os administradores e a descrição do mesmo.

![Comandos](https://github.com/byander/squad-admin/blob/master/Figuras/comandos.jpg?raw=true)

### Rcon

---

Nesta tela é para facilitar o kick/ban em um jogador através do ID Steam. Para utilizar, é necessário seguir os passos:

1. No Discord do servidor, acessar no canal apropriado;
2. Executar o comando para ***listplayers*** para listar o jogadores;
3. Copiar todo o conteúdo apresentado;
4. Na aplicação, clicar no botão "Colar do Rcon".

Será apresentado todos os jogadores do conteúdo copiado. É possível filtrar por parte do nome para buscar mais rapidamente. Basta clicar sob o nome e selecionar as opções "kick" ou "Banir". Indiferente da opção, é recomendado selecionar o motivo.

![Rcon](https://github.com/byander/squad-admin/blob/master/Figuras/rcon.jpg?raw=true)

### Avisos

---

Enviar mensagens ao Broadcast para todos os usuários.

![Avisos](https://github.com/byander/squad-admin/blob/master/Figuras/avisos.jpg?raw=true)
