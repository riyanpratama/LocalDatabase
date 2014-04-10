using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// komponen yang diperlukan
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace LocalDatabase
{
    // perlu ditambahkan [Table] untuk membuat tabel
    [Table]
    public class Contact
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, DbType = "INT NOT NULL Identity")]
        public int idContact { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Phone { get; set; }
    }

    // buat class yang extend DataContext
    public class ContactContext : DataContext
    {
        public Table<Contact> mahasiswa;
        public ContactContext(string connectionstring) : base(connectionstring) { }
    }
}
