# Algorythmic

## Begriff-Definitionen

### Datentyp

Beschreibt Werte, Methoden und Operationen die auf ihm gespeichert sind.

Kann ein Datentyp nur 1 Wert aufnehmen, ist er atomar. Ansonsten eine Datenstruktur.

Datenstruktur ist ein Datentyp mit mehreren Werten.

### Datenstruktur

Beschreibt mehrere Werte, Methoden und Operationen die auf ihr gespeichert sind.

Allgemein einsetzbare Datentpen.

### Algorythmus

Lösungsvorschrift für ein Problem oder einem Problemtyp

**Determiniertheit**: Ergibt mit gleicher eingabe, gleiches resultat.

**Terminierung**: Hat ein Ende.

**Determinismus** Gleiche eingaben, arbeiten gleiche Weg ab.



## Performance von Algorythmen

### Contains auf Liste

n => O(n)		// o == Abhängig von

### Contains auf HashTable

n => O(1)		// o == Abhängig von



### List vs Hashset

* List ist bei Add performanter
* HasSet bei Contains performanter



### Messung von Algorythmen

#### Komplexitätklassen

* Konstant = O(1)
* Linear(Gleich) = O(N)

* Exponential(Zeit schneller als Eingabengrösse)  = O(n<sup>2</sup>)
* Logarythmisch(N = Anzahl Halbierungen von N) = O(log<sub>2</sub>(n))
* Überlinear = O(n log(n))
* Polynomial = O(n<sup>k</sup>) = O(n<sup>3</sup>)
* O(n!) fast gleich schlimm wie O(k<sup>n</sup>)

#### Stoppuhr

Abhängig von

* Hardware
* Programiersprache
* Environement

#### Instruktionen zählen

N Zeilen.

Wie wächst Ausführungszeit wenn N wächst.

#### Kurve

Eingabegrösse (N) auf X und Ausführungszeit auf Y. der Komplexitätsklassen

#### Best / Worst / Average Case

Best Case, wenn Kurve der "Floor" ist.

Worst Case, wenn Kurve das "Ceiling" ist.

Average Case, wenn Kurve das Average ist.

#### Asymptotische Performance

Anzahl Instruktionen bei hohen N's berechnen.

1 + 4N = Komplexität O(N)

2+4N+4N<sup>2</sup> = Komplexität O(N<sup>2</sup>)

N<sup>0</sup> = Konstante Komplexität

N<sup>1</sup> = Komplexität hängt von der Eingabe ab: Worst-Case, Best-Case

#### Bad of O

O(rdnung) sagt nichts aus über konstante Faktoren.

Berücksichtigt das Verhalten bei kelinen n nicht.

Die exakte mathematische Analyse von vielen Algorithmen ist schwierig - unmöglich.

Muss differenzieren zwischen Best, Worst, Aerage-Case.

