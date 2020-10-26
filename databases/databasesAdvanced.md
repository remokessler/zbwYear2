# Databases Advanced



## MSSQL

10 GB limite ohne Filesystem Files.



## ADO.Net

### Lokale Transaktionen

Eine Verbindung, eine Transaktion.



#### Update Colisions

2. bekommt exceptions bei gleichem insert

```mssql
update person set name = 'Fritz' where 
	id = 5 -- primary key
    and	name = 'max'; -- max = previous value
```

ado added dynamisch z.B. name = 'Max'. Wenn 0 geupdated, dann knallts.



### Verteilte Transaktionen

Über mehrere Maschinen und oder verbindungen oder Files als Transaktion zusammenfassen.

System.Transaction



