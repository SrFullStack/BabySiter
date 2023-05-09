using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RequsetSearchBabysiterRepository: IRequsetSearchBabysiterRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;

        public RequsetSearchBabysiterRepository(DB_BabySiterContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;


        }
        async public Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id)
        {
            var userQuery = (from RequsetSearchBabysiter in _DB_BABYSITERContext.RequsetSearchBabysiters
                             where RequsetSearchBabysiter.SearchBabysiterId== id
                             select RequsetSearchBabysiter).ToArray<RequsetSearchBabysiter>();
            return userQuery.FirstOrDefault();



        }
        public async Task<RequsetSearchBabysiter> Insert(RequsetSearchBabysiter requsetSearchBabysiter)
        {
            await _DB_BABYSITERContext.AddAsync(requsetSearchBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return requsetSearchBabysiter;
        }
        public async Task<RequsetSearchBabysiter> put(int id, RequsetSearchBabysiter requsetSearchBabysiter)
        {
            _DB_BABYSITERContext.RequsetSearchBabysiters.Update(requsetSearchBabysiter);
            await _DB_BABYSITERContext.SaveChangesAsync();
            return requsetSearchBabysiter;
        }

        public async Task GetEmail(string email)
        {
            using (SmtpClient client = new SmtpClient()
            {
                Host = "smtp.office365.com",
                Port = 587,
                UseDefaultCredentials = false, // This require to be before setting Credentials property
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("36214122228@mby.co.il", "Student@264"), // you must give a full email address for authentication 
                TargetName = "STARTTLS/smtp.office365.com", // Set to avoid MustIssueStartTlsFirst exception
                EnableSsl = true // Set to avoid secure connection exception
            })
            {

                MailMessage message = new MailMessage()
                {
                    From = new MailAddress("36214122228@mby.co.il"), // sender must be a full email address
                    Subject = "הרשמה",
                    IsBodyHtml = true,
                    Body = "<h1>להרשמה לחצו על הלינק הבא:</h1>http://localhost:3000/",
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8,

                };

                message.To.Add(email);

                try
                {
                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

    }
   
}
