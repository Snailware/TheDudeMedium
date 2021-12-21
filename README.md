# The Dude Medium

![The Dude](https://github.com/Snailware/TheDudeMedium/blob/master/MediumLib/Images/247.png?raw=true)

Get prophecies & visions from The Dude himself, main character of
[The Big Lebowski](https://en.wikipedia.org/wiki/The_Big_Lebowski) film.

## Setup

1. [Download](https://github.com/Snailware/TheDudeMedium/archive/refs/heads/master.zip)
   or clone code from
   [Github](https://github.com/Snailware/TheDudeMedium).
   _If downloaded as zip folder, user must extract contents before use._

2. Open **TheDudeMedium.sln** file using
   [Visual Studio](https://visualstudio.microsoft.com/).

3. Add a Service Based Database called **MediumDB.mdf** to the `MediumLib`
   project.

4. Get Connection String property value from **MediumDB.mdf** and save string
   to a new text file in `MediumLib` called **ConnectionString.txt**.

5. Execute SQL script **medium_script.sql** on **MediumDB.mdf** to build
   database.

6. Start solution! _If errors occur, rebuild the solution and try again_.

## Inspiration

This program was loosely inspired by the oracle program in
[Temple OS](https://templeos.org/), created by
[Terry Davis](https://en.wikipedia.org/wiki/Terry_A._Davis).

_Rest in peace, Terry_.
