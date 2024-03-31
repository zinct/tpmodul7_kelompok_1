using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_1
{

    public class DataMahasiswa1302223029
    {
        public class Nama
        {
            public String depan;
            public String belakang;
        }
        public class Mahasiswa1302223029
        {
            public Nama nama;
            public String nim;
            public String fakultas;
        }

        public void readJSON()
        {
            var dataJson = File.ReadAllText("../../../tp7_1_1302220084.json");

            var mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302223029>(dataJson, new JsonSerializerOptions { IncludeFields = true });

            Console.WriteLine("Nama {0} {1} dengan nim {2}", mahasiswa.nama.depan, mahasiswa.nama.belakang, mahasiswa.nim);

        }
    }
}