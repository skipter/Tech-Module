<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if (isset($_GET['num'])) {
        $factoriel = intval($_GET['num']);
        $result = 1;
        $secondResult = 0;
        for ($i = 1; $i <= $factoriel; $i++) {
            $result = $result * $i;
            var_dump($i * $i);
        }
        echo $result;
    }
    ?>
</body>
</html>