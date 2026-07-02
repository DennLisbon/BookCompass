# 🧭 BookCompass

<p align="center">
  <a href="#-versão-em-português">Português</a> • 
  <a href="#-english-version">English</a>
</p>

---

## 🇧🇷 Versão em Português

O **BookCompass** é um projeto web desenvolvido para consolidar e praticar conceitos fundamentais e avançados de **HTML5** e **CSS3**. A aplicação simula uma plataforma de recomendação literária, onde os usuários exploram livros, respondem a um quiz de preferências, visualizam resultados personalizados e gerenciam um painel de perfil com estante virtual.

> 🚀 **Nota de Desenvolvimento:** Este projeto foi criado como um ambiente de laboratório para aplicar os aprendizados de um curso de Web Design Responsivo, servindo para entender a transição entre estruturas iniciais e padrões de mercado (boas práticas de *clean code* e semântica).

### 🛠️ Tecnologias Utilizadas

* **HTML5:** Estruturação semântica avançada (`<main>`, `<article>`, `<figure>`, `<fieldset>`).
* **CSS3:** Estilização moderna utilizando layouts flexíveis e responsivos:
    * **CSS Grid:** Para layouts bidimensionais complexos (grid de livros e painel de perfil).
    * **Flexbox:** Para alinhamentos unidimensionais (barras de navegação e cards da estante).
    * **Media Queries:** Garantia de uma interface 100% responsiva para computadores e dispositivos móveis.

### 📱 Páginas do Projeto

1. **Página Inicial (Home):** Catálogo de livros em destaque com barra de navegação responsiva e menu *dropdown* flutuante.
2. **Quiz de Recomendação:** Formulário moderno com cartões clicáveis personalizados (`input[type="radio"]`) para capturar o perfil de leitura.
3. **Resultado do Quiz:** Exibição dinâmica em formato de card de destaque dividindo a capa do livro e a sinopse.
4. **Perfil do Usuário (Account Settings):** Painel estruturado em colunas para edição de dados pessoais e preferências.
5. **Meus Favoritos (Virtual Bookshelf):** Estante virtual para acompanhar o status de leitura (Lendo, Lido, Quero Ler) e avaliações por estrelas.

### 📐 Conceitos Praticados & Refatoração

Durante a evolução do projeto, foram corrigidos pontos críticos de arquitetura front-end:
* 🧹 Remoção de atributos vazios (`class=""` e `id=""`) por seletores limpos.
* 🏗️ Correção semântica (ajuste de links `<a>` inseridos erroneamente dentro de elementos `<button>`).
* 📝 Adoção da tag `<form>` para encapsular fluxos de dados de formulários.
* 🖼️ Uso correto de elementos de mídia (`<figure>` e `<figcaption>` para imagens com legenda).

### 🔧 Próximos Passos (Backlog de Estudos)

- [ ] Refatorar a arquitetura de arquivos CSS, unificando estilos globais para evitar redundâncias.
- [ ] Adicionar lógica com **JavaScript** para ler os parâmetros da URL do Quiz e injetar as recomendações dinamicamente.
- [ ] Implementar persistência de dados local simulada com `LocalStorage`.

---

## 🇺🇸 English Version

**BookCompass** is a web project developed to consolidate and practice fundamental and advanced concepts of **HTML5** and **CSS3**. The application simulates a book recommendation platform where users can explore books, take a preferences quiz, view personalized results, and manage a profile panel with a virtual bookshelf.

> 🚀 **Development Note:** This project was created as a laboratory environment to put into practice what was learned in a Responsive Web Design course, serving to understand the transition between initial structures and market standards (clean code and semantic best practices).

### 🛠️ Technologies Used

* **HTML5:** Advanced semantic page structuring (`<main>`, `<article>`, `<figure>`, `<fieldset>`).
* **CSS3:** Modern styling using flexible and responsive layouts:
    * **CSS Grid:** For complex two-dimensional layouts (book grid and profile panel).
    * **Flexbox:** For one-dimensional alignments (navigation bars and horizontal bookshelf cards).
    * **Media Queries:** Ensuring a 100% responsive interface, adapting perfectly from desktops to mobile devices.

### 📱 Project Pages

1. **Home Page:** Featured book catalog with a responsive navigation bar and a floating profile dropdown menu.
2. **Recommendation Quiz:** A modern form using customized clickable cards (`input[type="radio"]`) to intuitively capture the user's reading profile.
3. **Quiz Result:** Dynamic display in a featured card format separating the book cover and the synopsis.
4. **User Profile (Account Settings):** Column-structured panel for editing personal data and reading preferences.
5. **My Favorites (Virtual Bookshelf):** Virtual bookshelf to track reading progress (Reading, Completed, Want to Read) and star ratings.

### 📐 Concepts Practiced & Refactoring

During the project's evolution, critical front-end architecture points were explored and corrected:
* 🧹 Replacement of empty attributes (`class=""` and `id=""`) with clean, reusable selectors.
* 🏗️ Structural semantics correction (fixing `<a>` links erroneously placed inside `<button>` elements).
* 📝 Adoption of the `<form>` tag to encapsulate form data flows for user-application relationships.
* 🖼️ Correct use of media elements (`<figure>` and `<figcaption>` for captioned images).

### 🔧 Next Steps (Study Backlog)

- [ ] Refactor the CSS file architecture, unifying global styles to avoid redundancies.
- [ ] Add programming logic with **JavaScript** to read Quiz URL parameters and inject book recommendations dynamically.
- [ ] Implement simulated local data persistence with `LocalStorage`.

