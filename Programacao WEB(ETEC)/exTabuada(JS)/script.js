function Calculo(){
    var result, contagem;
    var Numero = parseFloat(document.getElementById("Numero").value);

    if (!isNaN(Numero) && Numero != "" && Numero != 0){
        var mensagem = "";
        for( contagem = 1; i <= 10; contagem++){
            result = Numero * contagem;
            mensagem += `${contagem} x ${Numero} = ${result}\n`;
        }
        alert(mensagem);
    }
    else{
        alert("Digite um número")
    }
}
