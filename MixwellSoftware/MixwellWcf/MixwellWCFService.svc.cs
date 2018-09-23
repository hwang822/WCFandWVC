using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MixwellWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MixwellWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class MixwellWCFService : IMixwellWCFService
    {
        private List<string> mixwelldata = new List<string>()
        {
            "carrot",
            "fox",
            "explorer"
        };

        //also create a data base connected by MixwellDataModuel.edmx
        /*
         Create Database MixwellDB
        Go

        Use MixwellDB
        Go

        Create table MixwellData
        (
	        ID int primary key identity,
	        Name nvarchar(50),
	        DOB nvarchar(50),
	        Place nvarchar(50)
        )
        Go

        Insert into MixwellData values ('Henry', '8/22/1960', 'Tanshan')
        Insert into MixwellData values ('Daisy', '3/31/1962', 'Kunming')
        Insert into MixwellData values ('Bowen', '1/6/1997', 'Houston')


        SELECT TOP 1000 [ID]
              ,[Name]
              ,[DOB]
              ,[Place]
          FROM [MixwellDB].[dbo].[MixwellData]

ID	Name	DOB	Place
1	Henry	8/22/1960	Tanshan
2	Daisy	3/31/1962	Kunming
3	Bowen	1/6/1997	Houston

        Add New Data/Entity Data Module as ADO.NET Employee DataBase Enitty Moudle ~ MixwellDBEntities, 
        Seelct EF Designer from Data base, select local server, database MixwellDB, MixwellData table to connection
        
        */


        //http://localhost:23506/MixwellWCFService.svc/GET
        //response ["carrot","fox","explorer"]
        public List<string> GetData()
        {
            //throw new NotImplementedException();
            //List<MixwellData> datas = GetAllData();
            return mixwelldata;
            
        }

        //http://localhost:23506/MixwellWCFService.svc/GET/1
        //response "fox"
        public string GetOneData(string id)
        {
            //MixwellData data = GetAData(id);
            return String.Format("{0}", mixwelldata[int.Parse(id)]);
            //        throw new NotImplementedException();
        }

        public void PostData(string data)
        {
            mixwelldata.Add(data);
        }

        public void PutData(string data, string id)
        {
            mixwelldata[int.Parse(id)] = data;
        }

        public void DeleteData(string id)
        {
            mixwelldata.RemoveAt(int.Parse(id));
        }

        //Here is GustomerService 
        //data base connection has problem at iis run
        public List<MixwellData> GetAllData()
        {
            using (var db = new MixwellDBEntities())
            {
                return db.MixwellDatas.ToList();
            }


            //throw new NotImplementedException();
        }

        public MixwellData GetAData(string id)
        {
            using (var db = new MixwellDBEntities())
            {
                Int32 _id = Convert.ToInt32(id);
                return db.MixwellDatas.Single(p => p.ID == _id);
            }
            //        throw new NotImplementedException();
        }

        int AddData(MixwellData data)
        {
            using (var db = new MixwellDBEntities())
            {
                db.MixwellDatas.Add(data);
                db.SaveChanges();
                return data.ID;
            }

            //            throw new NotImplementedException();
        }
        
        bool UpdateData(MixwellData data)
        {
            using (var db = new MixwellDBEntities())
            {
                MixwellData _pt = db.MixwellDatas.SingleOrDefault(p => p.ID == data.ID);
                _pt.Name = data.Name;
                _pt.Place = data.Place;
                db.SaveChanges();
                return true;
            }

            //            throw new NotImplementedException();
        }

        bool DeleteData(MixwellData data)
        {
            using (var db = new MixwellDBEntities())
            {
                MixwellData _pt = db.MixwellDatas.Remove(data);
                db.SaveChanges();
                return true;
            }

            //            throw new NotImplementedException();
        }

    }
}
