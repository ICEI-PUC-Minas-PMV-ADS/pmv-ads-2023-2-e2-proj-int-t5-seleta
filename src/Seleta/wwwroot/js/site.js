
// RESPONSIVIDADE
function menuShow() {
    let menuMobile = document.querySelector('.mobile-menu');
    if (menuMobile.classList.contains('open')) {
        menuMobile.classList.remove('open');
    } else {
        menuMobile.classList.add('open');
    }
}

// BOTÃO DE DICA

function showConteudoCategoria() {
    let conteudo = document.querySelector(".conteudo-categoria");
    conteudo.style.display = "inline-grid";
}

function hideConteudoCategoria() {
    let conteudo = document.querySelector(".conteudo-categoria");
    conteudo.style.display = "none";
}

function showConteudoPesquisa() {
    let conteudo = document.querySelector(".conteudo-pesquisa");
    conteudo.style.display = "inline-grid";
}

function hideConteudoPesquisa() {
    let conteudo = document.querySelector(".conteudo-pesquisa");
    conteudo.style.display = "none";
}
