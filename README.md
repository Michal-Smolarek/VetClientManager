## VetClientManager

VetClientManager to aplikacja internetowa zaprojektowana w celu u�atwienia zarz�dzania klientami,
zwierz�tami oraz wizytami w klinice weterynaryjnej. Projekt wykorzystuje technologi� ASP.NET Core do obs�ugi backendu oraz React do tworzenia interfejsu u�ytkownika. 
Aplikacja umo�liwia przechowywanie danych o klientach i ich zwierz�tach, planowanie wizyt oraz w przysz�o�ci integracj� z zewn�trznymi serwisami do wysy�ania przypomnie�.

## Funkcjonalno�ci

- **Zarz�dzanie zwierz�tami**: Dodawanie, edytowanie, usuwanie oraz przegl�danie informacji o zwierz�tach nale��cych do klient�w.
- **Zarz�dzanie wizytami**: Planowanie, edytowanie, usuwanie oraz przegl�danie termin�w wizyt.
- **Autoryzacja i uwierzytelnianie**: Bezpieczny dost�p do aplikacji z podzia�em na role u�ytkownik�w Admin (lekarz) i User (klient).

## Planowane funkcjonalno�ci

- **Zarz�dzanie klientami**: Dodawanie, edytowanie, usuwanie oraz przegl�danie informacji o klientach. W pierwszej wersji klienci b�d� hard-coded.
- **Przypomnienia**: Wysy�anie powiadomie� o nadchodz�cych wizytach.

## Podzia� pracy

Projekt podzieli�em na mniejsze cz�ci. Prac� zaplanowa�em na podstawie metody MoSCoW (story points).

**Must have**
1. Projektowanie i konfiguracja bazy danych (6 SP)
- Utworzenie modeli danych (Pet, Appointment) (3 SP)
- Konfiguracja Dappera (3 SP)

2. Implementacja API (17 SP)
- Utworzenie endpoint�w CRUD dla zwierz�t (6 SP)
- Utworzenie endpoint�w CRUD dla wizyt (6 SP)
- Dodanie autoryzacji i uwierzytelniania JWT (5 SP)

3. Implementacja frontend (21 SP)
- Utworzenie struktury projektu React (3 SP)
- Implementacja komponent�w do zarz�dzania zwierz�tami (7 SP)
- Implementacja komponent�w do zarz�dzania wizytami (7 SP)
- Integracja z API backendu (4 SP)

**Should have**

**Could have**
- Ostylowanie aplikacji w CSS (6 SP)
