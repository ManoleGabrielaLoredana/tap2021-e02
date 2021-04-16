#PRINCIPIILE SOLID#

S - Single Responsibility Principle
O – Open-Closed Principle
L – Liskov Substitution Principle
I – Interface Segregation Principle
D – Dependency Inversion Principle

##Single Responsibility Principle##
S – Fiecare modul trebuie sa fie responsabil pentru un singur aspect legat de functionalitatea oferita de sistemul software. Acel aspect trebuie sa fie incapsulat in intregime de modulul responsabil.

##Open-Closed Principle##
O – Partile componente ale unui sistem software trebuie sa fie usor de extins, dar greu de modificat. Mai exact o entitate( de ex o clasa) trebuie sa poata fi extinsa cu usurinta fara a fi modificata.

##Liskov Substitution Principle##
L – Obiectele unui sistem software trebuie sa fie substituibile de catre instante ale unor subtipuri de obiecte, fara ca substituia sa afecteze corectitudinea sistemului.

##Interface Segregation Principle##
I – Interfetele trebuie sa fie mici si specific contextului de utilizare; nu mari si generale, astfel incat clasele care implementeaza acele interfete sa nu contina metode nefolositoare pentru ele, insa care se folosesc in alte clase derivate.

##Dependency Inversion Principle##
D – Modulele unui sistem software trebuie sa depinda de reprezentari abstracte si nu de implementari concrete. Daca ar depinde de implementari concrete, testarea si reimplementarea acelor component ear fi dificile sau chiar nu ar fi posibile.
