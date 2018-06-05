# WebesTodoApp201806
A NetAcademia "Az első webes C# projektem: TO-DO alkalmazás készítése" tanfolyam kiegészítő kódtára

## A tanfolyam célja

```
                               +------------------------+
                               |   Desktop számítógép   |
                               |                        |
                               |    +-------------+     |
+---------------+              |    |  Alkalmazás |     |
|               |              |    |             |     |
|  Felhasználó  |              |    +-------------+     |
|               |              |                        |
|               |              |                        |
+---------------+              |                        |
                               +------------------------+


    Hagyományos Desktop/Mobil alkalmazásfejlesztés

```

```
                                                                          +--------------------------+
                                                                          |  Szerver számítógép      |
                               +------------------------+                 |                          |
                               |   Desktop számítógép   |                 |                          |
                               |    Mobil eszköz        |    Hálózati     |                          |
                               |                        |    kapcsolat    | +----------------------+ |
+---------------+              |                        |                 | |                      | |
|               |              |    +-------------+     +---------------> | |  Szerver alkalmazás  | |
|  Felhasználó  |              |    | Alkalmazás  |     |                 | |  (WebSzerveren futó  | |
|               |              |    | (Böngésző)  |     | <---------------+ |  app)                | |
|               |              |    +-------------+     |                 | |                      | |
+---------------+              |                        |        ^        | +----------------------+ |
                               +------------------------+        |        |                          |
                                                                 |        |              ^           |
                                            ^                    |        |              |           |
                                            |                    |        |              |           |
                                            |                    |        |              |           |
                                            |                    |        +--------------------------+
                                            |                    |                       |
                                            +                    +                       +
                                          HTML                 HTTP                     MVC



                                               Webes Alkalmazásfejlesztés

```

## Ajánlott tanfolyamok
- HTML
  [Lenyűgöző weblapok készítése](https://app.netacademia.hu/Tanfolyam/2017htmllanding-lenyugozo-weblapok-keszitese)
- HTTP
  [Hálózati alapismeretek](https://app.netacademia.hu/Tanfolyam/HA-halozati-alapismeretek)
- GIT
  [Fedezzük fel a gitet!](https://app.netacademia.hu/Tanfolyam/git-fedezzuk-fel-a-gitet)


## Az első webes alkalmazásunk létrehozása
Mivel a környezet és a fejlesztési munkafolyamat az ilyen típusú fejlesztéseknél összetett, így nem kézzel hozzuk létre, hanem a Visula Studio template-jének a segítségével.

A varázslóval létrehozzuk az ASP.NET MVC Webalkalmazást (.NET framework), az alábbi módon:

Új projekt létrehozása:
![Első lépés: új projekt](images\createapp.png)

MVC alkalmazás kiválasztása
![Második lépés: projekt típusa](images\createapp2.png)

### Saját html oldal létrehozása és kiszolgálása
Ha létrehozunk egy html állományt az alkalmazás könyvtárában, azt alapértelmezésben az ASP.NET alkalmazásunk szolgáltatja. Vagyis, ha a böngésző elkéri ezt az állományt, akkor a szerver visszaküldi neki:

Ez a kérés (a böngészőből a szerverre):
```
GET http://localhost:39399/SajatHtmlOldal.html
```

(a szerver a böngészűbe) visszaküldi a HTML oldalt (weblap):
```html
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Ez a saját html oldalunk címe</title>
</head>
<body>
    Ez pedig a saját html oldalunk tartalma, ezt fogja a böngésző megmutatni.
</body>
</html>
```

Ez ugyanúgy működik, ha a file-t nyitjuk meg a böngészőből:
```
file:///D:/Repos/WebesTodoApp201806/TodoApp/TodoApp/SajatHtmlOldal.html
```
akkor is ugyanúgy megjeleníti.

### HTTP: Ha az állomány nem a file rendszerben van, hanem egy másik szerveren

A HTTP feladata: kéréseket megfogalmazását és a válaszok formátumát írja le, ha a hálózaton keresztül szeretnénk egy tartalmat lekérdezni.

A HTTP kérés négy részből áll
- kérés (cím+metódus)
- tartalom
- fejlécek
- végállapot

Ebből minket az első kettő érdekel.

Metódus: pl: GET, POST, PUT, DELETE, stb.
Részletek [a wikipédián](https://hu.wikipedia.org/wiki/HTTP)

### MVC: Dinamikus weblapokból készített webalkalmazás
Ha nem statikus lapok egymás utánját szeretnénk megjeleníteni, hanem:
- egy jól kinéző formátumot meghatározni az összes oldalra
- saját adatokat metenni a weboldal megfelelő helyére
- az alkalmazás interakcióját megszervezni

Az egy szép feladat, erre szolgál az ASP.NET MVC.

