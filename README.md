# Configurando um Repo Local e Enviando para um Repo Remoto no Visual Studio 2022

Vou explicar como criar um repo local, conectá-lo ao Visual Studio 2022 e depois enviar as alterações para um repo remoto.

## Passo 1: Instalar o Git

Primeiro, precisas do Git. Se ainda não o tens, descarrega em [git-scm.com](https://git-scm.com/).

## Passo 2: Criar um Repo Local

1. Abre o Prompt de Comando ou Terminal.
2. Escolhe onde queres criar o teu repo.
3. Executa `git init`.

## Passo 3: Criar uma Pasta para o Código

Antes de mais, cria uma pasta dentro do teu repositório(ficheiro) local para o teu código.

1. Adiciona à pasta do repo este [ficheiro]([https://link-url-here.org](https://github.com/Assembly-Code6/Jan-AbrilCodeV/blob/main/.gitignore))
1.5 (É mais fácil criares um novo ficheiro .gitignore e colar lá este contudo e salvares)
2. No Explorador de Ficheiros, dentro do repo(pasta que contem a pasta escondida .git), cria uma nova pasta chamada code.
3. Coloca os teus ficheiros de código (projeto) aí.

## Passo 4: Criar o teu projeto no Visual Studio 2022

1. Abre o Visual Studio 2022.
2. Cria um projeto Console app na pasta code que acabaste de criar
3. Abrindo a aba git clica em commit or stash
4. Agora usa a janela da direita para adicionar todas os ficheiros ao commit (git add --all/clica no + á direita de changes)
5. Agora escreve uma mensagem de commit e clica em commit all

## Passo 5: Adicionar um remote

1. Agora na aba do git clica em manage remotes > add remote
2. O fetch é o link do teu repositorio exemplo: https://github.com/Assembly-Code6/Jan-AbrilCodeV.git !tem de acabar em .git!
3. O nome é o que quiseres, mas mete main
4. Salva e agora deves ter a opcao de dar push!!

## Passo 6: Commitar as Alterações

1. Dá push Cx
2. Deve estar tudo a funcionar. Agora segue para o teu repositorio pessoal nesta organização e vê a seção issue para o resto do trabalho


Se tiveres dúvidas, é só perguntar.
