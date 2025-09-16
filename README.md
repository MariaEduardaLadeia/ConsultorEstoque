**Simulador de Estoque com Windows Forms - Projeto de Estudo**

Este repositório apresenta um simulador básico de estoque desenvolvido em C# com Windows Forms. O projeto tem como principal objetivo permitir o gerenciamento simples de produtos, oferecendo funcionalidades essenciais como adição, remoção e consulta de itens no estoque.

O projeto foi concebido como um trabalho da disciplina de Plataforma de Desenvolvimento de Sistema, com o objetivo principal de consolidar o aprendizado e a prática no uso das funcionalidades e componentes do Windows Forms, incluindo a criação de DLLs para separação de responsabilidades e interação com o usuário através de uma interface gráfica intuitiva.

## Objetivo do Projeto

Os principais objetivos acadêmicos deste projeto são:

-   **Consolidar conhecimentos** em C# e os fundamentos do desenvolvimento de aplicações gráficas com Windows Forms.
-   Entender e aplicar o conceito de **separação de responsabilidades** utilizando bibliotecas de classes (DLLs).
-   **Praticar o uso de componentes** de UI como `TextBox`, `Button` e `DataGridView`, incluindo a técnica de Data Binding para exibição de dados.
-   Implementar **validação de entrada de dados** e fornecer feedback claro ao usuário através de caixas de mensagem (`MessageBox`).
-   Demonstrar a construção de uma aplicação funcional a partir de requisitos básicos.

## Funcionalidades

O simulador de estoque oferece as seguintes capacidades:

-   **Adicionar Produtos:** Permite incluir novos produtos ao estoque. Se um ID é fornecido e já corresponde a um produto existente, sua quantidade é atualizada. Se o ID for inválido ou omitido, um novo ID único é gerado automaticamente.
-   **Remover Produtos:** Exclui produtos do estoque utilizando seu ID único. A operação é precedida por uma confirmação e verifica a existência do produto antes de prosseguir.
-   **Consultar Estoque:** Exibe todos os produtos atualmente armazenados em uma tabela interativa (`DataGridView`), mostrando ID, nome e quantidade.
-   **Feedback Interativo:** Utiliza `MessageBox` para informar sobre o sucesso das operações (e.g., "Produto adicionado ao estoque!"), erros de validação ou quando um item não é encontrado ("Esse produto não existe no estoque.").
-   **Seleção na Tabela:** Ao clicar em um produto listado no `DataGridView`, seus dados (ID, Nome, Quantidade) são automaticamente carregados nos campos de entrada, facilitando a remoção ou atualização.

## Tecnologias Utilizadas

-   **C#**: Linguagem de programação principal.
-   **.NET Framework**: Plataforma de desenvolvimento.
-   **Windows Forms (WinForms)**: Framework para construção da interface gráfica.
-   **Biblioteca de Classes (DLL)**: Para modularização da lógica de negócios.

## Estrutura do Projeto

A solução é organizada em dois projetos para promover a separação de responsabilidades e uma arquitetura mais limpa:

-   **`InventoryLibSimples` (Biblioteca de Classes - DLL):**
    -   Contém as classes de modelo (`Produto`) e a lógica de gerenciamento do estoque (`InventoryManager`).
    -   Responsável por todas as operações de manipulação dos dados de produtos, mantendo o controle do estoque.

-   **`InventoryAppSimples` (Aplicação Windows Forms - Executável):**
    -   Contém o formulário principal (`Form1.cs`) que representa a interface do usuário.
    -   Interage com a `InventoryLibSimples` para solicitar operações de estoque e exibir os resultados ao usuário.


## 🤝 Colaboradores

Este projeto foi desenvolvido em colaboração com:

-   **[Maria Eduarda Ladeia](https://github.com/MariaEduardaLadeia)**
-   **[Enzo Brumate](https://github.com/EnzoBrumate)** 
