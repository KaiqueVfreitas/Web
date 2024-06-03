<?php
    $pdo = new PDO('mysql:host=localhost;dbname=crud01', 'root', '@Vieira_2502@');

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        if (isset($_POST['txtnome'], $_POST['txtemail'], $_POST['txtsenha'], $_POST['sexo'], $_POST['txtdate'])) {
            $sql = $pdo->prepare("INSERT INTO tbcadastro (nome, email, senha, sexo, datanas) VALUES (?, ?, ?, ?, ?)");
            $sql->execute([$_POST['txtnome'], $_POST['txtemail'], $_POST['txtsenha'], $_POST['sexo'], $_POST['txtdate']]);
            echo 'Inserido com sucesso!';
        }
    }
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tela de Cadastro</title>
    <link rel="stylesheet" href="cad.css">
</head>
<body>
    <div class="register-container">
        <h1>Cadastro</h1>
        <form action="cad.php" method="post">
            <label for="txtnome">Nome:</label>
            <input type="text" id="txtnome" name="txtnome" required>

            <label for="txtemail">Email:</label>
            <input type="email" id="txtemail" name="txtemail" required>

            <label for="txtsenha">Senha:</label>
            <input type="password" id="txtsenha" name="txtsenha" required>

            <label for="sexo">Sexo:</label>
            <select id="sexo" name="sexo" required>
                <option value="" disabled selected>Selecione</option>
                <option value="masculino">Masculino</option>
                <option value="feminino">Feminino</option>
                <option value="outro">Outro</option>
            </select>

            <label for="txtdate">Data de Nascimento:</label>
            <input type="date" id="txtdate" name="txtdate" required>

            <button type="submit">Cadastrar</button>
        </form>
    </div>
</body>
</html>
