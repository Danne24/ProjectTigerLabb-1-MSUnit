# ProjectTigerLabb-1-MSUnit

Labb 1 – MSUnit

Jag ska testa 3 olika delar av programmet, dessa är: 
1.	Skapa ett nytt bankkonto.
2.	Logga in med en administratör.
3.	Överför pengar från ett konto till ett annat konto.

# Skapa ett nytt bankkonto

Med detta test så ska jag testa och se om det går att skapa ett bankkonto åt en kund.

Det som kan gå fel här är att en valuta som inte finns och stöds i koden matas in. För att ett konto ska kunna fungera ordentligt i programmet så måste varje konto ha ett namn, en summa pengar och en valuta, om någon av dessa 3 inte finns med så kommer programmet inte att fungera. Programmet fungerar när ett bankkonto nu existerar för kunden i fråga.

# Logga in med en administratör

Med detta test så ska jag testa och se om en administratör kan logga in i systemet.

Varje användare i programmet har ett eget användarnamn och pinkod, dessa måste en användare ha, annars så uppstår det fel när programmet körs. I själva inloggnings algoritmen så behöver en användare mata in ett användarnamn och pinkod, i testet så har jag dessa som in parametrar till metoden. Programmet fungerar som det ska när en administratör matar in rätt kombination av användarnamn och pinkod.

# Överför pengar från ett konto till ett annat konto

Med detta test så vill jag se om det går att överföra pengar som ligger på en kunds konto till ett annat konto som den kunden också äger.

Det är väldigt viktigt att användaren matar in rätt index för kontot som han vill ta pengar ifrån och även indexet för kontot som han vill skicka pengarna till, annars så kommer programmet att krascha, i basprogrammet så finns det loppar och villkor satser som gör så att programmet inte kommer att krascha, fast i detta test så måste jag vara noga med att ha rätt in parametrar. Det blir även fel om jag skulle överföra mer pengar ifrån ett konto än vad som faktiskt finns där, då blir det ju en minus summa pengar på kontot som pengarna dras ifrån. Programmet fungerar som det ska när konto 2 har fått rätt summa pengar skickat till sig från konto 1.
