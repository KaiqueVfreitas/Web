function Adicao()
{
    var number1 = parseFloat(document.getElementById("nm1").value);
    var number2 = parseFloat(document.getElementById("nm2").value);
    var resultadoSoma = number1 + number2;
    var parImpar = resultadoSoma % 2;

    document.getElementById("txtResultado").value = resultadoSoma.toFixed(3);
    if(parImpar == 0.000)
    {
        parseFloat(document.getElementById("txtParImpar").value = "Par")
    }
    else
    {
        parseFloat(document.getElementById("txtParImpar").value = "Impar")
    }
}
function Sub()
{
    var number1 = parseFloat(document.getElementById("nm1").value);
    var number2 = parseFloat(document.getElementById("nm2").value);
    var resultadoSub = number1 - number2;
    var parImpar = resultadoSub % 2;
    
    document.getElementById("txtResultado").value = resultadoSub.toFixed(3);
    if(parImpar == 0.000)
    {
        parseFloat(document.getElementById("txtParImpar").value = "Par")
    }
    else
    {
        parseFloat(document.getElementById("txtParImpar").value = "Impar")
    }
}
function Divisao()
{
    var number1 = parseFloat(document.getElementById("nm1").value);
    var number2 = parseFloat(document.getElementById("nm2").value);
    var resultadoDiv = number1 / number2;
    var parImpar = resultadoDiv;


    if (number2 != 0){
    document.getElementById("txtResultado").value= resultadoDiv.toFixed(3);
    if(parImpar == 0.000)
    {
        parseFloat(document.getElementById("txtParImpar").value = "Par")
    }
        else
    {
        parseFloat(document.getElementById("txtParImpar").value = "Impar")
        }
    }
    else{
        document.getElementById("txtResultado").value = "Ñ é possível dividir"
    }
}
function Multi()
{
    var number1 = parseFloat(document.getElementById("nm1").value);
    var number2 = parseFloat(document.getElementById("nm2").value);
    var resultadoMulti = number1 * number2;
    var parImpar = resultadoMulti;

    document.getElementById("txtResultado").value= resultadoMulti.toFixed(3);
    if(parImpar == 0.000)
    {
        parseFloat(document.getElementById("txtParImpar").value = "Par")
    }
    else
    {
        parseFloat(document.getElementById("txtParImpar").value = "Impar")
    }
}

