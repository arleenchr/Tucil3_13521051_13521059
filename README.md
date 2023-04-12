# Tugas Kecil 3 IF2211 Strategi Algoritma: PathFinder

## Deskripsi Singkat Program
PathFinder adalah program untuk mencari rute terpendek dari suatu lokasi ke lokasi lainnya. Pencarian dilakukan dengan implementasi algoritma UCS (Uniform Cost Search) dan A*. Pengguna hanya perlu memasukkan file teks peta, lokasi awal dan tujuan, serta algoritma yang ingin digunakan. Input file teks peta berupa graf yang terdiri dari banyaknya simpul lokasi, detail lokasi (nama lokasi dan koordinat), serta matriks ketetanggaan berbobot dengan bobot merepresentasikan jarak antara dua simpul lokasi. Program akan memberikan keluaran rute dan jarak terpendek dari lokasi awal ke lokasi tujuan sesuai masukan pengguna.

## Sistematika File
```
Tucil3_13521051_13521059
├─── bin
│   ├─── map1.1.txt
│   ├─── map1.txt
│   ├─── map2.1.txt
│   ├─── map2.txt
│   ├─── map3.txt
│   ├─── map4.txt
│   ├─── map5.txt
│   └─── PathFinder.exe
├─── doc
|   └─── Tucil3_13521051_13521059.pdf
├─── src
|   └─── PathFinder
|   |    ├─── bin
|   |    |    └─── ...
|   |    ├─── obj
|   |    |    └─── ...
|   |    ├─── packages
|   |    |    └─── ...
|   |    ├─── PathFinder
|   |    |    └─── ...
|   |    ├─── Properties
|   |    |    └─── ...
|   |    ├─── App.config
|   |    ├─── A-star.cs
|   |    ├─── Coordinate.cs
|   |    ├─── Edge.cs
|   |    ├─── FileReader.cs
|   |    ├─── Graph.cs
|   |    ├─── packages.config
|   |    ├─── PathFinder.cs
|   |    ├─── PathFinder.csproj
|   |    ├─── PathFinder.Designer.cs
|   |    ├─── PathFinder.resx
|   |    ├─── PathFinder.sln
|   |    ├─── PriorityQueueCost.cs
|   |    ├─── Program.cs
|   |    ├─── Solver.cs
|   |    ├─── UCS.cs
|   |    └─── Vertex.cs
└─── README.md
```

## Requirements
- Windows 10 or newer

## Instruksi Pemakaian
- Clone Repository
```git clone https://github.com/arleenchr/Tucil3_13521051_13521059.git```
- Buka folder "Tucil3_13521051_13521059"
- Buka folder "bin"
- Jalankan (double klik) "PathFinder.exe"

## Credits
| NIM       | Nama                       |
| --------- | ---------------------------|
| 13521051  | Manuella Ivana Uli Sianipar|
| 13521059  | Arleen Chrysantha Gunardi  |
