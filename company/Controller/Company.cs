

using Microsoft.AspNetCore.Mvc;

[Route("[Action]")]
[ApiController]

public class Company:ControllerBase
{
     Context db=new Context();

     //inser
     [HttpPost]
     public void Insert(Model_Company company)
     {

          TCompany tcompany=new TCompany();
          tcompany.Name=company.Name;
          db.Table_Company.Add(tcompany);
          db.SaveChanges();

        
     }

    
}