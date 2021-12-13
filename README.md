# The Dude Medium

Get prophecies & visions from **The Dude** himself, main character of
**[The Big Lebowski](https://en.wikipedia.org/wiki/The_Big_Lebowski)** film.

## Setup

1. **[Download](https://github.com/Snailware/TheDudeMedium/archive/refs/heads/master.zip)**
or clone code from
**[Github](https://github.com/Snailware/TheDudeMedium)**.
*If downloaded as zip folder, user must extract contents before use.*

2. Open **TheDudeMedium.sln** file using
**[Visual Studio](https://visualstudio.microsoft.com/)**.

3. Add a Service Based Database called **MediumDB.mdf** to the `MediumLib`
project.

4. Get Connection String property value from **MediumDB.mdf** and save string
to a new text file in `MediumLib` called **ConnectionString.txt**.

5. Execute SQL script **medium_script.sql** on **MediumDB.mdf** to build
database.

6. Start solution! *If errors occur, rebuild the solution and try again*.

## Inspiration

This program was loosely inspired by the oracle program in Temple OS, created
by Terry Davis. Please consider donating to a local charity for those suffering with
mental illness.

*Rest in peace, Terry*.
