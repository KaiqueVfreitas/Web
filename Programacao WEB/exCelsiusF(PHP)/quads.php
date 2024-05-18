<?php
$valor = $_POST["htmlValor"];
$tipo = $_POST["htmlCelFah"];
$resultado;

if ($tipo == "celsius") {
    $resultado = (9/5 * $valor) + 32;
} else if ($tipo == "fahrenheit") {
    $resultado = 5/9 * ($valor - 32);
} else {
    echo "Preencha da maneira correta";
}

echo "<div style='display:flex; flex-direction:column'>";
echo "O valor da conversão foi de: $resultado";
echo "<br>";
echo "<input type='button' value='VOLTAR' onclick='window.location.href=\"quads.html\"'>";
echo "</div>";
?>
