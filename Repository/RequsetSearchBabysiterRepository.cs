using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;

namespace Repository
{
    public class RequsetSearchBabysiterRepository : IRequsetSearchBabysiterRepository
    {
        private readonly DB_BabySiterContext _DB_BABYSITERContext;

        public RequsetSearchBabysiterRepository(DB_BabySiterContext DB_BABYSITERContext)
        {
            _DB_BABYSITERContext = DB_BABYSITERContext;


        }
        async public Task<RequsetSearchBabysiter> GetRequsetSearchBabysiter(int id)
        {
            var userQuery = (from RequsetSearchBabysiter in _DB_BABYSITERContext.RequsetSearchBabysiters
                             where RequsetSearchBabysiter.SearchBabysiterId == id
                             select RequsetSearchBabysiter).ToArray<RequsetSearchBabysiter>();
            return userQuery.FirstOrDefault();



        }

        public async Task<RequsetSearchBabysiter[]> GetAllSearchBabysiter()
        {

            var list = (from b in _DB_BABYSITERContext.RequsetSearchBabysiters

                        select b).ToArray<RequsetSearchBabysiter>();
            return list;


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
        public async Task GetEmail(string email,string phone)
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
                    Subject = "נמצאה לך ביביסיטר מתאימה",
                    IsBodyHtml = true,
                    Body = $"תוכלי להתקשר לביביסיטר ולתאם איתה {phone}",
                    //Body = $"bnmtv gcukjjgj anxprv {email}",
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
                    //Body = $"bnmtv gcukjjgj anxprv {email}",
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
        public async Task RequsetSearch(int price, string day, string part_of_day, int neighborhood_id)
        {
            string connectionString = "Data Source=DESKTOP-2DTT4MQ;Initial Catalog=DB__BABYSITER;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT r.DAY, r.PART_OF_DAY, r.PRICE, n.NEIGHBORHOOD_ID, s.EMAIL, b.PHONE
FROM [dbo].[TIME] t JOIN [dbo].[NEIGHBORHOOD_BABYSITER] n on t.BABYSITER_ID = n.BABYSITER_ID 
JOIN [dbo].[BABYSITER] b on n.BABYSITER_ID = b.BABYSITER_ID
JOIN [dbo].[REQUSET_SEARCH_BABYSITER] r on t.DAY=r.DAY
AND r.PRICE=t.PRICE AND r.PART_OF_DAY=t.PART_OF_DAY
AND n.NEIGHBORHOOD_ID=r.NEIGHBORHOOD_ID
JOIN [dbo].[SEARCH_BABYSITER] s on r.SEARCH_BABYSITER_ID = s.SEARCH_BABYSITER_ID";
                //FROM [dbo].[TIME] t
                //JOIN [dbo].[BABYSITER] b on n.BABYSITER_ID = b.BABYSITER_ID
                //JOIN [dbo].[NEIGHBORHOOD_BABYSITER] n ON t.BABYSITER_ID = n.BABYSITER_ID
                //JOIN [dbo].[REQUSET_SEARCH_BABYSITER] r ON t.DAY = r.DAY AND r.PRICE = t.PRICE AND r.PART_OF_DAY = t.PART_OF_DAY
                //    AND n.NEIGHBORHOOD_ID = r.NEIGHBORHOOD_ID
                //JOIN[dbo].[SEARCH_BABYSITER] s ON r.SEARCH_BABYSITER_ID = s.SEARCH_BABYSITER_ID";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                // Process the results
                while (reader.Read())
                {
                    // Access the data using reader.GetValue() or reader["COLUMN_NAME"]
                    // Example:
                      int NEIGHBORHOOD_ID = reader.GetInt32(reader.GetOrdinal("NEIGHBORHOOD_ID"));
                    string DAY = reader.GetString(reader.GetOrdinal("DAY"));
                    string PART_OF_DAY = reader.GetString(reader.GetOrdinal("PART_OF_DAY"));
                    int PRICE = reader.GetInt32(reader.GetOrdinal("PRICE"));
                    string EMAIL = reader.GetString(reader.GetOrdinal("EMAIL"));
                    string PHONE = reader.GetString(reader.GetOrdinal("PHONE"));
                    if (NEIGHBORHOOD_ID==neighborhood_id && DAY==day&& PART_OF_DAY==part_of_day && PRICE==price)
                    {
                        GetEmail(EMAIL, PHONE);
                        break;
                    }
                    ///if(כל הנתונים של הבייביסטר מתאימיםלאחת הבקשות)}
                    ///שולחת מייל לאישה שיש התאמה בינהם
                    // ...
                }

                reader.Close();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}




