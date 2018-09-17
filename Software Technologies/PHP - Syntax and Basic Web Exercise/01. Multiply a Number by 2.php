<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<?php
if (isset($_GET['num'])) {
    $result = $_GET['num'];
    echo $result * 2;
}
?>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
</body>
</html>