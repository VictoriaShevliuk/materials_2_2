

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

include ("config.php");
$query = "call proc1 ";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Завдання </B></P>";
echo "<table border=1>";
while(list($NUM_ZAMOV, $NAME_DISTR, $ADRESS_DISTR, $DATE_ZAMOV, $DATE_SPLAT) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NUM_ZAMOV </td>
         <td> $NAME_DISTR </td>
         <td> $ADRESS_DISTR </td>
         <td> $DATE_ZAMOV </td>
         <td> $DATE_SPLAT </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";


?>

