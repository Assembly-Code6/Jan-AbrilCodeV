# Configurando um Repo Local e Enviando para um Repo Remoto no Visual Studio 2022

Vou explicar como criar um repo local, conectá-lo ao Visual Studio 2022 e depois enviar as alterações para um repo remoto.

## Passo 1: Instalar o Git

Primeiro, precisas do Git. Se ainda não o tens, descarrega em [git-scm.com](https://git-scm.com/).

## Passo 2: Criar um Repo Local

1. Abre o Prompt de Comando ou Terminal.
2. Escolhe onde queres criar o teu repo.
3. Executa `git init`.

## Passo 3: Abrir o Repo no Visual Studio 2022

1. Abre o Visual Studio 2022.
2. Vai a `Ficheiro` > `Abrir` > `Projeto/Solução`.
3. Abre a pasta do teu repo.

## Passo 4: Criar uma Pasta para o Código

Antes de mais, cria uma pasta dentro do teu repo Git para o teu código.

1. No Explorador de Ficheiros, dentro do repo, cria uma nova pasta.
2. Coloca os teus ficheiros de código aí.

## Passo 5: Adicionar Ficheiros ao Repo

1. Adiciona ficheiros ao teu projeto no Visual Studio.
2. Guarda o teu projeto.

## Passo 6: Commitar as Alterações

1. Usa o Team Explorer no Visual Studio.
2. Vai a `Changes`.
3. Escreve uma mensagem de commit.
4. Clica em `Commit All`.

## Passo 7: Adicionar um Repo Remoto

1. Usa o URL do repo remoto que te forneci.
2. No Prompt de Comando ou Terminal, com `git remote add origin [URL]`, adiciona o remoto.

## Passo 8: Enviar Alterações para o Repo Remoto

1. No Team Explorer do Visual Studio, vai a `Sync`.
2. Em `Outgoing Commits`, clica em `Push`.

Pronto, as tuas alterações estão no repo remoto!

---

Se tiveres dúvidas, é só perguntar.
