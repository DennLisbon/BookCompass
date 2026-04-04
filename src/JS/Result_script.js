function redirecionarParaIndex() {
    window.location.href = '../index.html';
}

document.addEventListener('DOMContentLoaded', () => {
    const botao = document.getElementById('btnVoltar');
    if (botao) {
        botao.addEventListener('click', redirecionarParaIndex);
    }
}); // tem aldo muito errado e esse chatbot de fica se intrometendo no códig0 sem analisar e criando mais bagunça do que precisa