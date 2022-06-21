Вартість розраховуються як добуток ціни товару на кількість замовленого товару.
 Якщо назва країни дистриб’ютора Польща, то ціна зменшується на 4,5%, в іншому випадку - ціна залишається незмінною.

1.	Створити запит про замовлення довільного товару за другий квартал. Назва товару повинна задаватися під час виконання запиту.
 Передбачити ввід назви товару по перших літерах. Динамічний набір записів повинен містити такі поля:
  Номер замовлення, Найменування товару, Назва фірми, Кількість, Ціна, Вартість.
   Дані впорядкувати по алфавіту назв фірм, а в межах однієї групи – по назві товару.

2.	Створити груповий запит, що виводить кількість замовлень між двома датами. Обидві дати повинні задаватися під час виконання запиту.


3.	Створити запит на зовнішнє об’єднання, який повинен містити дистріб'юторів, які не замовляли товари Calligaris.




//1st// proc1 (tovar)

SELECT zamov_tovar.NUM_ZAMOV, dovid_tovar.NAME_TOVAR, dovid_distr.NAME_DISTR, vmist_zamov.KIL, dovid_tovar.PRICE_TOVAR,
if(dovid_distr.NAME_DISTR="Польща", dovid_tovar.PRICE_TOVAR-(dovid_tovar.PRICE_TOVAR*4.5), dovid_tovar.PRICE_TOVAR)
FROM dovid_distr, dovid_tovar, vmist_zamov, zamov_tovar
WHERE
quarter(zamov_tovar.DATE_ZAMOV)=2
and dovid_distr.KOD_DISTR = zamov_tovar.KOD_DISTR
and zamov_tovar.NUM_ZAMOV = vmist_zamov.NUM_ZAMOV
and vmist_zamov.KOD_TOVAR = dovid_tovar.KOD_TOVAR

//2nd// proc2 (downdate, uperdate)

SELECT sum(vmist_zamov.KIL), dovid_tovar.NAME_TOVAR
FROM dovid_tovar, dovid_distr, vmist_zamov, zamov_tovar
WHERE(
    dovid_distr.KOD_DISTR = zamov_tovar.KOD_DISTR
and zamov_tovar.NUM_ZAMOV = vmist_zamov.NUM_ZAMOV
and vmist_zamov.KOD_TOVAR = dovid_tovar.KOD_TOVAR
and (zamov_tovar.DATE_ZAMOV between downdate and uperdate))
GROUP BY dovid_tovar.NAME_TOVAR