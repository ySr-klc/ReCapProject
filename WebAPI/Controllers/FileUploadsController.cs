
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
        public static ICarImageService _carImageService;
        public static  IWebHostEnvironment _webHostEnviroment;

        public FileUploadsController(IWebHostEnvironment webHostEnviroment, ICarImageService carImageService)
        {
            _webHostEnviroment = webHostEnviroment;
            _carImageService = carImageService;
        }


        [HttpPost]

        public string Post([FromForm] FileUpload fileUpload)
        {
            try
            {
                if (fileUpload.files.Length > 0 )
                {
                    string path = _webHostEnviroment.WebRootPath + "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + fileUpload.files.FileName))
                    {
                        fileUpload.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "Uploaded";
                    }
                }
                else
                {
                    return "Not Uploaded";
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
