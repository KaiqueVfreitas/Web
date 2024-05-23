<?php
$altura = $_POST["htmlAltura"];
$genero = $_POST["htmlGenero"];
$pesoAtual = $_POST["htmlPesoAtual"];
$resultado;

if ($genero == "masculino") {
    $resultado = (72.7 * $altura) - 58;
} else if ($genero == "feminino") {
    $resultado = (62.1 * $altura) - 44.7;
} else {
    $resultado = "Houve um erro! Preencha os dados corretamente.";
}

$pesoIdeal = $resultado;

if ($pesoAtual > $pesoIdeal) {
    $pesoDiferenca = $pesoAtual - $pesoIdeal;
    echo "Você precisa perder: $pesoDiferenca kg<br>";
} else if ($pesoAtual < $pesoIdeal) {
    $pesoDiferenca = $pesoIdeal - $pesoAtual;
    echo "Você precisa ganhar: $pesoDiferenca kg<br>";
} else {
    echo "Você está no peso ideal<br>";
}

echo "<div style='display:flex; flex-direction:column'>";
echo "Seu peso ideal é: $resultado kg<br>";
echo "<input type='button' value='VOLTAR' onclick='window.location.href=\"quads.html\"'>";
echo "</div>";
?>
