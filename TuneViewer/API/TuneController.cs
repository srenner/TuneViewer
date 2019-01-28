using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TuneViewer.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TuneViewer.API
{
    [Route("api/[controller]")]
    public class TuneController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public Tune Get()
        {
            //start by returning sample data so i can focus on client side first
            var tune = new Tune
            {
                VersionInfo = new VersionInfo
                {
                    FileFormat = 5.0,
                    FirmwareInfo = "**+V2.92Embedded+Code+by+B%26G+**",
                    Pages = 2,
                    Signature = "MSII Rev 2.92000   "
                },
                Cylinders = 4,
                AFRTable1 = new AFRTable
                {
                    Cols = 12,
                    Rows = 12,
                    Units = "AFR",
                    Digits = 1,
                    Name = "afrTable1",
                    Cells = new double[,]
                    {
                        { 13.8, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7 },
                        { 14.0, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7 },
                        { 14.2, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7 },
                        { 14.5, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7 },
                        { 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7 },
                        { 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.6, 14.5 },
                        { 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.7, 14.4, 14.4, 14.4, 14.3, 14.2 },
                        { 12.5, 12.5, 12.5, 12.5, 12.5, 12.5, 12.5, 12.5, 12.5, 12.5, 12.5, 12.5 },
                        { 12.2, 12.2, 12.2, 12.2, 12.1, 12.0, 12.0, 12.0, 12.0, 12.0, 12.0, 12.0 },
                        { 11.7, 11.7, 11.7, 11.7, 11.7, 11.7, 11.7, 11.7, 11.7, 11.7, 11.6, 11.6 },
                        { 11.6, 11.6, 11.6, 11.6, 11.6, 11.6, 11.6, 11.6, 11.5, 11.5, 11.5, 11.5 },
                        { 11.5, 11.5, 11.5, 11.5, 11.5, 11.5, 11.5, 11.5, 11.4, 11.4, 11.4, 11.4 }
                    }
                }
            };

            return tune;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
