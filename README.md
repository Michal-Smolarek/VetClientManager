## VetClientManager

VetClientManager to aplikacja internetowa zaprojektowana w celu u³atwienia zarz¹dzania klientami,
zwierzêtami oraz wizytami w klinice weterynaryjnej. Projekt wykorzystuje technologiê ASP.NET Core do obs³ugi backendu oraz React do tworzenia interfejsu u¿ytkownika. 
Aplikacja umo¿liwia przechowywanie danych o klientach i ich zwierzêtach, planowanie wizyt oraz w przysz³oœci integracjê z zewnêtrznymi serwisami do wysy³ania przypomnieñ.

## Funkcjonalnoœci

- **Zarz¹dzanie zwierzêtami**: Dodawanie, edytowanie, usuwanie oraz przegl¹danie informacji o zwierzêtach nale¿¹cych do klientów.
- **Zarz¹dzanie wizytami**: Planowanie, edytowanie, usuwanie oraz przegl¹danie terminów wizyt.
- **Autoryzacja i uwierzytelnianie**: Bezpieczny dostêp do aplikacji z podzia³em na role u¿ytkowników Admin (lekarz) i User (klient).

## Planowane funkcjonalnoœci

- **Zarz¹dzanie klientami**: Dodawanie, edytowanie, usuwanie oraz przegl¹danie informacji o klientach. W pierwszej wersji klienci bêd¹ hard-coded.
- **Przypomnienia**: Wysy³anie powiadomieñ o nadchodz¹cych wizytach.

## Podzia³ pracy

Projekt podzieli³em na mniejsze czêœci. Pracê zaplanowa³em na podstawie metody MoSCoW (story points).

**Must have**
1. Projektowanie i konfiguracja bazy danych (6 SP)
- Utworzenie modeli danych (Pet, Appointment) (3 SP)
- Konfiguracja Dappera (3 SP)

2. Implementacja API (17 SP)
- Utworzenie endpointów CRUD dla zwierz¹t (6 SP)
- Utworzenie endpointów CRUD dla wizyt (6 SP)
- Dodanie autoryzacji i uwierzytelniania JWT (5 SP)

3. Implementacja frontend (21 SP)
- Utworzenie struktury projektu React (3 SP)
- Implementacja komponentów do zarz¹dzania zwierzêtami (7 SP)
- Implementacja komponentów do zarz¹dzania wizytami (7 SP)
- Integracja z API backendu (4 SP)

**Should have**

**Could have**
- Ostylowanie aplikacji w CSS (6 SP)
