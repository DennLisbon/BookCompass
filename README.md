# 🧭 BookCompass

O **BookCompass** é um projeto web desenvolvido com o objetivo de consolidar e praticar conceitos fundamentais e avançados de **HTML5** e **CSS3**. A aplicação simula uma plataforma de recomendação literária, onde os usuários podem explorar livros, responder a um quiz de preferências, visualizar resultados personalizados e gerenciar um painel de perfil e estante virtual.

> 🚀 **Nota de Desenvolvimento:** Este projeto foi criado como um ambiente de laboratório para aplicar na prática os aprendizados de um curso de Web Design Responsivo, servindo para entender a transição entre estruturas iniciais e padrões de mercado (boas práticas de clean code e semântica).

---

## 🛠️ Tecnologias Utilizadas

* **HTML5:** Estruturação semântica de páginas (`<main>`, `<article>`, `<figure>`, `<fieldset>`).
* **CSS3:** Estilização moderna utilizando layouts flexíveis e responsivos:
    * **CSS Grid:** Para layouts bidimensionais complexos (como o grid 2x2 de livros e o painel de perfil).
    * **Flexbox:** Para alinhamentos unidimensionais e componentes de interface (como as barras de navegação e os cards horizontais da estante).
    * **Media Queries:** Para garantir que toda a interface seja 100% responsiva, adaptando-se perfeitamente de computadores para dispositivos móveis.

---

## 📱 Páginas do Projeto

O ecossistema do BookCompass é composto por 5 telas principais integradas:

1.  **Página Inicial (Home):** Catálogo de livros em destaque (Grid 2x2) com barra de navegação responsiva e menu de perfil flutuante (*dropdown*).
2.  **Quiz de Recomendação:** Um formulário moderno que utiliza cartões clicáveis personalizados (`input[type="radio"]`) para capturar o perfil de leitura do usuário de forma intuitiva.
3.  **Resultado do Quiz:** Exibição dinâmica em formato de card de destaque dividindo a capa do livro e a sinopse.
4.  **Perfil do Usuário (Account Settings):** Um painel estruturado em colunas para edição de dados pessoais, foto de perfil e preferências de leitura.
5.  **Meus Favoritos (Virtual Bookshelf):** Uma estante virtual para o usuário acompanhar o status de suas leituras (Lendo, Lido, Quero Ler) e suas avaliações por estrelas.

---

## 📐 Conceitos Praticados

Durante a evolução do projeto, foram explorados e corrigidos pontos críticos de arquitetura front-end, tais como:
* Substituição de atributos vazios (`class=""` e `id=""`) por seletores limpos e reaproveitáveis.
* Correção de semântica estrutural (ajuste de links `<a>` inseridos erroneamente dentro de elementos `<button>`).
* Adoção da tag `<form>` para encapsular fluxos de dados de formulários de relacionamento usuário-aplicação.
* Uso correto de elementos de mídia (`<figure>` e `<figcaption>` para imagens com legenda).

---

## 🔧 Próximos Passos (Backlog de Estudos)

* [ ] Refatorar a arquitetura de arquivos CSS, unificando estilos globais para evitar redundâncias.
* [ ] Adicionar lógica de programação com **JavaScript** para ler os parâmetros da URL do Quiz (`URLSearchParams`) e injetar as recomendações de livros dinamicamente na página de resultados.
* [ ] Implementar persistência de dados local simulada com `LocalStorage`.
