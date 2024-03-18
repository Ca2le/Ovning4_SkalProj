1. ) Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess
grundläggande funktion?

SVAR:
Stacken används främst för att hantera funktionsanrop och lokala variabler av primitiva datatyper.
int a = 10; // Lagras på stacken.

Heapen har ett mer flexibelt system och hanterar referenstyper så som klasser, objekt, arrayer m.m.
Värdet lagras i heapstacken som en instans och kan äga eller dela samma minnesaddress med andra referenser. 
Person alice = new Person("Alice", 25); 

2.) Vad är Value Types respektive Reference Types och vad skiljer dem åt?

SVAR: 
Valuetypes / Primitivetypes är datatyper som ej delar sitt värde med andra. Med andra ord ej går att mutera. 
int a = 25; 
int b = a; 
a = 0 

// a == 0 // true 
// b == 25 // true 

Referenstypen adresserar till ett värde i heapstacken. Detta värde går att dela med andra referenstyper, men om värdet ändras ändras det för alla. 
Person alice = new Person("Alice", 25);  
Person bob = alice;  
bob.Name = "Bob"; 
 
alice.Name == "Bob" // true
bob.Name  == "Bob" // true

3.) Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den
andra returnerar 4, varför? 

SVAR: 
en integear är fortfarande ett primitivt värde i detta fallet och lagras endast i callstacken och inte som ett referensvärde för heapstacken.
Om värdet skulle varit en del av ett objekts fält så hade referensvärdet påverkats i detta fall.
tex: 
Person alice = new Person("Alice", 25); 
Person bob = alice; 
bob.age = 30;
alice.age == 30 // true


Övning 1: ExamineList()

1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir
genomförbar. 
🆗
2. När ökar listans kapacitet? (Alltså den underliggande arrayens storlek)
När det kapaciteten når sin gräns.
3. Med hur mycket ökar kapaciteten?
x2
4. Varför ökar inte listans kapacitet i samma takt som element läggs till?
Onödig resurs hantering.
5. Minskar kapaciteten när element tas bort ur listan?
Nej.
6. När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
När du vet typen och listans längd i förhand.


Övning 3: ExamineStack()
1. Simulera ännu en gång ICA-kön på papper. Denna gång med en stack. Varför är det
inte så smart att använda en stack i det här fallet?
Ett kösystem i en mataffär hade varit väldigt orättvis om sista personen fick tränga sig först.



