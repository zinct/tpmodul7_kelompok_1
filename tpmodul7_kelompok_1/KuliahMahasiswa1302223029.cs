using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static tpmodul7_kelompok_1.DataMahasiswa1302223029;
using static tpmodul7_kelompok_1.KuliahMahasiswa1302223029;

namespace tpmodul7_kelompok_1
{
    internal class KuliahMahasiswa1302223029
    {
        public class MataKuliah
        {
            public String code;
            public String name;
        }
        public class Courses
        {
            public MataKuliah[] courses;
        }

        public void readJSON()
        {
            var dataJson = File.ReadAllText("../../../tp7_2_1302223029.json");

            var mataKuliah = JsonSerializer.Deserialize<Courses>(dataJson, new JsonSerializerOptions { IncludeFields = true });
            Console.WriteLine("Daftar mata kuliah yang diambil");

            for (int i = 0; i < mataKuliah.courses.Length; i++)
            {
                Console.WriteLine("MK {0} {1}-{2}", i + 1, mataKuliah.courses[i].code, mataKuliah.courses[i].name);
            }
        }
    }
}