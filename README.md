#  Dokumentacja obsługi aplikacji weterynaryjnej – *baza-vet*

##  Wymagania systemowe

- .NET 8 SDK
- MySQL Server (np. XAMPP, WAMP, MySQL Workbench)
- Visual Studio 2022+ (zalecane)
- NuGet pakiety:
  - `Pomelo.EntityFrameworkCore.MySql`
  - `Microsoft.EntityFrameworkCore.Design`

##  Jak uruchomić projekt?

### 1.  Skonfiguruj połączenie z bazą

W pliku `appsettings.json` zmień dane dostępu:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=vet_clinic;user=root;password=TwojeHaslo;"
  }
}
```

### 2.  Stwórz bazę danych

Masz dwie opcje:

####  Opcja A – plik SQL

1. Otwórz `vet_clinic_import.sql` w MySQL Workbench
2. Uruchom zawartość (Ctrl + Enter)

####  Opcja B – przez migracje EF

W terminalu (folder projektu):

```bash
dotnet ef database update
```

### 3.  Uruchom aplikację

W Visual Studio:
- Otwórz projekt `baza-vet.sln`
- Kliknij F5 lub "Start"

##  Funkcje aplikacji

###  Logowanie doktora

- Login i hasło podawane przy starcie
- Dane dostępowe testowe:
  - `student / student`
  - `student2 / student`
  - `student3 / student`

Hasła są przechowywane jako SHA256 hash.

###  Moduły funkcjonalne

| Funkcja                            | Opis |
|------------------------------------|------|
| **Lista zwierząt**                 | Przegląd pacjentów – można filtrować do „Twoich” |
| **Dodawanie badania**             | Formularz z datą, notatką, przypisaniem do doktora |
| **Wyświetlanie badań (max 5)**     | Ostatnie badania + przycisk `Odwołaj` (usuwa wizytę) |
| **Wyszukiwanie**                  | Szukanie po imieniu zwierzęcia |
| **CRUD**                          | Pełna obsługa: dodawanie, podgląd, usuwanie, edytowanie danych pacjenta i badania |
| **Relacja doktor-zwierzę**        | Każdy doktor może przypisać pacjenta do siebie |

##  Dane testowe

Zawarte w pliku `baza danych.sql` lub przez migrację z `HasData()`:

- 3 lekarzy
- 2 zwierzęta
- 2 badania
- 2 szczepienia
- relacje wiele-do-wielu

##  Zabezpieczenia

- Hasła hashowane SHA256 (`PasswordHelper.cs`)
- Przy dodaniu badania – doktor jest przypisywany do pacjenta
- Brak możliwości `push` zmian do repo przez osoby z zewnątrz (GitHub publiczny = tylko do odczytu)

##  Struktura projektu

```
/baza-vet
├── Data/               # DbContext, helper do haseł
├── Modele/             # Klasy: Animal, Doctors, Appointments, etc.
├── Forms/              # WinForms – formularze
├── Migrations/         # Migracje EF Core
├── appsettings.json    # Ustawienia połączenia z bazą
└── Program.cs
```

## ✉️ Uwagi końcowe

- Możesz modyfikować nazwę bazy w `appsettings.json` i pliku SQL
- Projekt obsługuje wielodoktorową relację z pacjentami

# Screenshoty:

## Menu Główne:

![Image](https://github.com/user-attachments/assets/14ec54b0-489e-4304-8056-b4dc1598373a)

## Menu Po Zalogowaniu:

![Image](https://github.com/user-attachments/assets/c538e1c3-e579-4304-817d-9ac25c3d0580)

## Twoje Badania:

![Image](https://github.com/user-attachments/assets/ee79886e-b46a-4105-938d-b91b3868c27e)

## Baza Zwierząt:

![Image](https://github.com/user-attachments/assets/c76a8cf0-d291-4627-80ef-97b0fd569514)

## Dodaj Pacjenta:

![Image](https://github.com/user-attachments/assets/bfd0e048-dade-4dc7-bd16-abbb4435b9d3)

## Dodaj Badanie:

![Image](https://github.com/user-attachments/assets/3748fdff-df79-4d92-b977-3af875da2ac1)



