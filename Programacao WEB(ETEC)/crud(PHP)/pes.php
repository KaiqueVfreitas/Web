<?php
$servername = "localhost";
$username = "root";
$password = "@Vieira_2502@";
$dbname = "crud01";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Conexão falhou: " . $conn->connect_error);
}

if(isset($_GET['nome_pesquisa'])) {
    $nome_pesquisa = $_GET['nome_pesquisa'];
    $sql = "SELECT * FROM tbcadastro WHERE nome LIKE '%$nome_pesquisa%'";
} else {
    $sql = "SELECT * FROM tbcadastro";
}

$result = $conn->query($sql);

if ($result->num_rows > 0) {
    echo "<table class='dados' border='1'>";
    echo "<tr><th>Nome</th><th>Email</th><th>Senha</th><th>Sexo</th><th>Data de Nascimento</th></tr>";
    while($row = $result->fetch_assoc()) {
        echo "<tr><td>" . $row["nome"]. "</td><td>" . $row["email"]. "</td><td>" . $row["senha"]. "</td><td>" . $row["sexo"]. "</td><td>" . $row["datanasc"]. "</td></tr>";
    }
    echo "</table>";
} else {
    echo "0 resultados";
}
$conn->close();
?>

<!DOCTYPE html>
<html>
<head>
    <title>Pesquisar por Nome</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        h2 {
            text-align: center;
            margin-top: 20px;
        }

        form {
            text-align: center;
            margin-top: 20px;
        }

        form input[type="text"] {
            padding: 8px;
            border-radius: 4px;
            border: 1px solid #ccc;
            width: 200px;
        }

        form input[type="submit"] {
            padding: 8px 20px;
            border-radius: 4px;
            border: none;
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
        }

        .dados {
            margin: 20px auto;
            border-collapse: collapse;
            width: 80%;
        }

        .dados th, .dados td {
            padding: 8px;
            border: 1px solid #ddd;
            text-align: left;
        }

        .dados th {
            background-color: #4CAF50;
            color: white;
        }

        .dados tr:nth-child(even) {
            background-color: #f2f2f2;
        }
    </style>
</head>
<body>

<h2>Pesquisar por Nome</h2>

<form method="get" action="pes.php">
    Nome: <input type="text" name="nome_pesquisa">
    <input type="submit" value="Pesquisar">
</form>

</body>
</html>
