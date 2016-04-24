using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class RazorPdfController : Controller
    {
        // GET: RazorPdf
        public ActionResult Index()
        {
            var studentMarks = new List<MarksCard>()
        {
           new MarksCard()
            {
                RollNo = 101, Subject = "C#",
                FullMarks = 100, Obtained = 90},new MarksCard() {RollNo = 101, Subject = "asp.net", FullMarks = 100, Obtained = 80},new MarksCard() {RollNo =               101, Subject = "MVC", FullMarks = 100,
                Obtained = 100},new MarksCard() {RollNo = 101, Subject = "SQL Server", FullMarks = 100, Obtained = 75},
        };
            return new RazorPDF.PdfResult(studentMarks, "Index");
        }
    }
}