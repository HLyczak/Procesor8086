SYMULATOR WYBRANYCH POLECEŃ PROCESORA 8086

Wyższa Szkoła Informatyki i Ekonometrii w Krakowie

Informatyka Stosowana
 Honorata Łyczak gr. VIII

Procesor 8086.

Procesor to inaczej CPU – jednostka centralna (Central Processing Unit). Zbudowany z tranzystorów o mikroskopijnej wielkości. Tranzystor działa jak kontakt – posiada dwa wejścia co powoduje, iż jest możliwość tworzenia wartości dwójkowych. Mikroprocesor 8086 został wynaleziony w 1976 przez firmę Intel. Jest to następca 8 bitowego procesora 8080.
 Procesor 8086 opiera się na 16 bitowej architekturze: rejestry, szyna danych, obliczenia.

Główne parametry procesora:

- Architektura CISC - pojedynczy rozkaz mikroprocesora wykonuje kilka operacji niskiego poziomu, jak na przykład pobranie z pamięci, operację arytmetyczną i zapisanie do pamięci.
- Jednostka arytmetyczno – logiczna działa na 16 bitach, wykonuje podstawowe operacje na liczbach całkowitych.
- Rejestry ogólnego przeznaczenia 16 bitowe, składające się z par 8 bitowych.
- Pamięć i magistrala danych również 16 bitowa.
- Magistrala adresowa 20 bitowa zdolna do adresowania 1MB.
- Nie posiada określonego trybu pracy jak np. inne procesory, tryb użytkownika.
- Porty wejścia i wyjścia z określoną przestrzenią adresową.
- Siedem trybów adresowania argumentów w pamięci.
- Architektura mikroprocesora składa się z jednostki wykonawczej EU (Execution Unit) oraz

BIU (Bus Interface Unit) - zespołu łącza z magistralą systemową.

Rozwiązania:

- tryby adresowania: rejestrowy, natychmiastowy, pośredni, bezpośredni, indeksowy, bazowy i indeksowo- bazowy
- wprowadzenie mechanizmu segmentacji, mikroprocesor 8086 zawiera cztery rejestry segmentowe w których przechowywana jest część segmentowa adresu. Zawartość tego rejestru wraz z adresem efektywnym stanowi adres fizyczny pamięci.

Jednostka wykonawcza:

Składa się z 16 bitowej jednostki arytmetyczno – logicznej (ALU) wraz z rejestrem znaczników oraz blok rejestru ogólnego przeznaczenia. Jednostka ALU zajmuje się wykonaniem podstawowych operacji dodawanie, odejmowanie, suma, iloczyn, negacja.
 Jednostka ta jest dołączona do magistrali wewnętrznej procesora. Z magistrali pobierane są argumenty operacji oraz wysyłany jest wynik operacji. Do jednostki ALU dołączony jest rejestr flag.

Rejestr flag dzieli się na dwie grupy: kontrolną oraz arytmetyczną. Flagi arytmetyczne dostarczają informacji nt. wyniku ostatniej operacji. Flagi kontrolne wpływają na sposób pracy mikroprocesora.

Posiadamy następujące znaczniki:
 SF, ZF, PF, AF, CF, OF, IF, TF.

Rejestry ogólnego przeznaczenia:
 Zawiera cztery, 16 bitowe rejestry AX, BX, CX oraz DX, są to bardzo szybkie elementy elektroniczne mogące przechowywać informacje.

Każdy z wyżej wymienionych rejestrów (16bit), może działać jako dwa niezależne rejestry 8bitowe np.:

- AX jako AL oraz AH
- BX jako BL oraz BH
- CX jako CL oraz CH
- DX jako DL oraz DH

Zgodnie z przeznaczeniem każdy z rejestrów ma swoja nazwę:

- AX – akumulator- bezpośrednio współpracuje z jednostką arytmetyczno-logiczną.
 W akumulatorze operacje takie jak mnożenie, dzielenie oraz operacje wejścia i wyjścia potrzebują akumulatora do przechowywania argumentu bądź też zapisu wyniku.
