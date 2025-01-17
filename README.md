## VetClientManager

VetClientManager to aplikacja internetowa zaprojektowana w celu ułatwienia zarządzania klientami,
zwierzętami oraz wizytami w klinice weterynaryjnej. Projekt wykorzystuje technologię ASP.NET Core do obsługi backendu oraz React do tworzenia interfejsu użytkownika. 
Aplikacja umożliwia przechowywanie danych o klientach i ich zwierzętach, planowanie wizyt oraz w przyszłości integrację z zewnętrznymi serwisami do wysyłania przypomnień.

## Funkcjonalności

- **Zarządzanie zwierzętami**: Dodawanie, edytowanie, usuwanie oraz przeglądanie informacji o zwierzętach należących do klientów.
- **Zarządzanie wizytami**: Planowanie, edytowanie, usuwanie oraz przeglądanie terminów wizyt.
- **Autoryzacja i uwierzytelnianie**: Bezpieczny dostęp do aplikacji z podziałem na role użytkowników Admin (lekarz) i User (klient).

## Planowane funkcjonalności

- **Zarządzanie klientami**: Dodawanie, edytowanie, usuwanie oraz przeglądanie informacji o klientach. W pierwszej wersji klienci będą hard-coded.
- **Przypomnienia**: Wysyłanie powiadomień o nadchodzących wizytach.

## Podział pracy

Projekt podzieliłem na mniejsze części. Pracę zaplanowałem na podstawie metody MoSCoW (story points).

**Must have**
1. Projektowanie i konfiguracja bazy danych (6 SP)
- Utworzenie modeli danych (Pet, Appointment) (3 SP)
- Konfiguracja Dappera (3 SP)

2. Implementacja API (17 SP)
- Utworzenie endpointów CRUD dla zwierząt (6 SP)
- Utworzenie endpointów CRUD dla wizyt (6 SP)
- Dodanie autoryzacji i uwierzytelniania JWT (5 SP)

3. Implementacja frontend (21 SP)
- Utworzenie struktury projektu React (3 SP)
- Implementacja komponentów do zarządzania zwierzętami (7 SP)
- Implementacja komponentów do zarządzania wizytami (7 SP)
- Integracja z API backendu (4 SP)

**Should have**

**Could have**
- Ostylowanie aplikacji w CSS (6 SP)
