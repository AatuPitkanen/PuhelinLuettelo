insert into Sukupuoli(koodi, selite) values(0, 'ei tunneta');
insert into Sukupuoli(koodi, selite) values(1, 'mies');
insert into Sukupuoli(koodi, selite) values(2, 'nainen');
insert into Sukupuoli(koodi, selite) values(9, 'ei määritelty');

insert into AsuntoTyyppi (Koodi,Selite) values (0,'rivitalo');
insert into AsuntoTyyppi (Koodi,Selite) values (1,'kerrostalo');
insert into AsuntoTyyppi (Koodi,Selite) values (2,'omakotitalo');

insert into Asunto(Osoite, Ala, Huoneet,tyyppi, Omistus) values('Keskikatu 1', '24', 1,1,1);
insert into Asunto(Osoite, Ala, Huoneet,tyyppi, Omistus) values('Keskikatu 16', '26', 1,1,0);
insert into Asunto(Osoite, Ala, Huoneet,tyyppi, Omistus) values('Rajakatu 3', '28',2,2,0);
insert into Asunto(Osoite, Ala, Huoneet,tyyppi, Omistus) values('asd 5', '37',4,3,1);

Insert into henkilo(enimi,snimi,Sukupuoli,Asunto) values ('Antti', 'veasd',   2, 1);
Insert into henkilo(enimi,snimi,Sukupuoli,Asunto) values ('Liisa', 'gean',   2, 1);
Insert into henkilo(enimi,snimi, Sukupuoli,Asunto) values ('Pertsa', 'Pasanen' ,2, 2);
Insert into henkilo(enimi,snimi, Sukupuoli,Asunto) values ('Joku', 'Lalalala' ,3, 2);

