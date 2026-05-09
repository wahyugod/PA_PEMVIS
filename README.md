# WAHYU TECH - Aplikasi Manajemen Laptop (VB.NET + MySQL)

README ini menjelaskan cara menyiapkan database dan menjalankan aplikasi.

## 1. Prasyarat

- Windows + Visual Studio 2022 (workload .NET desktop development)
- .NET SDK 10.0 (sesuai TargetFramework `net10.0-windows`)
- MySQL Server (contoh: MySQL 8.x)
- Koneksi lokal MySQL aktif di `localhost:3306`

## 2. Setup Database

Jalankan SQL berikut di MySQL (MySQL Workbench / phpMyAdmin / terminal):

```sql
CREATE DATABASE IF NOT EXISTS dblaptop;
USE dblaptop;

CREATE TABLE `laptops` (
  `id` int(11) NOT NULL,
  `kodeMerk` varchar(10) DEFAULT NULL,
  `merk` varchar(50) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `harga` decimal(15,2) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `laptops` (`id`, `kodeMerk`, `merk`, `nama`, `harga`, `stok`) VALUES
(17, 'APL', 'Apple', 'MacBook Pro 16"', 3499.00, 38),
(18, 'DLL', 'Dell', 'XPS 15 OLED', 2199.00, 12),
(19, 'LNV', 'Lenovo', 'ThinkPad X1 Carbon', 1450.00, 3),
(20, 'MSF', 'Microsoft', 'Surface Laptop 5', 999.00, 137),
(21, 'HPQ', 'HP', 'EliteBook 840 G9', 1250.00, 35),
(22, 'ASU', 'Asus', 'ROG Zephyrus G14', 1699.00, 5),
(23, 'ACR', 'Acer', 'Swift 3', 750.00, 40),
(24, 'LNV', 'Lenovo', 'IdeaPad Slim 5', 850.00, 45),
(25, 'APL', 'Apple', 'MacBook Air M2', 1199.00, 25),
(26, 'DLL', 'Dell', 'Latitude 7420', 1350.00, 14);

CREATE TABLE `merk` (
  `kodeMerk` varchar(10) NOT NULL,
  `namaMerk` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `merk` (`kodeMerk`, `namaMerk`) VALUES
('ACR', 'Acer'),
('APL', 'Apple'),
('ASU', 'Asus'),
('DLL', 'Dell'),
('HPQ', 'HP'),
('LNV', 'Lenovo'),
('MSF', 'Microsoft');

CREATE TABLE `transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_laptop` int(11) NOT NULL,
  `tanggal_pembelian` datetime NOT NULL DEFAULT current_timestamp(),
  `jumlah_beli` int(11) NOT NULL,
  `total_harga` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `transaksi` (`id_transaksi`, `id_user`, `id_laptop`, `tanggal_pembelian`, `jumlah_beli`, `total_harga`) VALUES
(1, 3, 20, '2026-05-07 11:50:42', 5, 4995.00),
(2, 5, 20, '2026-05-09 18:45:23', 10, 9990.00),
(3, 5, 26, '2026-05-09 18:55:31', 4, 5400.00),
(4, 5, 23, '2026-05-09 18:55:37', 20, 15000.00),
(5, 5, 17, '2026-05-09 18:55:48', 4, 13996.00),
(6, 4, 22, '2026-05-09 18:56:02', 3, 5097.00);

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('admin','member') NOT NULL DEFAULT 'member'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

INSERT INTO `users` (`id`, `username`, `password`, `role`) VALUES
(1, 'admin', 'admin123', 'admin'),
(2, 'pais', 'pais', 'member'),
(3, 'tedi', 'tedi', 'member'),
(4, 'dwiki', 'dwiki', 'member'),
(5, 'jedan', 'jedan', 'member');

ALTER TABLE `laptops`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_laptops_merk` (`kodeMerk`);

ALTER TABLE `merk`
  ADD PRIMARY KEY (`kodeMerk`);

ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `fk_transaksi_user` (`id_user`),
  ADD KEY `fk_transaksi_laptop` (`id_laptop`);

ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

ALTER TABLE `laptops`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

ALTER TABLE `laptops`
  ADD CONSTRAINT `fk_laptops_merk` FOREIGN KEY (`kodeMerk`) REFERENCES `merk` (`kodeMerk`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `transaksi`
  ADD CONSTRAINT `fk_transaksi_laptop` FOREIGN KEY (`id_laptop`) REFERENCES `laptops` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_transaksi_user` FOREIGN KEY (`id_user`) REFERENCES `users` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
```

## 3. Cek Konfigurasi Koneksi

Di file `ConnectionModule.vb`, connection string default saat ini:

```vb
Public ReadOnly ConnectionString As String = "Server=localhost;Port=3306;Database=dblaptop;UserID=root;Password=;"
```

Jika MySQL kamu memakai password, ubah bagian `Password=` sesuai konfigurasi lokal.

## 4. Cara Menjalankan (Visual Studio)

1. Buka `PA_PEMVIS.slnx` atau `PA_PEMVIS/PA_PEMVIS.vbproj` di Visual Studio.
2. Tunggu proses restore NuGet selesai (MySqlConnector dan Guna.UI2.WinForms).
3. Pastikan project `PA_PEMVIS` menjadi Startup Project.
4. Jalankan dengan tombol `Start` atau `F5`.

## 5. Login Awal

- Username: `admin`
- Password: `admin123`

Setelah login berhasil, aplikasi menampilkan dashboard dan menu CRUD data laptop.

## 6. Menjalankan via CLI (opsional)

Di folder `PA_PEMVIS/PA_PEMVIS`, jalankan:

```bash
dotnet restore
dotnet run
```

## 7. Troubleshooting Singkat

- Gagal koneksi database: cek service MySQL aktif dan port `3306` benar.
- Login selalu gagal: pastikan tabel `users` berisi data `admin/admin123` untuk login admin.
- Error akses database: cek `UserID` dan `Password` pada connection string.
