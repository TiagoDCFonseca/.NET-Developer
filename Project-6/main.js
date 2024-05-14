console.log("O Site inicio com sucesso");

// Variavel que faz referencia ao id conteudo1
const conteudo1 = document.querySelector("#conteudo1");
const conteudo2 = document.querySelector("#conteudo2");
const conteudo3 = document.querySelector("#conteudo3");

function alterarTab1(){
    //Do conteudo1 seleciono o (titulo) e mudo o texto. Faço o mesmo para o (p)
   conteudo1.querySelector('h1').innerText = "Mudado!!";
   conteudo1.querySelector('p').innerText = "Mudado!!";
}

function alterarTab2(){
    conteudo2.querySelector('h1').innerText = "Mudado!!";
    conteudo2.querySelector('p').innerText = "Mudado!!";
    //Mudar a cor da letra de ambos seguindo a mesma lógiga
    conteudo2.querySelector('h1').style.color = "yellow";
    conteudo2.querySelector('p').style.color = "yellow";
    //Mudar a cor de fundo para vermelho
    conteudo2.querySelector('h1').style.backgroundColor = "red";
    conteudo2.querySelector('p').style.backgroundColor = "red";
}

function alterarTab3() {
    conteudo3.querySelector('h1').innerText = "";
    conteudo3.querySelector('p').innerText = "";
}