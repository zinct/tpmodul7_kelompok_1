
using System.Text.Json;
using System.Text;
using System.Diagnostics;
using static Dataamahasiswa1302220002;


internal class Program
{
    class KuliahMahasiswa1302220002
    {

        public class MataKuliah
        {
            public Cours[] courses { get; set; }
        }

        public class Cours
        {
            public string code { get; set; }
            public string name { get; set; }
        }

        public void readjsonMK()
        {
            string json = File.ReadAllText("../../../tp7_2_1302220002.json");
            var matakuliah = JsonSerializer.Deserialize<MataKuliah>(json);
            Console.WriteLine("Daftar Matakuliah yang diambil: ");
            for (int i = 0; i < matakuliah.courses.Length; i++)
            {
                Console.WriteLine($"MK {i + 1} {matakuliah.courses[i].code} - {matakuliah.courses[i].name}");
            }
        }

    }

    class Dataamahasiswa1302220002
    {
        public class Mahasiswa1302220002
        {
            public Nama nama { get; set; }
            public int nim { get; set; }
            public string fakultas { get; set; }


        }

        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public void readjson()
        {
            string Read_json = File.ReadAllText("../../../tp7_1_1302220002.json");
            //string json = JsonSerializer.Serialize(new Dataamahasiswa1302220002().);
            var mahasiswa_1302220002 = JsonSerializer.Deserialize<Mahasiswa1302220002>(Read_json);
            Console.WriteLine($"{mahasiswa_1302220002.nama.depan} {mahasiswa_1302220002.nama.belakang} dari fakultas {mahasiswa_1302220002.fakultas}");
        }
    }




    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var A = new Dataamahasiswa1302220002();
        A.readjson();Z
        var B = new KuliahMahasiswa1302220002();
        B.readjsonMK();
    }
}