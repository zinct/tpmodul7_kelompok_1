using System.Diagnostics;
using System.Text.Json;

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