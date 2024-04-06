Singleton:
În clasa TextEditor, membrul content este unica instanță care reține conținutul textului. 
Deși clasa în sine nu este implementată ca un singleton, acest model de design implică utilizarea unei singure instanțe a unei clase pentru a gestiona o anumită funcționalitate, ceea ce este cazul aici.
Command:

Modelul Command vă permite să încapsulați solicitările ca obiecte, ceea ce vă permite să parametrizați clienții cu operațiuni, să le puneți în cozi, să le logați, să le tranzacționați 
sau chiar să le anulați.
Pentru această aplicație, butoanele și acțiunile aferente (cum ar fi îngroșarea textului, alinierea la stânga, căutarea etc.) pot fi considerate comenzi. Puteți crea clase separate pentru fiecare acțiune 
(cum ar fi BoldCommand, AlignLeftCommand etc.),care implementează o interfață comună (ICommand) și care execută acțiunea corespunzătoare atunci când sunt apelate.
Acest lucru vă permite să adăugați ușor funcționalități noi și să gestionați comenzi complexe sau compuse.
