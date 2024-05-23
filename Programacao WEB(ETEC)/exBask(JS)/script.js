function calc() {
    // Obter os valores de entrada
    var a = parseFloat(document.getElementById("nmA").value);
    var b = parseFloat(document.getElementById("nmB").value);
    var c = parseFloat(document.getElementById("nmC").value);

    // Calcular o discriminante
    var delta = b * b - 4 * a * c;

    // Verificar se o discriminante é negativo
    if (delta < 0) {
        document.getElementById("raizPosi").value = "Não há raízes reais.";
        document.getElementById("raizNega").value = "Não há raízes reais.";
    } else {
        // Calcular as raízes
        var x1 = (-b + Math.sqrt(delta)) / (2 * a);
        var x2 = (-b - Math.sqrt(delta)) / (2 * a);

        // Exibir as raízes
        document.getElementById("raizPosi").value =  x1.toFixed(2);
        document.getElementById("raizNega").value =  x2.toFixed(2);
    }
}
