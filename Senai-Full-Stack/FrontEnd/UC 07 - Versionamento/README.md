# Conteúdo de suporte de comandos UC07 - Versionamento
-------------------------------------------------------------------------------

## Instalação

- **_Git download_** - Pode ser achado no dominio https://git-scm.com/ ou pelo link direto https://git-scm.com/download/win.

- **_Adjusting the name of the inicial branch in new repositories_** - Configura um novo padrão para as árvores principais mudando o nome delas de **master** para **main**.

Selecione a opção "Override the default branch name for new repositories" e digite **main** na caixa de texto.

- **_resto das configurações de instação_** - todas as outras configurações vem por padrão e não é necessário trocá-las.

- **_-configurações da pasta do windows_** - Abra uma pasta qualquer, no meu superior da pasta, clique em **Exibir**, logo depois marque as opções **Extensões de nomes de arquivos** e **itens ocultos**.
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
## Configuração de usuário

- **_git config --global user.name "fulano de tal"_** - configura o nome do usuário de maneira a afetar todos os projetos.

- **_git config --global user.email "fulado_de_tal@email.com"_** - configura o email do usuário de maneira a afetar todos os projetos.
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Processo de criação de repositório

- **_git init_** - criar um novo repositório na pasta selecionada.

- **_git clone_** - usado para copiar um respositório existente.
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Processo de Commit 

- **_git add "Seu_Arquivo.txt"_** - usado para adicionar arquivos especificos a area de staging

- **_git add ._** - usado para adicionar todos os arquivos a area de staging

- **_git status_** - Exibe a lista de arquivos alterados e que ainda não foram adicionados a area de staging.

- **_git commit -m "seu comentário"_** - comando que permite fazer um commit com comentário
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Acessando o Commit

- **_git log_** - permite vizualizar os commits feitos.

- **_git show Numero_Do_Commit_** - permite visualizar informações detalhadas sobre o commit.

- **_git checkout Numero_Do_Commit_** - permite voltar a um commit anterior
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Configurando o repositório remoto

- **_git remote add origin link_do_repositório_** - adiciona o endereço do repositório remoto possibilitando salvar as alterações na nuvem

- **_git remote set-url origin link_do_repositório_** - sobreescreve o endereço do repositório remoto possibilitando alterar o endereço atual.

- **_git remote -v_** - permite visualizar o link do repositório remoto atual
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Salvando Alterações no repositório remoto

- **_git push -u origin main_** - Envia alterações para o repositorio remoto.

- **_git pull_** - atualiza o repositório recall puxando todas as informações do remoto.
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Repositório compartilhado

- **_git checkout -b Nome_da_Branch_** - Cria uma no branch baseada na branch atual que tem as mesmas informações.

- **_git branch_** - mostra todas as branchs locais

- **_git branch -a_** - mostra todas as branchs remotas e locais

- **_git push origin Nome_da_Branch_** - Salva alterações na branch especifica
- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

## Comandos gerais

- **_git merge_** - Usado para mesclar branchs.

- **_git tag_** - Usado para colocar tag ou versões no git.

