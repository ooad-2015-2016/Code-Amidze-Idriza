

# Code-Amidze-Idriza

# "Ko ti dade vozačku?!" (Aplikacija za autoškolu)
> Postoji IZVJESNA mogućnost da ćemo naknadno promijeniti zvanično ime aplikacije, ali do tada... 
##  „Gone in 60 lessons“ – Zvučnije ime za probijanje na inostrano tržište!!!
#### Članovi tima: 

1. Anisa Hadzibulić :girl:
2. Adnan Babović :boy:
3. Emir Avdispahić :boy:
4. Mirsad Begić :trollface:

### Opis teme
Nažalost, u Bosni i Hercegovini je u proteklim godinama značajno povećan broj saobraćajnih nesreća. U 2014. ih je registrirano 500 više nego u 2013. godini, a povećan je i broj nesreća s poginulim i ozlijeđenim. Kao najčešći uzroci saobraćajnih nesreća ističu se  neprilagođena brzina, nepropisno preticanje, nesposobnost za vožnju, oduzimanje prava prvenstva, skretanje s ceste i sl. 
Jasno je da je kvalitetna obuka nadolazećih generacija vozača prijeko potrebna kako bi se ranije pomenuta statistika ublažila. Naša aplikacija omogućava efikasniji , a samim tim i kvalitetniji, rad autoškola te interakciju istih sa njenim polaznicima kroz opcije kao što su interaktivni raspored putem kojeg kandidat bira termin vožnje,prima obavijesti o slobodnim terminima za polaganje teoretskog dijela i prve pomoći (i vrši prijavu na date termine).  Pored tog dijela, kandidatima se nudi i mogućnost usvajanja znanja o saobraćajnim propisima, prvoj pomoći i sl. pomoću raznih resursa smještenih u odjelu za edukaciju ali i utvrđivanje stečenog znanja putem različitih kvizova i simulacija ispita. Funkcionalnosti ove aplikacije imaju osnovni cilj da odvedu autoškole, a samim tim i buduće vozače, na jedan viši nivo koji prati svjetske standarde.

### Procesi

###### Proces kreiranja korisničkog računa
Imamo 4 tipa korisničkog računa: Kandidat, instruktor, autoškola i član komisije. Kada kanditat kreira korisnički račun, on unosi  osnovne informacije o sebi kao što su ime i prezime, datum rođenja, kontakt informacije i mjesto stanovanja (Na osnovu ovih informacija kandidatu se na raspolaganje nudi spisak registrovanih autoškola sa akcentom na one u njegovoj blizini). Ukoliko je kandidat unaprijed odabrao željenu autoškolu, a ista je registrovana u bazi podataka aplikacije, on ima opciju da već pri kreiranju samog korisničkog računa odabere i autoškolu. Pri kreiranju korisničkog, a korisnik je instruktor, pored osnovnih informacija potrebno je unijeti i broj instruktorske dozvole kao i autoškolu u kojoj je instruktor zaposlen.  Analogno se rade registracije autoškola i članova komisije.

###### Proces zakazivanja časova vožnje
Svaki instuktor u sklopu svog profila ima interaktivni raspored termina za vožnju koji je vidljiv kandidatima koje obučava. Instruktor u rasporedu označi satnice u kojima je dostupan nakon čega kandidat bira željeni (slobodan termin). Nakon odabira termina kandidatu se nudi dodatna opcija za unos mjesta sastanka (pickup location) ukoliko instruktor nije eksplicitno odabrao mjesto prilikom kreiranja datog termina. Nakon što kandidat potvrdi odabir željenog termina, instruktoru se pored notifikacije na profilu šalje i generički sms ( u slučaju na instruktor trenutno nema pristup internetu ) da je kandidat rezervisao određeni termin za vožnju(uz lokaciju za sastanak) i traži se konfirmacija samog instruktora.  Također, instruktor prilikom kreiranja rasporeda može određeni termin eksplicitno preporučiti određenom kandidatu, pri čemu je taj termin u rasporedu označen posebnom oznakom (detaljnije objašnjeno kod rangiranja kandidata).

###### Proces testiranja znanja putem kvizova
Pored resursa za učenje, u odjelu za edukaciju nalaze se i razni kvizovi iz saobraćajnih propisa, prve pomoći , simulacija i sl. Kandidat bira vrstu testiranja kojoj želi pristupiti, odgovara na pitanja i nakon izrade testa ima priliku da dobije uvid u svoj rad. Također, postoji opcija da kandidat podijeli rezultat svog testa na društvenim mrežama i na taj način pozove svoje prijatelje da se oprobaju u datom testu. 

