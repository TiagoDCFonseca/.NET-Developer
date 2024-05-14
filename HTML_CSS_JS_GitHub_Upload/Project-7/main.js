// Baseado na nota que está no HTML (exemplo: 14.2)
// Indique se o resultado é:
// (0-4) Muito Mau
// (5-9) Negativo
// (10-13) Positivo
// (14-17) Bom
// (18-20) Muito Bom

console.log("O program iniciou");


let nota1 = parseFloat(document.querySelector(".nota-1").innerHTML);
let nota2 = parseFloat(document.querySelector(".nota-2").innerHTML);
let nota3 = parseFloat(document.querySelector(".nota-3").innerHTML);

let media = (nota1+nota2+nota3) / 3;

function handleClick(){
console.log("A nota 1 é --> " + nota1)
console.log("A nota 2 é --> " + nota2)
console.log("A nota 3 é --> " + nota3)

console.log("A sua média final é --> " + media.toFixed(2));
if(media >= 0 && media < 4){
    console.log("Muito Mau")
}
else if(media >= 4 && media < 10)
    console.log("Negativo")

else if(media >= 10 && media < 13){
    console.log("Positivo")
}
else if(media >= 13 && media < 17){
    console.log("Bom")
}

else if(media >= 17 && media <=20){
    console.log("Muito Bom")
}

}