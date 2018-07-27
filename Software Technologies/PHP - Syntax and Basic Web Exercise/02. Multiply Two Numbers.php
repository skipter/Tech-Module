<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<?php
if (isset($_GET['num1']) && isset($_GET['num2'])) {
    $result = $_GET['num1'] * $_GET['num2'];
    echo $result;
}
?>
    <form>
        N: <input type="text" name="num1" />
		M: <input type="text" name="num2" />
        <input type="submit" />
    </form>
	<!--Write your PHP Script here-->
</body>
</html>