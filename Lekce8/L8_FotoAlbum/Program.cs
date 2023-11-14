/*
Foto album
- vytvořte třídu FotoAlbum, která bude mít private vlastnost pocetStranek. 
- uvnitř vytvořte veřejnou metodu VratPocetStranek, která vrátí počet stránek.
- napište konstruktor, který bude mít jeden parametr, který bude sloužit pro vytvoření alba s libovolným počtem stránek 
- napište konstruktor, které vytvoří album se 16 stránkami - tento by v ideálním případě použil předchozí konstruktor
- tiskárna umí maximálně 100 stránek - kontrolujte toto v konstruktoru a pokud uživatel bude chtít album s více stránkami, napište mu zprávu a snižte automaticky počet stránek na 100
- použijte oba konstruktory v hlavní metodě Main a vypište počty stránek
*/

Album album1 = new Album();
album1.VypisPocetStranek();

Album album2 = new Album(32);
album2.VypisPocetStranek();

Album album3 = new Album(128);
album3.VypisPocetStranek();
