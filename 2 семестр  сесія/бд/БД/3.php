

<?php
mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

{
include ("config.php");
$query = "SELECT dovid_distr.NAME_DISTR as 'Назва дистрибютора',
sum(if (month(zamov_tovar.DATE_ZAMOV) >= 3 and month(zamov_tovar.DATE_ZAMOV) <= 6, 
if(nameofc like 'United Kingdom', 
if(dovid_distr.NAME_DISTR='United Kingdom', dovid_tovar.PRICE_TOVAR+(dovid_tovar.PRICE_TOVAR*4.5), dovid_tovar.PRICE_TOVAR))) as 'Квартал 2',
sum(if (month(zamov_tovar.DATE_ZAMOV) >= 7 and month(zamov_tovar.DATE_ZAMOV) <= 9, if(nameofc like 'United Kingdom', if(dovid_distr.NAME_DISTR='United Kingdom', dovid_tovar.PRICE_TOVAR+(dovid_tovar.PRICE_TOVAR*4.5), dovid_tovar.PRICE_TOVAR))) as 'Квартал 3'
FROM dovid_tovar, dovid_distr, vmist_zamov, zamov_tovar
WHERE(
    dovid_distr.KOD_DISTR = zamov_tovar.KOD_DISTR
and zamov_tovar.NUM_ZAMOV = vmist_zamov.NUM_ZAMOV
and vmist_zamov.KOD_TOVAR = dovid_tovar.KOD_TOVAR
and dovid_tovar.PRICE_TOVAR>(select avg(dovid_tovar.PRICE_TOVAR) from dovid_tovar))
group by dovid_distr.NAME_DISTR;";
echo "<br><br>";

$ver=mysqli_query($dbcon,$query);

if(!$ver){
echo "<P>Не вдалося виконати запит</P>";
exit(mysqli_error($dbcon));
}

echo "<P><B> Завдання 3 </B></P>";
echo "<table border=1>";
while(list($NAME_DISTR) = mysqli_fetch_row($ver))
{
echo "<tr>
         <td> $NAME_DISTR </td>
         </td>";
}

echo "</table>";
echo "<P>   </P>";

}
?>

