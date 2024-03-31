using System.Diagnostics;
using System.Text.Json;
using static DataMahasiswa1302220067;

internal class Program
{
    private static void Main(string[] args)
    {
        var data = new DataMahasiswa1302220067();
        data.ReadJSON();
    }
}

class DataMahasiswa1302220067
{
    public class Mahasiswa
    {
        public Nama nama;
        public string nim;
        public string fakultas;
    }

    public class Nama
    {
        public string depan;
        public string belakang;
    }
    public void ReadJSON() 
    {
        string json = File.ReadAllText("../../../tp7_1_1302220067.json");
        var mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(json, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama {0} {1} dengan nim {2}", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim);
    }
}

public class KuliahMahasiswa1302220067
{
    public class Matakuliah
    {
        public Course[] courses;
    }

    public class Course
    {
        public string code;
        public string name;
    }
    public void ReadJSON()
    {
        string json = File.ReadAllText("../../../tp7_2_1302220067.json");
        var matakuliah = JsonSerializer.Deserialize<Matakuliah>(json, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Daftar mata kuliah yang diambil");
        for(int i = 0; i < matakuliah.courses.Length; i++)
        {
            Console.WriteLine("MK {0} {1}-{2}", i + 1, matakuliah.courses[i].code, matakuliah.courses[i].name);
        }
    }
}