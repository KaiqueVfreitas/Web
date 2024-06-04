<?php
$servername = "localhost";
$username = "root";
$password = "@Vieira_2502@";
$dbname = "crud01";

$conn = new mysqli($servername, $username, $password, $dbname);

if ($conn->connect_error) {
    die("Conexão falhou: " . $conn->connect_error);
}

if (isset($_GET['id'])) {
    $id = $_GET['id'];

    $sql = "DELETE FROM tbcadastro WHERE id = $id";

    if ($conn->query($sql) === TRUE) {
        echo "<div style='color: green;'>Registro deletado com sucesso!</div>";
    } else {
        echo "<div style='color: red;'>Erro ao deletar registro: " . $conn->error . "</div>";
    }
}

$sql_select = "SELECT * FROM tbcadastro";
$result = $conn->query($sql_select);
?>

<!DOCTYPE html>
<html>
<head>
    <title>Deletar Registro</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }

        h2 {
            text-align: center;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        th, td {
            border: 1px solid #dddddd;
            padding: 8px;
            text-align: left;
        }

        th {
            background-color: #f2f2f2;
        }

        form {
            margin-top: 20px;
            text-align: center;
        }

        input[type="text"] {
            padding: 8px;
            border-radius: 4px;
            border: 1px solid #ccc;
        }

        input[type="submit"] {
            padding: 8px 20px;
            border-radius: 4px;
            border: none;
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }

        .success-message {
            color: green;
            text-align: center;
        }

        .error-message {
            color: red;
            text-align: center;
        }
    </style>
</head>
<body>

<h2>Deletar Registro</h2>

<form method="get" action="del.php">
    ID do Registro a ser deletado: <input type="text" name="id">
    <input type="submit" value="Deletar">
</form>

<h2>Todos os Registros</h2>
<table>
    <tr>
        <th>ID</th>
        <th>Nome</th>
        <th>Email</th>
        <th>Senha</th>
        <th>Sexo</th>
        <th>Data de Nascimento</th>
    </tr>
    <?php
    if ($result->num_rows > 0) {
        while($row = $result->fetch_assoc()) {
            echo "<tr>";
            echo "<td>".$row["id"]."</td>";
            echo "<td>".$row["nome"]."</td>";
            echo "<td>".$row["email"]."</td>";
            echo "<td>".$row["senha"]."</td>";
            echo "<td>".$row["sexo"]."</td>";
            echo "<td>".$row["datanasc"]."</td>";
            echo "</tr>";
        }
    } else {
        echo "<tr><td colspan='6'>Nenhum registro encontrado</td></tr>";
    }
    ?>
</table>

</body>
</html>
