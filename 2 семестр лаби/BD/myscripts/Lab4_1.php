
<form method="get">
  DATAOPL:<br>
  <input type="text" name="rel"><br>
  <br>
  DATAPROPL:<br>
  <input type="text" name="splt"><br>
  <br>
  <input type="submit" value="GO">
</form>
<br> <br>

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);
if(isset($_GET['rel'], $_GET['splt']))
{
include ("config.php");
$query = "call proc1_4 ('$_GET[rel]', '$_GET[splt]')";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Запит 1.4 </B></P>";
echo "<table border=1>";
while(list($NAME, $TUP_PROD, $DATAOPL, $DATAPROPL) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NAME </td>
         <td> $TUP_PROD </td>
         <td> $DATAOPL </td>
         <td> $DATAPROPL </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

<a href = 'Lab3_2.php'>Повернутись</a><br>