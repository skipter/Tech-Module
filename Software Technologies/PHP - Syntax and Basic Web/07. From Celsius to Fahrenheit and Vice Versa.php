<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Celsius to Fahrenheit</title>
</head>
<body>
<?php
    function CelsiusToFahrenheit (float $celsius) : float
    {
        return $celsius * 1.8 + 32;
    }

    function FahrenheitToCelsius (float $fahrenheit) : float
    {
        return ($fahrenheit - 32) / 1.8;
    }

    $msgAfterCelsius = "";

    if (isset($_GET['cel'])) {
    $cel = floatval($_GET['cel']);
    $fah = CelsiusToFahrenheit($cel);
    $msgAfterCelsius = "$cel &deg;C = $fah &deg;F";
    }

    $msgAfterFahrenheit = "";

    if (isset($_GET['fah'])) {
    $fah = floatval($_GET['fah']);
    $cel = FahrenheitToCelsius($fah);
    $msgAfterCelsius = "$fah &deg;F = $cel &deg;C";
}
?>
<form>
    Celsius: <input type = "text" name = "cel"/>
    <input type = "submit" value = "Convert">
    <?= $msgAfterCelsius ?>
</form>
<br>
<form>
    Fahrenheit: <input type = "text" name = "fah" />
    <input type = "submit" value = "Convert">
    <?= $msgAfterFahrenheit ?>
</form>
</body>
</html>