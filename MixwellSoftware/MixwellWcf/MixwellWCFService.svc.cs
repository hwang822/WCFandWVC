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

        public List<string> GetAllData()
        {
            //throw new NotImplementedException();
            return new List<string>()
            {
            "carrot",
            "fox",
            "explorer"
            };
            
        }

        public string GetData(string id)
        {
            return String.Format("Data = {0}", id);

            //        throw new NotImplementedException();
        }

/*  //data base connection has problem at iis run
        public List<MixwellData> GetAllData()
        {
            using (var db = new MixwellDatabaseEntities())
            {
                return db.MixwellDatas.ToList();
            }


            //throw new NotImplementedException();
        }

        public MixwellData GetData(string id)
        {
            using (var db = new MixwellDatabaseEntities())
            {
                Int32 _id = Convert.ToInt32(id);
                return db.MixwellDatas.Single(p => p.id == _id);
            }
            //        throw new NotImplementedException();
        }
*/
        int IMixwellWCFService.AddData(MixwellData data)
        {
            using (var db = new MixwellDatabaseEntities())
            {
                db.MixwellDatas.Add(data);
                db.SaveChanges();
                return data.id;
            }

            //            throw new NotImplementedException();
        }

        bool IMixwellWCFService.UpdateData(MixwellData data)
        {
            using (var db = new MixwellDatabaseEntities())
            {
                MixwellData _pt = db.MixwellDatas.SingleOrDefault(p => p.id == data.id);
                _pt.name = data.name;
                _pt.place = data.place;
                db.SaveChanges();
                return true;
            }

            //            throw new NotImplementedException();
        }

        //*********************************
        //test service 
        /*

                public string GetData(int value)
                {
                    return string.Format("You entered: {0}", value);
                }

                public CompositeType GetDataUsingDataContract(CompositeType composite)
                {
                    if (composite == null)
                    {
                        throw new ArgumentNullException("composite");
                    }
                    if (composite.BoolValue)
                    {
                        composite.StringValue += "Suffix";
                    }
                    return composite;
                }
                */
    }
}
