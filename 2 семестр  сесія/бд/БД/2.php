

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

include ("config.php");
$query = "call proc2";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Запит 2 </B></P>";
echo "<table border=1>";
while(list($KIL, $Name_tovaru) = mysqli_fetch_row($ver))
{
echo "<tr>
<td> $KIL </td>
<td> $Name_tovaru </td>
         </tr>";
}

echo "</table>";
echo "<P>   </P>";


?>

