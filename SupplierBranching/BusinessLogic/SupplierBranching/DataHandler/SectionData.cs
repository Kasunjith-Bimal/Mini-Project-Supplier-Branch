using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler
{
    public class SectionData
    {
        public void addSectionDb(SectionDTO obj)
        {

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    Section sectionadddetails = new Section();


                    sectionadddetails.IdentificationCode = obj.IdentificationCode;
                    sectionadddetails.SectionName = obj.SectionName;

                    context.Sections.Add(sectionadddetails);
                    context.SaveChanges();
                    


                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<SectionDTO> SectonDatalist()
        {
            List<SectionDTO> List = new List<SectionDTO>();
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {

                    List<Section> Retunlist = (from recode in context.Sections select recode).ToList();

                    foreach (Section item in Retunlist)
                    {
                        SectionDTO obj = new SectionDTO();

                        obj.SectionId = item.Id;
                        obj.IdentificationCode = item.IdentificationCode;
                        obj.SectionName = item.SectionName;

                        List.Add(obj);
                    }


                }
            }
            catch (Exception ex)
            {
                
                throw;
            }


            return List;
        }


        public void Deletedb(int ID) {

            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {


                    Section delete = (from recod in context.Sections where recod.Id == ID select recod).FirstOrDefault();
                    context.Sections.Remove(delete);
                    context.SaveChanges();
                
                }

            }
            catch (Exception ex)
            {
                
                throw;
            }
        
        
        }


        public void EditDb(SectionDTO Obj)
        {
            try
            {
                using (SuppliesBranchEntities context = new SuppliesBranchEntities())
                {
                    Section editdata = (from recode in context.Sections where recode.Id == Obj.SectionId select recode).FirstOrDefault();


                    editdata.IdentificationCode = Obj.IdentificationCode;
                    editdata.SectionName = Obj.SectionName;


                    context.Entry(editdata).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
