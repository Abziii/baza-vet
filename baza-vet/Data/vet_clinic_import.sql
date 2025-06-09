
-- Usunięcie starej bazy (opcjonalne)
DROP DATABASE IF EXISTS vet_clinic;

-- Tworzenie bazy danych
CREATE DATABASE vet_clinic;
USE vet_clinic;

-- Tabela: Lekarze
CREATE TABLE doctors (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    specialization VARCHAR(100),
    username VARCHAR(100) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL
);

-- Tabela: Zwierzęta
CREATE TABLE animals (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(50) NOT NULL,
    species VARCHAR(30) NOT NULL,
    breed VARCHAR(50),
    birth_date DATE,
    owner_name VARCHAR(100)
);

-- Tabela: Szczepienia
CREATE TABLE vaccinations (
    id INT AUTO_INCREMENT PRIMARY KEY,
    animal_id INT NOT NULL,
    vaccine_name VARCHAR(100),
    date_given DATE,
    FOREIGN KEY (animal_id) REFERENCES animals(id) ON DELETE CASCADE
);

-- Tabela: Wizyty
CREATE TABLE appointments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    animal_id INT NOT NULL,
    doctor_id INT NOT NULL,
    appointment_date DATE,
    notes TEXT,
    FOREIGN KEY (animal_id) REFERENCES animals(id) ON DELETE CASCADE,
    FOREIGN KEY (doctor_id) REFERENCES doctors(id) ON DELETE CASCADE
);

-- Tabela pośrednia: Relacja N:N - lekarze i ich pacjenci
CREATE TABLE animal_doctors (
    doctorsId INT NOT NULL,
    pacjentsId INT NOT NULL,
    PRIMARY KEY (doctorsId, pacjentsId),
    FOREIGN KEY (doctorsId) REFERENCES doctors(id) ON DELETE CASCADE,
    FOREIGN KEY (pacjentsId) REFERENCES animals(id) ON DELETE CASCADE
);

-- Przykładowe dane
INSERT INTO doctors (first_name, last_name, specialization, username, password_hash) VALUES
('Anna', 'Kowalska', 'Choroby wewnętrzne', 'student', 'JkyMOBvxbJgqTlmw3UxveAjFGgX2TDXbQsx4oqcodbs='),
('Piotr', 'Nowak', 'Chirurgia', 'student2', 'JkyMOBvxbJgqTlmw3UxveAjFGgX2TDXbQsx4oqcodbs='),
('Maria', 'Wiśniewska', 'Dermatologia', 'student3', 'JkyMOBvxbJgqTlmw3UxveAjFGgX2TDXbQsx4oqcodbs=');

INSERT INTO animals (name, species, breed, birth_date, owner_name) VALUES
('Burek', 'Pies', 'Labrador', '2020-03-15', 'Jan Nowak'),
('Mruczek', 'Kot', 'Syjamski', '2019-06-21', 'Anna Malinowska');

INSERT INTO vaccinations (animal_id, vaccine_name, date_given) VALUES
(1, 'Szczepionka przeciwko wściekliźnie', '2021-04-10'),
(2, 'Szczepionka przeciwko panleukopenii', '2022-02-01');

INSERT INTO appointments (animal_id, doctor_id, appointment_date, notes) VALUES
(1, 2, '2023-09-15', 'Usunięcie guza łapy.'),
(2, 3, '2024-01-10', 'Zaczerwienienie skóry - zalecono maść.');

-- Przypisanie pacjentów do lekarzy (animal_doctors)
INSERT INTO animal_doctors (doctorsId, pacjentsId) VALUES
(2, 1),
(3, 2);