- BX- baza – służy do adresowania argumentu znajdującego się w pamięci, stanowi bazę do obliczania adresu.
- CX-licznik- używany jako licznik w operacjach łańcuchowych oraz pętlach. Po każdej iteracji zawartość automatycznie dekrementowana.
- DX- dane – rejestr używany jako licznik w operacjach arytmetycznych do przechowywania części argumentu lub wyniku operacji (mnożenie i dzielenie 16bitowe).

Rejestry wskaźnikowe oraz indeksowe:

16 bitowe rejestry adresowe SP, BP, SI, DI. Wskazują miejsce w pamięci w którym znajdują się rozkazy. Używane podczas adresowania indeksowego, bazowego oraz indeksowo-bazowego.

- SP- wskaźnik stosu – wskazuje adres ostatnio zapisanego słowa na stosie.
- BP – wskaźnik bazy – rejestr ogólnego przeznaczenia, wykorzystywany do adresowania bazowego.
- SI- rejestr indeksowy źródła. Przetrzymuje adres źródła danych. Po każdej operacji jego zawartość jest inkrementowana lub dekrementowana, zależy to od ustawienia flagi kierunku.
- DI-rejestr indeksowy przeznaczenia. Uniwersalny rejestr który jest wykorzystywany podczas dwuargumentowych operacji. Przetrzymuje adres przeznaczenia danych. Po każdej operacji jego zawartość jest inkrementowana lub dekrementowana, zależy to od ustawienia flagi kierunku.

Rejestry segmentowe:
 Są to rejestry 16 bitowe, służą do obliczania adresu fizycznego komórki pamięci. Zawierają adres początkowy danego rejestru.

- CS – rejestr segmentowy programu – wyznacza początek aktualnie używanego rejestru programu, służy do obliczania adresu fizycznego kolejnego rozkazu do pobrania.
- DS – rejestr segmentowy danych – używany do obliczania adresu fizycznego argumentu lub wyniku aktualnie wykonywanego rozkazu. Przy rozkazach łańcuchowych zawartość rejestru służy do obliczania adresu źródła danych.
- SS – rejestr segmentowy stosu – służy do obliczania adresu fizycznego komórki pamięci na która wskazuje wskaźnik stosu.
- ES- rejestr segmentowy dodatkowy – służy do obliczania adresu fizycznego przeznaczenia dla operacji łańcuchowych ( przenoszenie danych ).

Obliczanie adresu:

**EA = BR + IR + p**

EA – adres efektywny – logiczny. Na jego podstawie układy segmentacji obliczają adres rzeczywisty.

BR – rejestr bazowy (BP lub BX)

IR- rejestr indeksowy (SI lub DI)

p- przemieszczenie.

Mikroprocesor obsługuje następujące tryby adresowania:

- indeksowy, bazowy, indeksowo-bazowy, bezpośrednie, natychmiastowe, rejestrowe, pośrednie.

Projekt który pragnę zaprezentować obrazuje w uproszczony sposób polecenia MOVE oraz XCHG.
 Możemy wybrać spośród poniższych trybów adresowania:

- indeksowy,
- bazowy,
- indeksowo-bazowy.

Symulacja pomiędzy rejestrami ogólnego przeznaczenia oraz dla operacji MOV oraz XCHG dla zapisu z rejestru do pamięci oraz z pamięci do rejestru.

Dodatkowo obliczany jest adres.

Podstawową instrukcją przesyłania danych jest polecenie **MOV.**
Odpowiada ono za przesłanie danych do rejestru przeznaczenia np. pamięci.

**Przykłady polecenia MOV** :
 MOV AX 100 -\&gt; prześlij do rejestru AX liczbę 100

MOV BX 20 -\&gt; prześlij do rejestru BX liczbę 20

Kolejną instrukcją jest polecenie XCHG, PUSH oraz POP.

Poleceni XCHG odpowiada za zamianę

**Przykład polecenia XCHG:**

MOV ax10

MOV bx 20

XCHG ax,bx

Wynikiem będzie zamian wcześniej przypisanych wartości ax z bx.

Polecenie OFSET służy do pobrania adresu zmiennej.
