
using System.Text.Json;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

internal class Program
{

    
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
        var A = new Dataamahasiswa1302220002();
        A.readjson();
    }
}