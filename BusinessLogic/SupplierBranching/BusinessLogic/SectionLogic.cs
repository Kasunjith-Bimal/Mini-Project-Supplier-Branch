using DataHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SectionLogic
    {
        SectionData db = new SectionData();

        public void addSection(SectionDTO obj)
        {
            try
            {

                db.addSectionDb(obj);

            }
            catch(Exception ex)
            {
                throw;
            }

        }

        public List<SectionDTO> SectonDatalistLogic()
        {
            List<SectionDTO> List = new List<SectionDTO>();
            try
            {

                List = db.SectonDatalist();
                
            }
            catch (Exception ex)
            {

                throw;
            }


            return List;
        }

        public void Deletelogic(int id)
        {



            try
            {
                db.Deletedb(id);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }



        public void EditLogic(SectionDTO Obj)
        {
            try
            {
                db.EditDb(Obj);
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}
