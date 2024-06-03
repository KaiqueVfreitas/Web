<?php
    $pdo = new PDO('mysql:host=localhost;dbname=crud01', 'root', '@Vieira_2502@');

    $resultados = [];

    if ($_SERVER['REQUEST_METHOD'] === 'POST') {
        if (isset($_POST['txtnome'])) {
            $sql = $pdo->prepare("SELECT * FROM tbcadastro WHERE nome LIKE ?");
            $sql->execute(['%' . $_POST['txtnome'] . '%']);
            $resultados = $sql->fetchAll(PDO::FETCH_ASSOC);
        }
    }
?>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pesquisar Cadastro</title>
    <link rel="stylesheet" href="pesquisar.css">
</head>
<body>
    <div class="search-container">
        <h1>Pesquisar Cadastro</h1>
        <form action="pesquisar.php" method="post">
            <label for="txtnome">Nome:</label>
            <input type="text" id="txtnome" name="txtnome" required>
            <button type="submit">Pesquisar</button>
        </form>

        <?php if (!empty($resultados)): ?>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Nome</th>
                        <th>Email</th>
                        <th>Sexo</th>
                        <th>Data de Nascimento</th>
                    </tr>
                </thead>
                <tbody>
                    <?php foreach ($resultados as $linha): ?>
                        <tr>
                            <td><?php echo htmlspecialchars($linha['idcad']); ?></td>
                            <td><?php echo htmlspecialchars($linha['nome']); ?></td>
                            <td><?php echo htmlspecialchars($linha['email']); ?></td>
                            <td><?php echo htmlspecialchars($linha['sexo']); ?></td>
                            <td><?php echo htmlspecialchars($linha['datanas']); ?></td>
                        </tr>
                    <?php endforeach; ?>
                </tbody>
            </table>
        <?php elseif ($_SERVER['REQUEST_METHOD'] === 'POST'): ?>
            <p>Nenhum cadastro encontrado.</p>
        <?php endif; ?>
    </div>
</body>
</html>
