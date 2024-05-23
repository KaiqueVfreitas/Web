<?php
$nm1 = $_POST["num1"];
$nm2 = $_POST["num2"];
$result;

$result = ($nm1 * $nm1) + ($nm2 * $nm2);

echo "<div class='container'>";
echo "<div>";
echo "<link rel='stylesheet' href='style02.css'>";
echo $result;
echo "<input type='button' value='VOLTAR' onclick='window.location.href=\"quads.html\"'>";
echo "</div>";
echo "</div>";
?>
