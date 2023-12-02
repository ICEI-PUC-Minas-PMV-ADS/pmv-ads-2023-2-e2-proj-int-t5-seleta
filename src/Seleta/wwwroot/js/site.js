
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


// DOWNLOAD
const btnGenerate = document.querySelector("#generate-pdf");

btnGenerate.addEventListener("click", () => {
    const container = document.querySelector("#container")
    const options = {
        margin: [5, 5, 5, 5],
        filename: "listadecompras.pdf",
        jsPDF: { unit: "mm", format: "a4", orientation: "portrait" },
    };

    html2pdf().set(options).from(container).save();
});

