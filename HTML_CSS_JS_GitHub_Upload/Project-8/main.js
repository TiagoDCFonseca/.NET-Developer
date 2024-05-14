
const produtos = [
    { id: 1, nome: "Notebook Gamer", preço: 4500, categoria: "Eletrónicos", disponível: true },
    { id: 2, nome: "Smartphone Pro", preço: 3500, categoria: "Eletrónicos", disponível: true },
    { id: 3, nome: "Cafeteira Expresso", preço: 890, categoria: "Eletrodomésticos", disponível: false },
    { id: 4, nome: "Blender Moderno", preço: 350, categoria: "Eletrodomésticos", disponível: true },
    { id: 5, nome: "Smart TV 50'", preço: 2800, categoria: "Eletrónicos", disponível: true },
    { id: 6, nome: "Fones de Ouvido Wireless", preço: 299, categoria: "Acessórios", disponível: false },
    { id: 7, nome: "Teclado Mecânico", preço: 520, categoria: "Acessórios", disponível: true },
    { id: 8, nome: "Rato Gamer", preço: 150, categoria: "Acessórios", disponível: true },
    { id: 9, nome: "Ténis de Corrida", preço: 480, categoria: "Esporte", disponível: true },
    { id: 10, nome: "Camisa de Poliéster", preço: 99, categoria: "Vestuário", disponível: true },
    { id: 11, nome: "Mochila de Trilha", preço: 320, categoria: "Aventura", disponível: false },
    { id: 12, nome: "Livro de Javascript", preço: 120, categoria: "Livros", disponível: true }
];

// Imprimir todos os produtos no HTML
function imprimirLista() {
const listaProdutos = document.getElementById("produtos")
let produtosHTML = "";
for(let i = 0; i < produtos.length; i++){
    produtosHTML += `<li>ID_Cliente: ${produtos[i].id} Nome: ${produtos[i].nome} Preço: ${produtos[i].preço}€</li>`
}
listaProdutos.innerHTML = produtosHTML;
}

// correr o imprimirLista() logo quando a página carrega (sem ser no onclick)
//imprimirLista()