# 📘 Dokumentacja obsługi aplikacji weterynaryjnej – *baza-vet*

## 📝 Wymagania systemowe

- .NET 8 SDK
- MySQL Server (np. XAMPP, WAMP, MySQL Workbench)
- Visual Studio 2022+ (zalecane)
- NuGet pakiety:
  - `Pomelo.EntityFrameworkCore.MySql`
  - `Microsoft.EntityFrameworkCore.Design`

## 🏗️ Jak uruchomić projekt?

### 1. 🔧 Skonfiguruj połączenie z bazą

W pliku `appsettings.json` zmień dane dostępu:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=vet_clinic;user=root;password=TwojeHaslo;"
  }
}
```

### 2. 🗃️ Stwórz bazę danych

Masz dwie opcje:

#### ✅ Opcja A – plik SQL

1. Otwórz `baza danych.sql` w MySQL Workbench
2. Uruchom zawartość (Ctrl + Enter)

#### ✅ Opcja B – przez migracje EF

W terminalu (folder projektu):

```bash
dotnet ef database update
```

### 3. ▶️ Uruchom aplikację

W Visual Studio:
- Otwórz projekt `baza-vet.sln`
- Kliknij F5 lub "Start"

## 👨‍⚕️ Funkcje aplikacji

### 🔐 Logowanie doktora

- Login i hasło podawane przy starcie
- Dane dostępowe testowe:
  - `student / student`
  - `student2 / student`
  - `student3 / student`

Hasła są przechowywane jako SHA256 hash.

### 🐾 Moduły funkcjonalne

| Funkcja                            | Opis |
|------------------------------------|------|
| **Lista zwierząt**                 | Przegląd pacjentów – można filtrować do „Twoich” |
| **Dodawanie badania**             | Formularz z datą, notatką, przypisaniem do doktora |
| **Wyświetlanie badań (max 5)**     | Ostatnie badania + przycisk `Odwołaj` (usuwa wizytę) |
| **Wyszukiwanie**                  | Szukanie po imieniu zwierzęcia |
| **CRUD**                          | Pełna obsługa: dodawanie, podgląd, usuwanie, edytowanie danych pacjenta i badania |
| **Relacja doktor-zwierzę**        | Każdy doktor może przypisać pacjenta do siebie |

## 🧪 Dane testowe

Zawarte w pliku `baza danych.sql` lub przez migrację z `HasData()`:

- 3 lekarzy
- 2 zwierzęta
- 2 badania
- 2 szczepienia
- relacje wiele-do-wielu

## 🔐 Zabezpieczenia

- Hasła hashowane SHA256 (`PasswordHelper.cs`)
- Przy dodaniu badania – doktor jest przypisywany do pacjenta
- Brak możliwości `push` zmian do repo przez osoby z zewnątrz (GitHub publiczny = tylko do odczytu)

## 📦 Struktura projektu

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
- Jeśli potrzebujesz `Restore` (przywracanie pacjenta) — możesz użyć pola `IsDeleted` i filtrować