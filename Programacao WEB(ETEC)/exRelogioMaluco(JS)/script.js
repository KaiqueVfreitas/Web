var semana = ["Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"];

var mesNome = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"];

var repeticao;

function inicia() {
    repeticao = setInterval(relogio, 500);
}

function parar() {
    clearInterval(repeticao);
}

function relogio() {
    var data = new Date();

    var dia = data.getDate();
    if (dia <10){
        dia = "0" + dia;
    }
    var mes = data.getMonth() + 1; 
    if (mes < 10){
       mes = "0" + mes;
    }
    var ano = data.getFullYear();
    var seg = data.getSeconds();
    if (seg <10){
        seg = "0" + seg;
    }
    var min = data.getMinutes();
    if (min <10){
        min = "0" + min;
    }
    var hora = data.getHours();
    if (hora <10){
        hora = "0" + hora;
    }
    

    document.getElementById("diaSemana").value = semana[data.getDay()]; 
    document.getElementById("nomeMes").value = mesNome[mes-1] ; 
    document.getElementById("horaAtualH").value = hora;
    document.getElementById("horaAtualM").value = min;
    document.getElementById("horaAtualS").value = seg;
    document.getElementById("numDia").value = dia;
    document.getElementById("numMes").value = mes; 
    document.getElementById("numAno").value = ano;
}