###### Prijava za polaganje ispita (teoretski dio, prva pomoć, vozački ispit)
U slučaju da je kandidat ispunio uslove za izlazak na navedene ispite (predao je sve potrebne dokumente i izvršio sve uplate) autoškola/instruktor odobrava opciju da kandidat prijavi polaganje ispita iz teoretskih osnova, prve pomoći ili vozačkog ispita. Ova prijava se također vrši pomoću interaktivnog rasporeda. U slučaju da kandidat položi ispit, ažuriraju se informacije o napretku obuke kandidata (percentage) na njegovom profilu.

###### Ocjenjivanje kandidata za vrijeme vozačkog ispita ( Član komisije )
Ovaj proces započinje prilikom polaganja vozačkog ispita i dostupan je članu komisije. Član komisije prvo unosi datum polaganja, ime i prezime kandidata, ime i prezime instruktora, autoškolu i redni broj polaganja. Kada polaganje započne, članu komisije su dostupni predefinisani prijestupi koji nose određeni broj kaznenih bodova. Kada kandidat napravi grešku, član komisije bira vrstu greške i dodjeljuje kaznene bodove. Ukoliko broj kaznenih bodova dostigne cifru od 100, smatra se da kandidat nije položio vozački ispit. Produkt ovog procesa jeste generisan izvještaj o polaganju vozačkog ispita

###### Bilješke o kandidatima (instruktor)
Nakon što instruktor dobije novog kandidata za obuku,  oni se evidentiraju u posebnom odjelu njegovog profila koji je vidljiv samo njemu(instruktoru). U tom odjelu instruktor može rangirati trenutne sposobnosti kandidata kako bi na osnovu te rang-liste zaključio kako će rasporediti svoje termine budući da neki kandidati iziskuju poseban tretman s obzirom na slabije sposobnosti. Pored samog rangiranja, instruktor za svakog kandidata ima notes u kojem po potrebi bilježi dodatne informacije o kandidatu i napretku obuke istog na osnovu čega zaključuje da li su potrebni dodatni časovi.

###### Snimanje časova vožnje
Proces započinje kada i sama vožnja. Vožnja se dokumetuje pomoću eksterne kamere (dashcam) kako bi se video na kraju poslao na uvid kandidatu ali i instruktoru na njihovim profilima. Instruktor ima mogućnost dodavanja audio komentara ali i tekstualnih komentara na određene segmente videa.
 

### Funkcionalnosti

  -   Kreiranje korisničkog računa (autoškola, instruktor, kandidat, član komisije)
  -   Zakazivanje časova preko interaktivnog rasporeda (svaki instruktor ima svoj raspored)
        	- Slanje SMS obavještenja instruktoru za zakazani čas

  -   Prijava polaganja ispita iz teoretskih osnova, prve pomoći, vozačkog ispita
  -   Testiranje znanja pomoću raznih kvizova
	- Dijeljenje rezultata testova na društvenim mrežama i pozivanje prijatelja da se pridruže
     - Bodovanje kandidata prilikom polaganja vozačkog ispita
	- Generisanje izvještaja o polaganju vozačkog ispita
      - Ocjenjivanje parkiranja kandidata pomoću eksternih senzora
  - Dijelenje finalne obavijesti da je kandidat položio vozački ispit preko društvenih mreža
  - Pregled statističkih podataka određene autoškole
  - Rangiranje kandidata i bilješke o napretku obuke
  -  Vršenje uplata pomoću eksternog sistema (banka)
  -  Upotreba eksternih senzora za ocjenjivanje parkiranja kandidata tokom obuke
  -  Snimanje časova vožnje (perspektiva vozača) putem eksterne kamere te slanje snimka na uvid kandidatu i instruktoru.
  -  Preuzimanje resursa sa eksternih sistema (Mon.ks i Ck) kako bi se isti koristili za kreiranje rasporeda
     

### Akteri
1.	Kandidat
2.	Instruktor
3.	Autoškola
4.	Administrator
5.	Eksterni servis

P.s. Mogli smo ovaj readme ažurirati mnogo ranije ali odgovorni član zadužen za ažuriranje je kao dječak dosta gledao Man Utd.
 te mu je, nažalost, prešlo u naviku da mnoge stvari rješava u 90. minuti... xoxo



