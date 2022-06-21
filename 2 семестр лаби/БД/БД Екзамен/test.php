INSERT INTO dovid_distr VALUES (1000, '"August Gumplmayr" ','4010, Feldkirchen A.D. Donau Badmuhllacken, 26', 'Germany'),
(2000, '"Alfa Ltd" ','75 King Street Po Box 738, Hammersmith, London', 'United Kingdom'),
(3000, '"Cerdec ag"  ','Salyufer 6-8, D-10587, Berlin', 'Germany');

INSERT INTO zamov_tovar VALUES (1, 1000, '2004-03-21', '2004-03-25'),
(2, 2000, '2004-03-24', '2004-04-06'),
(3, 3000, '2004-03-27', '2004-03-31'),
(4, 1000, '2004-03-30', '2004-04-05'),
(5, 2000, '2004-04-02', '2004-04-06'),
(6, 3000, '2004-04-05', '2004-04-09'),
(7, 1000, '2004-04-04', '0000-00-00'),
(8, 2000, '2004-04-11', '2004-04-12'),
(9, 3000, '2004-04-14', '2004-04-15'),
(10, 1000, '2004-04-17', '2004-04-18'),
(11, 2000, '2004-04-20', '0000-00-00'),
(12, 3000, '2004-04-23', '2004-04-11');


INSERT INTO dovid_tovar VALUES (211, 'Water heaters Fismar 30л ', 45),
(311, 'Water heaters Gorenje 50л ', 140),
(411, 'Gas columns Gorenje 13л/ хв.', 120),
(511, 'Gas columns Bayard 16л/ хв. ', 160),
(611, 'Food processor Kenwood ', 180);


INSERT INTO dovid_tovar VALUES (1, 1, 211, 9),
(2, 1, 311, 1),
(3, 2, 411, 10),
(4, 2, 511, 15),
(5, 3, 611, 18),
(6, 3, 211, 12),
(7, 4, 311, 9),
(8, 4, 411, 5),
(9, 5, 511, 10),
(10, 5, 611, 1),
(11, 6, 211, 5),
(12, 6, 311, 6),
(13, 7, 411, 2),
(14, 7, 511, 14),
(15, 8, 611, 15),
(16, 8, 211, 11),
(17, 9, 311, 12),
(18, 9, 411, 9),
(19, 10, 511, 8),
(20, 10, 611, 3),
(21, 11, 211, 5),
(22, 11, 311, 10),
(23, 12, 411, 16),
(24, 12, 511, 2);



SELECT dovid_distr.NAME_DISTR as "Назва дистриб'ютора",
sum(if (month(zamov_tovar.DATE_ZAMOV) >= 3 and month(zamov_tovar.DATE_ZAMOV) <= 6, if(nameofc like 'United Kingdom', if(dovid_distr.NAME_DISTR="United Kingdom", dovid_tovar.PRICE_TOVAR+(dovid_tovar.PRICE_TOVAR*4.5), dovid_tovar.PRICE_TOVAR))) as 'Квартал 2',
sum(if (month(zamov_tovar.DATE_ZAMOV) >= 7 and month(zamov_tovar.DATE_ZAMOV) <= 9, if(nameofc like 'United Kingdom', if(dovid_distr.NAME_DISTR="United Kingdom", dovid_tovar.PRICE_TOVAR+(dovid_tovar.PRICE_TOVAR*4.5), dovid_tovar.PRICE_TOVAR))) as 'Квартал 3'
FROM dovid_tovar, dovid_distr, vmist_zamov, zamov_tovar
WHERE(
    dovid_distr.KOD_DISTR = zamov_tovar.KOD_DISTR
and zamov_tovar.NUM_ZAMOV = vmist_zamov.NUM_ZAMOV
and vmist_zamov.KOD_TOVAR = dovid_tovar.KOD_TOVAR
and dovid_tovar.PRICE_TOVAR>(select avg(dovid_tovar.PRICE_TOVAR) from dovid_tovar))
group by dovid_distr.NAME_DISTR;