<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $servername = "localhost";
    $username = "root";
    $password = "@Vieira_2502@";
    $dbname = "crud01";

    $conn = new mysqli($servername, $username, $password, $dbname);

    if ($conn->connect_error) {
        die("Conexão falhou: " . $conn->connect_error);
    }

    $nome = $_POST['nome'];
    $email = $_POST['email'];
    $senha = $_POST['senha'];
    $sexo = $_POST['sexo'];
    $datanasc = $_POST['datanasc'];

    $sql = "INSERT INTO tbcadastro (nome, email, senha, sexo, datanasc) VALUES ('$nome', '$email', '$senha', '$sexo', '$datanasc')";

    if ($conn->query($sql) === TRUE) {
        echo "Cadastro realizado com sucesso!";
    } else {
        echo "Erro ao cadastrar: " . $conn->error;
    }

    $conn->close();
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>Cadastro</title>
    <style>
        form {
            margin: 0 auto;
            width: 300px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        input[type="text"],
        input[type="email"],
        input[type="password"],
        select,
        input[type="date"],
        input[type="submit"] {
            display: block;
            margin-bottom: 10px;
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        input[type="submit"] {
            background-color: #4CAF50;
            color: white;
            border: none;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>

<h2>Cadastro</h2>

<form method="post" action="cad.php">
    Nome: <input type="text" name="nome">
    Email: <input type="email" name="email">
    Senha: <input type="password" name="senha">
    Sexo:
    <select name="sexo">
        <option value="Masculino">Masculino</option>
        <option value="Feminino">Feminino</option>
        <option value="Outro">Outro</option>
    </select>
    Data de Nascimento: <input type="date" name="datanasc">
    <input type="submit" value="Cadastrar">
</form>

</body>
</html>
