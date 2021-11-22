SELECT ogloszenie.id, ogloszenie.tytul,ogloszenie.tresc FROM ogloszenie WHERE ogloszenie.kategoria = 1

CREATE USER `moderator`@`localhost` IDENTIFIED BY 'qwerty'

GRANT DELETE, SELECT ON `3ti_ark2_baza_2021_22`.ogloszenie TO moderator@localhost

REVOKE DELETE on `3ti_ark2_baza_2021_22`.ogloszenie FROM moderator@localhost 