<form method="get">
  TOVAR_NAME:<br>
  <input type="text" name="TOVAR_NAME"><br>
  <br>
  <input type="submit" value="GO">
</form>
<br> <br>

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
if(isset($_GET['TOVAR_NAME']))
{
include ("config1.php");
$query = "call proc1 ('$_GET[TOVAR_NAME]')";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Завдання </B></P>";
echo "<table border=1>";
while(list($NUM_ZAMOV, $NAME_TOVAR, $NAME_DISTR, $KIL, $PRICE_TOVAR, $VARTIST) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NUM_ZAMOV </td>
         <td> $NAME_TOVAR </td>
         <td> $NAME_DISTR </td>
         <td> $KIL </td>
         <td> $PRICE_TOVAR </td>
         <td> $VARTIST </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

