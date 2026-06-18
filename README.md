# 🧭 BookCompass

## 🇧🇷 Versão em Português

O **BookCompass** é um projeto web desenvolvido com o objetivo de consolidar e praticar conceitos fundamentais e avançados de **HTML5** e **CSS3**. A aplicação simula uma plataforma de recomendação literária, onde os usuários podem explorar livros, responder a um quiz de preferências, visualizar resultados personalizados e gerenciar um painel de perfil e estante virtual.

> 🚀 **Nota de Desenvolvimento:** Este projeto foi criado como um ambiente de laboratório para aplicar na prática os aprendizados de um curso de Web Design Responsivo, servindo para entender a transição entre estruturas iniciais e padrões de mercado (boas práticas de clean code e semântica).

---

### 🛠️ Tecnologias Utilizadas

* **HTML5:** Estruturação semântica de páginas (`<main>`, `<article>`, `<figure>`, `<fieldset>`).
* **CSS3:** Estilização moderna utilizando layouts flexíveis e responsivos:
    * **CSS Grid:** Para layouts bidimensionais complexos (como o grid de livros e o painel de perfil).
    * **Flexbox:** Para alinhamentos unidimensionais e componentes de interface (como as barras de navegação e os cards horizontais da estante).
    * **Media Queries:** Para garantir que toda a interface seja 100% responsiva, adaptando-se perfeitamente de computadores para dispositivos móveis.

---

### 📱 Páginas do Projeto

1. **Página Inicial (Home):** Catálogo de livros em destaque com barra de navegação responsiva e menu de perfil flutuante (*dropdown*).
2. **Quiz de Recomendação:** Formulário moderno que utiliza cartões clicáveis personalizados (`input[type="radio"]`) para capturar o perfil de leitura do usuário de forma intuitiva.
3. **Resultado do Quiz:** Exibição dinâmica em formato de card de destaque dividindo a capa do livro e a sinopse.
4. **Perfil do Usuário (Account Settings):** Painel estruturado em colunas para edição de dados pessoais, foto de perfil e preferências de leitura.
5. **Meus Favoritos (Virtual Bookshelf):** Estante virtual para o usuário acompanhar o status de suas leituras (Lendo, Lido, Quero Ler) e suas avaliações por estrelas.

---

### 📐 Conceitos Praticados

Durante a evolução do projeto, foram explorados e corrigidos pontos críticos de arquitetura front-end, tais como:
* Substituição de atributos vazios (`class=""` e `id=""`) por seletores limpos e reaproveitáveis.
* Correção de semântica estrutural (ajuste de links `<a>` inseridos erroneamente dentro de elementos `<button>`).
* Adoção da tag `<form>` para encapsular fluxos de dados de formulários de relacionamento usuário-aplicação.
* Uso correto de elementos de mídia (`<figure>` e `<figcaption>` para imagens com legenda).

---

### 🔧 Próximos Passos (Backlog de Estudos)

* [ ] Refatorar a arquitetura de arquivos CSS, unificando estilos globais para evitar redundâncias.
* [ ] Adicionar lógica de programação com **JavaScript** para ler os parâmetros da URL do Quiz e injetar as recomendações de livros dinamicamente.
* [ ] Implementar persistência de dados local simulada com `LocalStorage`.

---
---

## 🇺🇸 English Version

**BookCompass** is a web project developed to consolidate and practice fundamental and advanced concepts of **HTML5** and **CSS3**. The application simulates a book recommendation platform where users can explore books, take a preferences quiz, view personalized results, and manage a profile panel and virtual bookshelf.

> 🚀 **Development Note:** This project was created as a laboratory environment to put into practice what was learned in a Responsive Web Design course, serving to understand the transition between initial structures and market standards (clean code and semantic best practices).

---

### 🛠️ Technologies Used

* **HTML5:** Semantic page structuring (`<main>`, `<article>`, `<figure>`, `<fieldset>`).
* **CSS3:** Modern styling using flexible and responsive layouts:
    * **CSS Grid:** For complex two-dimensional layouts (like the book grid and profile panel).
    * **Flexbox:** For one-dimensional alignments and interface components (like navigation bars and horizontal bookshelf cards).
    * **Media Queries:** To ensure the entire interface is 100% responsive, adapting perfectly from desktops to mobile devices.

---

### 📱 Project Pages

1. **Home Page:** Featured book catalog with a responsive navigation bar and a floating profile dropdown menu.
2. **Recommendation Quiz:** A modern form that uses customized clickable cards (`input[type="radio"]`) to intuitively capture the user's reading profile.
3. **Quiz Result:** Dynamic display in a featured card format separating the book cover and the synopsis.
4. **User Profile (Account Settings):** Column-structured panel for editing personal data, profile picture, and reading preferences.
5. **My Favorites (Virtual Bookshelf):** Virtual bookshelf to track reading progress (Reading, Completed, Want to Read) and star ratings.

---

### 📐 Concepts Practiced

During the project's evolution, critical front-end architecture points were explored and corrected, such as:
* Replacement of empty attributes (`class=""` and `id=""`) with clean, reusable selectors.
* Correction of structural semantics (fixing `<a>` links erroneously placed inside `<button>` elements).
* Adoption of the `<form>` tag to encapsulate form data flows for user-application relationships.
* Correct use of media elements (`<figure>` and `<figcaption>` for captioned images).

---

### 🔧 Next Steps (Study Backlog)

* [ ] Refactor the CSS file architecture, unifying global styles to avoid redundancies.
* [ ] Add programming logic with **JavaScript** to read Quiz URL parameters and inject book recommendations dynamically.
* [ ] Implement simulated local data persistence with `LocalStorage`.
