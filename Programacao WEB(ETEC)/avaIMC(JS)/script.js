function calcularIMC() {
    altura = parseFloat(document.getElementById("txtAltura").value),
    peso = parseFloat(document.getElementById("txtPeso").value),
    sexoF = document.getElementById("sexoF").checked,
    sexoM = document.getElementById("sexoM").checked;
    imc = peso / (Math.pow(altura, 2));
    imc = imc.toFixed(2);
    if(isNaN(peso) || peso == "" || peso == 0){
        alert("Por favor, digite seu peso (1° Caixa)");
        document.getElementById("txtPeso").value="";
        document.getElementById("txtPeso").focus();
    }
    else if(isNaN(altura) || altura=="" || altura == 0){
        alert("Por favor, digite sua altura (2° Caixa)");
        document.getElementById("txtAltura").value="";
        document.getElementById("txtAltura").focus();
    }
else{
 
    switch (true) {
        case (sexoF && imc < 19):
            document.getElementById("txtIMC").value = "Abaixo do peso! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Procure um endocrinologista e nutricionista para montar um programa nutricional para você.";
            break;
        case (sexoF && imc >= 19 && imc <= 24):
            document.getElementById("txtIMC").value = "Peso normal! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Parabéns você está muito gata, continue assim...";
            break;
        case (sexoF && imc >= 24.1 && imc <= 29):
            document.getElementById("txtIMC").value = "Obesidade leve! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Garota, você precisa fazer exercícios físicos e ajustar sua dieta para não engordar mais. Procure um endocrinologista e nutricionista.";
            break;
        case (sexoF && imc >= 29.1 && imc <= 39):
            document.getElementById("txtIMC").value = "Obesidade moderada! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Procure um endocrinologista e nutricionista urgente para verificar sua saúde cardíaca, níveis de colesterol, triglicerídeos e glicose do sangue. Risco de infarto iminente";
            break;
        case (sexoF && imc > 39):
            document.getElementById("txtIMC").value = "Obesidade mórbida! Seu imc "+imc;
            document.getElementById("txtArea").value = "Mulher você ta tentando morrer? Risco alto de infarto ou AVC. Procure um endocrinologista, cardiologista e nutricionista urgente para verificar sua saúde.";
            break;
        case (sexoM && imc < 20):
            document.getElementById("txtIMC").value = "Abaixo do peso! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Procure um endocrinologista e nutricionista para montar um programa nutricional para você.";
            break;
        case (sexoM && imc >= 20 && imc <= 25):
            document.getElementById("txtIMC").value = "Peso normal! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Parabéns você está muito gato, continue assim...";
            break;
        case (sexoM && imc >= 25.1 && imc <= 30):
            document.getElementById("txtIMC").value = "Obesidade leve! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Garoto, você precisa fazer exercícios físicos e ajustar sua dieta para não engordar mais. Procure um endocrinologista e nutricionista.";
            break;
        case (sexoM && imc >= 30.1 && imc <= 40):
            document.getElementById("txtIMC").value = "Obesidade moderada! Seu imc: "+imc;
            document.getElementById("txtArea").value = "Procure um endocrinologista e nutricionista urgente para verificar sua saúde cardíaca, níveis de colesterol, triglicerídeos e glicose do sangue. Risco de infarto iminente";
            break;
        case (sexoM && imc > 40):
            document.getElementById("txtIMC").value = "Obesidade mórbida Seu imc: "+imc;
            document.getElementById("txtArea").value = "Cara, você ta tentando morrer? Risco alto de infarto ou AVC. Procure um endocrinologista, cardiologista e nutricionista urgente para verificar sua saúde.";
            break;
        default:
            document.getElementById("txtIMC").value = "Por favor, selecione o sexo";
    }
}
}
