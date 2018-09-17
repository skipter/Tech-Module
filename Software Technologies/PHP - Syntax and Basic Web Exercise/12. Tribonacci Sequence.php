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
        $f1 = 1;
        $f2 = 1;
        $f3 = 2;
        $fib = $f1 + $f2 + $f3;

        $num = $_GET['num'];

        echo $f1 . " ";
        echo $f2 . " ";
        echo $f3 . " ";
        echo $fib . " ";

        for ($i = 4; $i < $num; $i++) {
            $f1 = $f2;
            $f2 = $f3;
            $f3 = $fib;
            $fib = $f1 + $f2 + $f3;
            echo $fib . " ";
        }
    }
    ?>
</body>
</html>