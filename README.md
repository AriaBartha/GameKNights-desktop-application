
![gkn_logo](https://github.com/AriaBartha/Tarsasok_Asztali_Alkalmazas/blob/main/gkn_logo.png)

# Game KNights asztali alkalmazás

A projekt egy vállalkozásnak készül, ahol játékmesterek tartanak társasjátékos eseményeket. 
Sokan szeretnek új stratégiai társasjátékokat kipróbálni barátokkal/családdal, de nem feltétlenül 
akarják megvenni az adott társasjátékot vagy megtanulni a stratégiai társasjátékok hosszú 
szabályzatát a játékhoz. A játékmester ismerteti a szabályokat a játékosokkal, és vezeti a játékot. 

Az alkalmazás webböngészős és mobil felhasználói felületén, a vendégek stratégiai társajátékok 
játszására foglalhatnak időpontot (egy foglalásnál több fő részére is), böngészhetnek a stratégiai 
játékok leírásaiban. 

Az asztali alkalmazás a játékmesterek számára készül. Ebben adhatnak meg időpontokat, 
kezelhetik a foglalásokat és a társasjátékok adatbázisát. 

## Ajánlott rendszerkövetelmények

- Windows 10 vagy 11
- minimum 2GB RAM
- minimum 1.8 Ghz processzor
- Videokártya, ami minimum 720p képernyő felbontást támogat

## Telepítés és futtatás

- Az asztali alkalmazás git repojának klónozása után Visual Studioban megnyitva futtatható. (A futtatás előtt el kell indítani az alkalmazás Backendjét a [Backend](https://github.com/Abradave/boardGames_backend/blob/main/README.md) git repojának README.md fájljában leírtak szerint.)
- Vagy a az asztali alkalmazás git repojának klónozása után az alkalmazás mappájában a GameKNightsSetUp/Release/GameKNightsSetUp.msi fájlból telepíthetó az alkalmazás a számítógépre. Telepítés után az asztalról és a menüből is elérhető lesz. (A futtatás előtt ebben az esetben is el kell indítani az alkalmazás Backendjét a [Backend](https://github.com/Abradave/boardGames_backend/blob/main/README.md) git repojának README.md fájljában leírtak szerint.)
- A Backend alkalmazás seederében van két teszt munkavállaló, így seedelés után a következő munkavállalói adatokkal lehet bejelentkezni a GameKNights asztali alkalmazásba:
  - Admin Admin e-mail: admin@gkn.com jelszó: admin123
  - Teszt Elek teszt@gkn.com jelszó: 12345678
