window.onload = function(){
    const produtoCompradoTexto = localStorage.getItem("produtoComprado");
    const produtoComprado = JSON.parse(produtoCompradoTexto)

    document.getElementById("nome-produto").innerText = produtoComprado.nome;
    document.getElementById("preco-produto").innerText = produtoComprado.preço;
}