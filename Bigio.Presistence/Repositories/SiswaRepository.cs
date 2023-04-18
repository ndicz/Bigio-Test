using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bigio.Persistence.RepositoryContext;
using Bigio.Presistence.Base;
using BigioDomain.Entities;
using BigioDomain.Repositories;

namespace Bigio.Presistence.Repositories
{
    public class SiswaRepository : RepositoryBase<Siswa>, ISiswaRepository

    {
        public SiswaRepository(AdoDbContext adoContext) : base(adoContext)
        {
        }


        public Task<IEnumerable<Siswa>> FindAllSiswaAsync()
        {
            throw new NotImplementedException();
        }

        public Siswa FindSiswaById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Siswa siswa)
        {
            SqlCommandModel model = new SqlCommandModel()
            {
                CommandText = $"INSERT INTO siswa (nama, username, password) " +
                              $"VALUES (@nama,@username,@pass);",
                CommandType = CommandType.Text,
                CommandParameters = new SqlCommandParameterModel[]
                {
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@nama",
                        DataType = DbType.String,
                        Value = siswa.nama
                    },
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@username",
                        DataType = DbType.String,
                        Value = siswa.username
                    },
                    new SqlCommandParameterModel()
                    {
                        ParameterName = "@pass",
                        DataType = DbType.String,
                        Value = siswa.password
                    }

                }

            };
            _adoContext.ExecuteNonQuery(model);
            _adoContext.Dispose();
        }
        public void Edit(Siswa siswa)
        {
            throw new NotImplementedException();
        }

        public void Remove(Siswa siswa)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Siswa> FindAllSiswa()
        {
            IEnumerator<Siswa> dataSet = FindAll<Siswa>("select *from siswa");

            while (dataSet.MoveNext())
            {
                var data = dataSet.Current;
                yield return data;
            }
        }

        public IEnumerable<Siswa> FindLastSiswaId()
        {
            IEnumerator<Siswa> dataset = FindAll<Siswa>("SELECT * FROM siswa where id_siswa =(SELECT IDENT_CURRENT('siswa'));");
            while (dataset.MoveNext())
            {
                var data = dataset.Current;
                yield return data;
            }
        }
    }
}
